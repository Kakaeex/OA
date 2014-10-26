using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using FineUI;
using Newtonsoft.Json;
using OAContext;
using DBContextHelper;
using OA.Interface;
using OA.Common;
using System.Data;

namespace OA.View.Finance.P0930
{
    public partial class P0930E : PagedBase, IEditPage
    {
        #region Event
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Master.QueryString.ContainsKey("MODE")) return;

            mode.Text = Master.QueryString["MODE"];
            if (!IsPostBack)
            {
                CHSRP2.DataSource = Master._UDC.GetUDCList(CHSRP2.ID);
                CHSRP2.DataBind();
                ViewState["data"] = new List<C_F0931>();
                lnid.Text = "1";
            }
        }
        protected void TriggerClick(object sender, EventArgs e)
        {
            TriggerBox tBox = sender as TriggerBox;
            string URL = Master._UDC.GetSelectionView(tBox.ID);
            Dictionary<string, string> dic = new Dictionary<string, string>();
            switch (tBox.ID)
            {
                case "CDPRP1":
                    dic.Add("DOCO", CHMCU.Text);
                    URL += Master._WebHelper.SetQueryString(dic);
                    break;
                case "CDFAID":
                    int doco = ValueConvert.toInt(CHMCU.Text);
                    object[] key = Grid1.Rows[ValueConvert.toInt(selected)].DataKeys;
                    int lind=ValueConvert.toInt(key[0]);
                    string CDMAID = (ViewState["data"] as List<C_F0931>).Find(p => p.CDDLNID == lind).CDMAID;
                    //dic.Add("MODE", "V_F0901B");
                    //dic.Add("MCU", Master._DBHelper.Find<C_F0920>(p => p.FHDOCO == doco).FHMCU);
                    dic.Add("AID", CDMAID);
                    URL += Master._WebHelper.SetQueryString(dic);

                    break;
                case "CHMCU":
                    dic.Add("STYL", "CP");
                    dic.Add("COLUMN", "0,2");
                    dic.Add("MODE", "4");
                    dic.Add("AN8", "Master.userID");
                    URL += Master._WebHelper.SetQueryString(dic);
                    PageContext.RegisterStartupScript(windows.GetSaveStateReference(tBox.ClientID, CHDSC2.ClientID) + windows.GetShowReference(URL));
                    windows.Hidden = false;
                    return;
                default: break;
            }
            PageContext.RegisterStartupScript(windows.GetSaveStateReference(tBox.ClientID) + windows.GetShowReference(URL));
            windows.Hidden = false;
        }
        protected void Trigger_Blur(object sender, EventArgs e)
        {
            //TriggerBox tBox = sender as TriggerBox;
        }
        public void AfterEdit(GridAfterEditEventArgs e)
        {
            //Grid1. Rows[e.RowIndex].Values[0] = "00068";
           
        }
        protected void Grid1_PreRowDataBound(object sender, GridPreRowEventArgs e)
        {
            //FineUI.RenderField filed = Grid1.FindColumn("FDAID") as FineUI.RenderField;
            //FineUI.TriggerBox box = filed.FindControl("FDAID") as FineUI.TriggerBox;
            C_F0931 row = e.DataItem as C_F0931;
            if (ValueConvert.toInt(lnid) <= row.CDDLNID)
                lnid.Text = (row.CDDLNID + 1).ToString();
        }
        #endregion

        #region Methods
        public void BindGrid()
        {
            int doco = ValueConvert.toInt(CHDOCO);
            if (doco <= 0) return;
            ViewState["data"] = 
                Master._DBHelper.FindAll<C_F0931, int>(p => p.CDDOCO == doco & p.CDDCTO == CHDCTO.Text, p => p.CDDLNID);
            //Master.bind<C_F0931, int>(p => p.CDDOCO == doco & p.CDDCTO == CHDCTO.Text, p => p.CDDLNID);
            Grid1.DataSource = ViewState["data"] as List<C_F0931>;
            Grid1.DataBind();
            if (mode.Text == "edit" & Grid1.RecordCount <= 0) Master._UserAuthorization.DisableToolbar(toolBar);
        }
        public void Bind()
        {
            if (mode.Text == "edit")
            {
                CHDOCO.Text = Master.QueryString["DOCO"];
                CHDCTO.Text = Master.QueryString["DCTO"];
                int doco = ValueConvert.toInt(CHDOCO);
                var F0930 = Master._DBHelper.Find<C_F0930>(p => p.CHDOCO == doco & p.CHDCTO == CHDCTO.Text);
                if (F0930 == null)
                {
                    Master._UserAuthorization.DisableToolbar(toolBar);
                    return;
                }
                CHMCU.Text = F0930.CHMCU;
                CHDSC2.Text = F0930.CHDSC2;
                CHDSC1.Text = F0930.CHDSC1;
                AN8.Text = F0930.CHTORG;
                CHSRP2.Text = F0930.CHSRP2;
                CHVR01.Text = F0930.CHVR01;
                CHVR02.Text = F0930.CHVR02;

                if (F0930.CHNXTR != "100")
                {
                    Button save = Toolbar.FindControl("toolSave") as Button;
                    Button add = Toolbar.FindControl("toolBarNew") as Button;
                    Button delete = Toolbar.FindControl("toolBarDelete") as Button;
                    save.Visible = false;
                    add.Visible = false;
                    delete.Visible = false;
                }
            }
        }
        public dynamic OnValidate<T>(string type, T obj) where T : ModelBase
        {
            Master.AddMessage(_Account.CostProjectLimitedCheck(obj as C_F0931, type));
            return null;
        }
        public dynamic GetGridRowData(Dictionary<string, object> rowDict = null, object[] values = null, int deletedRows = -1)
        {
            C_F0930 F0930 = ViewState["C_F0930"] as C_F0930;

            int e_mcu = ValueConvert.toInt(CHMCU);
            C_F0931 obj = new C_F0931(1);
            if (rowDict != null)
            {
                #region 新增
                obj.CDSRP1 = CHMCU.Text;//报销项目
                obj.CDKCOO = F0930.CHKCOO;
                obj.CDDOCO = F0930.CHDOCO;
                obj.CDDCTO = F0930.CHDCTO;
                obj.CDDLNID = ValueConvert.toInt(rowDict["CDDLNID"]);
                obj.CDDOC = F0930.CHDOC;
                obj.CDDCT = F0930.CHDCT;
                obj.CDDSC1 = rowDict["CDDSC1"].ToString();
                obj.CDPRP1 = ValueConvert.toInt(rowDict["CDPRP1"]);
                var en_F0921 = Master._DBHelper.Find<C_F0921>(p => p.FDDOCO == e_mcu & p.FDLNID == obj.CDPRP1);
                obj.CDMAID = en_F0921.FDAID;
                obj.CDMMCU = en_F0921.FDMCU;
                obj.CDDEL1 = en_F0921.FDDSC1;//rowDict["CDDEL1"].ToString();
                obj.CDFAID = rowDict["CDFAID"].ToString();
                obj.CDFMCU = en_F0921.FDMCU;
                var en_F0901 = Master._DBHelper.Find<C_F0901>(p => p.GMMCU == obj.CDFMCU & p.GMAID == obj.CDFAID);
                obj.CDFOBJ = en_F0901.GMOBJ;
                obj.CDFSUB = en_F0901.GMSUB;
                obj.CDDEL2 = en_F0901.GMDL01;
                obj.CDTRDJ = Master.now;
                obj.CDPRP2 = F0930.CHPRP2;
                obj.CDUPRC = ValueConvert.toInt(rowDict["CDUPRC"]);
                obj.CDUSER = Master.userID;
                obj.CDPID = Master.progammeID;
                obj.CDDATE = Master.now;
                obj.CDTIME = Master.time;
                return obj;
                #endregion
            }
            else if (values != null)
            {
                #region 修改
                int _lind = ValueConvert.toInt(values[0]);
                var _obj = Master._DBHelper.Find<C_F0931>(p => p.CDDOCO == F0930.CHDOCO &
                    p.CDDCTO == F0930.CHDCTO & p.CDDLNID == _lind);
                if (_obj == null) return obj;
                obj.CDKCOO = F0930.CHKCOO;
                obj.CDDOCO = F0930.CHDOCO;
                obj.CDDCTO = F0930.CHDCTO;
                obj.CDDLNID = _lind;
                obj.CDDOC = F0930.CHDOC;
                obj.CDDCT = F0930.CHDCT;
                obj.CDDSC1 = values[1].ToString();
                obj.CDPRP1 = ValueConvert.toInt(values[2]);
                var en_F0921 = Master._DBHelper.Find<C_F0921>(p => p.FDDOCO == e_mcu & p.FDLNID == obj.CDPRP1);
                obj.CDMAID = en_F0921.FDAID;
                obj.CDMMCU = en_F0921.FDMCU;
                obj.CDDEL1 = en_F0921.FDDSC1;
                obj.CDFAID = values[5].ToString();
                obj.CDFMCU = en_F0921.FDMCU;
                var en_F0901 = Master._DBHelper.Find<C_F0901>(p => p.GMMCU == obj.CDFMCU & p.GMAID == obj.CDFAID);
                obj.CDFOBJ = en_F0901.GMOBJ;
                obj.CDFSUB = en_F0901.GMSUB;
                obj.CDDEL2 = en_F0901.GMDL01;
                obj.CDPRP2 = F0930.CHPRP2;
                obj.CDTRDJ = Master.now;
                obj.CDUPRC = ValueConvert.toDecimal(values[7]);
                obj.CDUSER = Master.userID;
                obj.CDPID = Master.progammeID;
                obj.CDDATE = Master.now;
                obj.CDTIME = Master.time;

                return obj;
                #endregion
            }
            else if (deletedRows >= 0)
            {
                #region 删除
                int DOCO = F0930.CHDOCO;
                string DCTO = F0930.CHDCTO;
                int LIND = ValueConvert.toInt(Grid1.DataKeys[deletedRows][0]);
                obj = Master._DBHelper.Find<C_F0931>(p => p.CDDOCO == DOCO & p.CDDCTO == DCTO & p.CDDLNID == LIND);
                return obj;
                #endregion
            }
            else
            {
                if (CHMCU.Text == "" || CHDCTO.Text == "") return null;
                if (mode.Text == "add" & CHDOCO.Text=="") CHDOCO.Text = Master._Order.GetNextNumber(CHDCTO.Text, Master.kcoo, "费用单").ToString();
                obj.CDDOCO = ValueConvert.toInt(CHDOCO);
                obj.CDDCTO = CHDCTO.Text;
                obj.CDDLNID = ValueConvert.toInt(lnid);
                lnid.Text = (ValueConvert.toInt(lnid) + 1).ToString();
                (ViewState["data"] as List<C_F0931>).Add(obj);
                return obj;
            }
        }
        public void Save()
        {
            Master.ClearMessage();
            if (ViewState["C_F0930"] == null) GetF0930();
            C_F0930 F0930 = ViewState["C_F0930"] as C_F0930;
            List<C_F0931> e_f0931_list = ViewState["data"] as List<C_F0931>;
            //Master.ValidateRecord<C_F0931>(Grid1.GetDeletedList(), Grid1.GetModifiedDict(), Grid1.GetNewAddedList(), GetGridRowData);
            //检查数据合法性
            foreach (var e_obj in e_f0931_list)
            {
                
                OnValidate<C_F0931>("newAdded", e_obj);
            }
            if (Master.messageList.Count > 0)
            {
                Alert.Show(Master.messageList[0]);
                return;
            }
            //新增表头和明细
            if (Master._DBHelper.AddorUpdate<C_F0930>(F0930) > 0)
            {
                saveRecord(e_f0931_list);
            }
            else
            {
                Master.AddMessage(Master._Message.GetMessage("WARM", "000").MSDSC1);
                Alert.Show(Master.messageList[0]);
                return;
            }

            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("DOCO", CHDOCO.Text);
            dic.Add("DCTO", CHDCTO.Text);
            FineUI.PageContext.Redirect(Master._UserAuthorization.GetApplication(Master.kcoo, "P2012E") + Master._WebHelper.SetQueryString(dic));
        }

        public dynamic saveRecord(List<C_F0931> List_Data) 
        {
            if (List_Data != null)
            {
                foreach (var e_obj in List_Data)
                {
                    Master.AddMessage(_Account.CostProjectLimitedCheck(e_obj as C_F0931, "newAdded"));
                    if (Master.messageList.Count() > 0)
                    {
                        Alert.Show(Master.messageList[0]);
                        return null;
                    }
                    else
                    {
                        Master._DBHelper.AddorUpdate<C_F0931>(e_obj);
                        _Account.CostProjectEditApply(e_obj);
                    }
                }
            }

            return null;
        }

        public void DeleteRow()
        {

        }
        public string GetFromMode()
        {
            //return "Windows";
            return "Tab";
        }
        public void Print()
        {
            //PageContext.RegisterStartupScript("Print();");
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("doco", CHDOCO.Text);
            dic.Add("dcto", CHDCTO.Text);
            string url = Master._UserAuthorization.GetApplication(Master.kcoo, "R0930A").Replace("~/", "")
                + Master._WebHelper.SetQueryString(dic);
            PageContext.RegisterStartupScript(
                string.Format("window.open('{0}','_blank');", Master._WebHelper.GetHostUri(url))
                );
        }
        #endregion

        #region Object
        public IAccount _Account { get; set; }
        public Grid Grid
        {
            get
            {
                Grid1.PageSize = 100000;
                return Grid1;
            }
        }

        public Label Label
        {
            get
            {
                return PageMessage;
            }
        }

        public Toolbar Toolbar
        {
            get
            {
                return toolBar;
            }
        }

        public string[] Forms
        {
            get
            {
                string[] _forms = { this.Form1.ID };
                return _forms;
            }
        }
        #endregion

        protected void Grid1_AfterEdit(object sender, GridAfterEditEventArgs e)
        {
            saveView<C_F0931>(Grid1.GetModifiedDict(), Grid1.GetNewAddedList(), Grid1.GetDeletedList(), GetTempData);
            Grid1.DataSource = ViewState["data"] as List<C_F0931>;
            Grid1.DataBind();
        }

        void GetF0930()
        {
            int doco = ValueConvert.toInt(CHDOCO);
            C_F0930 F0930 = Master._DBHelper.Find<C_F0930>
                (p => p.CHDOCO == doco & p.CHDCTO == CHDCTO.Text);
            if (F0930 == null)
            {
                F0930 = new C_F0930(1);
                F0930.CHDOCO = ValueConvert.toInt(CHDOCO.Text);
            }
            F0930.CHMCU = CHMCU.Text;
            int edoco = ValueConvert.toInt(CHMCU.Text);
            var ef0920 = Master._DBHelper.Find<C_F0920>(p => p.FHDOCO == edoco);
            F0930.CHDCTO = CHDCTO.Text;
            F0930.CHKCOO = ef0920.FHKCOO;
            F0930.CHDOC = ValueConvert.toInt(ef0920.FHSRP1);//工作流单
            F0930.CHDCT = ef0920.FHSRP2;//工作流类型
            F0930.CHDSC1 = CHDSC1.Text;
            F0930.CHDSC2 = CHDSC2.Text;
            F0930.CHNXTR = "100";
            F0930.CHLTTR = "0";
            F0930.CHSRP1 = CHMCU.Text;
            F0930.CHPRP2 = ef0920.FHYAER;
            F0930.CHTORG = AN8.Text ;
            F0930.CHSRP2 = CHSRP2.SelectedItem.Value;
            F0930.CHVR01 = CHVR01.Text;
            F0930.CHVR02 = CHVR02.Text;

            F0930.CHUSER = Master.userID;
            F0930.CHPID = Master.progammeID;
            F0930.CHDATE = Master.now;
            F0930.CHTIME = Master.time;
            ViewState["C_F0930"] = F0930;
        }

        public dynamic GetTempData(Dictionary<string, object> rowDict = null, object[] values = null, int deletedRows = -1)
        {
            C_F0930 F0930 = ViewState["C_F0930"] as C_F0930;

            int e_mcu = ValueConvert.toInt(CHMCU);
            C_F0931 obj = new C_F0931(1);
            if (rowDict != null)
            {
                #region 新增
                obj.CDSRP1 = CHMCU.Text;//报销项目
                obj.CDKCOO = F0930.CHKCOO;
                obj.CDDOCO = F0930.CHDOCO;
                obj.CDDCTO = F0930.CHDCTO;
                obj.CDDLNID = ValueConvert.toInt(rowDict["CDDLNID"]);
                obj.CDDOC = F0930.CHDOC;
                obj.CDDCT = F0930.CHDCT;
                obj.CDDSC1 = rowDict["CDDSC1"].ToString();
                obj.CDPRP1 = ValueConvert.toInt(rowDict["CDPRP1"]);
                var en_F0921 = Master._DBHelper.Find<C_F0921>(p => p.FDDOCO == e_mcu & p.FDLNID == obj.CDPRP1);
                if (en_F0921 != null)
                {
                    obj.CDMAID = en_F0921.FDAID;
                    obj.CDMMCU = en_F0921.FDMCU;
                    obj.CDDEL1 = en_F0921.FDDSC1;//rowDict["CDDEL1"].ToString();
                    obj.CDFAID = rowDict["CDFAID"].ToString();
                    obj.CDFMCU = en_F0921.FDMCU;
                }
                var en_F0901 = Master._DBHelper.Find<C_F0901>(p => p.GMCO == "00068" & p.GMAID == obj.CDFAID);
                if (en_F0901 != null)
                {
                    obj.CDFOBJ = en_F0901.GMOBJ;
                    obj.CDFSUB = en_F0901.GMSUB;
                    obj.CDDEL2 = en_F0901.GMDL01;
                }
                obj.CDTRDJ = Master.now;
                obj.CDPRP2 = F0930.CHPRP2;
                obj.CDUPRC = ValueConvert.toInt(rowDict["CDUPRC"]);
                obj.CDUSER = Master.userID;
                obj.CDPID = Master.progammeID;
                obj.CDDATE = Master.now;
                obj.CDTIME = Master.time;
                return obj;
                #endregion
            }
            else if (values != null)
            {
                #region 修改
                int _lind = ValueConvert.toInt(values[0]);
                obj.CDSRP1 = CHMCU.Text;//报销项目
                obj.CDKCOO = F0930.CHKCOO;
                obj.CDDOCO = F0930.CHDOCO;
                obj.CDDCTO = F0930.CHDCTO;
                obj.CDDLNID = _lind;
                obj.CDDOC = F0930.CHDOC;
                obj.CDDCT = F0930.CHDCT;
                obj.CDDSC1 = values[1].ToString();
                obj.CDPRP1 = ValueConvert.toInt(values[2]);
                var en_F0921 = Master._DBHelper.Find<C_F0921>(p => p.FDDOCO == e_mcu & p.FDLNID == obj.CDPRP1);
                if (en_F0921 != null)
                {
                    obj.CDMAID = en_F0921.FDAID;
                    obj.CDMMCU = en_F0921.FDMCU;
                    obj.CDDEL1 = en_F0921.FDDSC1;
                    obj.CDFAID = values[5].ToString();
                    obj.CDFMCU = en_F0921.FDMCU;
                }
                var en_F0901 = Master._DBHelper.Find<C_F0901>(p => p.GMCO == "00068" & p.GMAID == obj.CDFAID);
                if (en_F0901 != null)
                {
                    obj.CDFOBJ = en_F0901.GMOBJ;
                    obj.CDFSUB = en_F0901.GMSUB;
                    obj.CDDEL2 = en_F0901.GMDL01;
                }
                obj.CDPRP2 = F0930.CHPRP2;
                obj.CDTRDJ = Master.now;
                obj.CDUPRC = ValueConvert.toDecimal(values[7]);
                obj.CDUSER = Master.userID;
                obj.CDPID = Master.progammeID;
                obj.CDDATE = Master.now;
                obj.CDTIME = Master.time;

                return obj;
                #endregion
            }
            else if (deletedRows >= 0)
            {
                #region 删除
                int DOCO = F0930.CHDOCO;
                string DCTO = F0930.CHDCTO;
                int LIND = ValueConvert.toInt(Grid1.DataKeys[deletedRows][0]);
                obj = Master._DBHelper.Find<C_F0931>(p => p.CDDOCO == DOCO & p.CDDCTO == DCTO & p.CDDLNID == LIND);
                return obj;
                #endregion
            }

            return null;
        }
        public void saveView<T>(Dictionary<int, Dictionary<string, object>> modifiedDict,
   List<Dictionary<string, object>> newAddedList,List<int> deletedRows, Func<Dictionary<string, object>, object[], int, dynamic> GetGridRowData) where T : ModelBase
        {
            if (ViewState["C_F0930"] == null) GetF0930();
            // newAdded,modified
            T lobj = default(T);
            // 修改的现有数据
            List<C_F0931> e_list = ViewState["data"] as List<C_F0931>;
            if (modifiedDict != null)
            {
                foreach (int rowIndex in modifiedDict.Keys)
                {

                    lobj = GetTempData(null, Grid1.Rows[rowIndex].Values, 0);
                    if (lobj != null)
                    {
                        C_F0931 xx = lobj as C_F0931;
                        e_list.RemoveAll(p => p.CDDOCO == xx.CDDOCO 
                            & p.CDDCTO == xx.CDDCTO & p.CDDLNID == xx.CDDLNID);
                        e_list.Add(xx);
                    }
                }
            }
            if (newAddedList != null)
            {
                // 新增数据
                for (int i = newAddedList.Count - 1; i >= 0; i--)
                {
                    lobj = GetTempData(newAddedList[i], null, 0);
                    if (lobj != null)
                    {
                        C_F0931 xx = lobj as C_F0931;
                        e_list.RemoveAll(p => p.CDDOCO == xx.CDDOCO
                            & p.CDDCTO == xx.CDDCTO & p.CDDLNID == xx.CDDLNID);
                        e_list.Add(xx as C_F0931);
                    }
                }
            }
            if (deletedRows != null)
            {
                foreach (int rowIndex in deletedRows)
                {
                    lobj = GetTempData(null, null, rowIndex);

                    if (lobj != null)
                    {
                        C_F0931 xx = lobj as C_F0931;
                        e_list.RemoveAll(p => p.CDDOCO == xx.CDDOCO
                            & p.CDDCTO == xx.CDDCTO & p.CDDLNID == xx.CDDLNID);
                    }
                }
            }
            e_list.OrderByDescending(p => p.CDDLNID);
            ViewState["data"] = e_list;
        }

        protected void Grid1_RowClick(object sender, GridRowClickEventArgs e)
        {
            selected.Text = e.RowIndex.ToString();
        }

    }
}