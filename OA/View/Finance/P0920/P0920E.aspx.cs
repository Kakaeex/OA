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

namespace OA.View.Finance.P0920
{
    public partial class P0920E : PagedBase, IEditPage
    {
        #region Event
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Master.QueryString.ContainsKey("DOCO") & Master.QueryString.ContainsKey("DCTO"))
            {
                mode.Text = "edit";
            }
            else
            {
                mode.Text = "add";
            }
            if (!IsPostBack)
            {
                lnid.Text = "1";
            }
        }
        protected void TriggerClick(object sender, EventArgs e)
        {
            TriggerBox tBox = sender as TriggerBox;
            if (tBox.Text != "") return;
            string URL = Master._UDC.GetSelectionView(tBox.ID);
            Dictionary<string, string> dic = new Dictionary<string, string>();
            switch (tBox.ID)
            {
                case "FDAID":
                    
                    dic.Add("MCU", FHMCU.Text);
                    dic.Add("KCOO", FHKCOO.Text);
                    dic.Add("YEAR", FHYEAR.Text);
                    dic.Add("MODE", "V_F0901A");
                    URL += Master._WebHelper.SetQueryString(dic);

                    break;
                case "FHMCU":
                    //URL = String.Format(URL, Master.userID, "4", "0,1");
                    dic.Add("STYL", "BU");
                    dic.Add("COLUMN", "0,1");
                    dic.Add("MODE", "4");
                    dic.Add("AN8", "Master.userID");
                    URL += Master._WebHelper.SetQueryString(dic);
                    PageContext.RegisterStartupScript(windows.GetSaveStateReference(tBox.ClientID, FHKCOO.ClientID) + windows.GetShowReference(URL));
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
            C_F0921 row = e.DataItem as C_F0921;
            
            if (ValueConvert.toInt(lnid) <= row.FDLNID)
                lnid.Text = (row.FDLNID + 1).ToString();
        }
        #endregion

        #region Methods
        public void BindGrid()
        {
            if (mode.Text == "add") return;
            int doco = ValueConvert.toInt(FHDOCO);
            if (doco <= 0) return;
            Master.bind<C_F0921, int>(p => p.FDDOCO == doco & p.FDDCTO == FHDCTO.Text, p => p.FDLNID);
            if (mode.Text == "edit" & Grid1.RecordCount <= 0) Master._UserAuthorization.DisableToolbar(toolBar);
        }
        public void Bind()
        {
            if (mode.Text == "edit")
            {
                FHDOCO.Text = Master.QueryString["DOCO"];
                FHDCTO.Text = Master.QueryString["DCTO"];

                int doco = ValueConvert.toInt(FHDOCO);
                var F0920 = Master._DBHelper.Find<C_F0920>(p => p.FHDOCO == doco & p.FHDCTO == FHDCTO.Text);
                if (F0920 == null) ;
                FHYEAR.Text = F0920.FHYAER.ToString();
                FHNAME.Text = F0920.FHNAME;
                FHEFTJ.Text = F0920.FHEFTJ.Date.ToString("yyyy-MM-dd");
                FHEDXJ.Text = F0920.FHEDXJ.Date.ToString("yyyy-MM-dd");
                FHDSC1.Text = F0920.FHDSC1;
                FHDSC2.Text = F0920.FHDSC2;
                FHSRP1.Text = F0920.FHSRP1;
                FHMCU.Text = F0920.FHMCU;
                FHKCOO.Text = F0920.FHKCOO;
            }
        }
        public dynamic OnValidate<T>(string type, T obj) where T : ModelBase
        {
            Master.AddMessage(_Account.AccountLimitedCheck(obj as C_F0921, type));
            return null;
        }
        public dynamic GetGridRowData(Dictionary<string, object> rowDict = null, object[] values = null, int deletedRows = -1)
        {
            C_F0920 F0920 = ViewState["C_F0920"] as C_F0920;

            C_F0921 obj = new C_F0921(1);
            if (rowDict != null)
            {
                #region 新增
                obj.FDDOCO = F0920.FHDOCO;
                obj.FDDCTO = F0920.FHDCTO;
                obj.FDLNID = ValueConvert.toInt(rowDict["FDLNID"]);
                obj.FDKCOO = F0920.FHKCOO;
                obj.FDAID = rowDict["FDAID"].ToString();
                obj.FDDSC1 = Master._DBHelper.Find<C_F0901>(p => p.GMAID == obj.FDAID).GMDL01;
                obj.FDDSC2 = obj.FDDSC2;
                obj.FDMCU = FHMCU.Text;
                obj.FDYAER = ValueConvert.toInt(FHYEAR);
                obj.FDEFTJ = ValueConvert.toDate(FHEFTJ);
                obj.FDEDXJ = ValueConvert.toDate(FHEDXJ);
                obj.FDNAME = FHNAME.Text;
                obj.FDUPRC = ValueConvert.toDecimal(rowDict["FDUPRC"]);//划入金额
                obj.FDAPYN = obj.FDAPYN;//占用金额
                obj.FDAWTD = obj.FDAWTD;//发生金额
                obj.FDLTTR = obj.FDLTTR;
                obj.FDNXTR = obj.FDNXTR;
                obj.FDUSER = Master.userID;
                obj.FDPID = Master.progammeID;
                obj.FDDATE = Master.now;
                obj.FDTIME = Master.time;

                return obj;
                #endregion
            }
            else if (values != null)
            {
                #region 修改
                int _lind = ValueConvert.toInt(values[0]);
                var _obj = Master._DBHelper.Find<C_F0921>(p => p.FDDOCO == F0920.FHDOCO &
                    p.FDDCTO == F0920.FHDCTO & p.FDLNID == _lind);
                if (_obj == null) return obj;
                obj.FDDOCO = F0920.FHDOCO;
                obj.FDDCTO = F0920.FHDCTO;
                obj.FDLNID = _lind;
                obj.FDKCOO = F0920.FHKCOO;
                obj.FDMCU = FHMCU.Text;
                obj.FDAID = values[1].ToString();
                obj.FDDSC1 = Master._DBHelper.Find<C_F0901>(p => p.GMAID == obj.FDAID).GMDL01;
                obj.FDDSC2 = _obj.FDDSC2;
                obj.FDYAER = ValueConvert.toInt(FHYEAR);
                obj.FDEFTJ = ValueConvert.toDate(FHEFTJ);
                obj.FDEDXJ = ValueConvert.toDate(FHEDXJ);
                obj.FDNAME = FHNAME.Text;
                obj.FDUPRC = ValueConvert.toDecimal(values[3]);//划入金额
                obj.FDAPYN = _obj.FDAPYN;//占用金额
                obj.FDAWTD = _obj.FDAWTD;//发生金额
                obj.FDLTTR = _obj.FDLTTR;
                obj.FDNXTR = _obj.FDNXTR;
                obj.FDUSER = Master.userID;
                obj.FDPID = Master.progammeID;
                obj.FDDATE = Master.now;
                obj.FDTIME = Master.time;
                return obj;
                #endregion
            }
            else if (deletedRows >= 0)
            {
                #region 删除
                int DOCO = F0920.FHDOCO;
                string DCTO = F0920.FHDCTO;
                int LIND = ValueConvert.toInt(Grid1.DataKeys[deletedRows][0]);
                obj = Master._DBHelper.Find<C_F0921>(p => p.FDDOCO == DOCO & p.FDDCTO == DCTO & p.FDLNID == LIND);
                return obj;
                #endregion
            }
            else
            {
                obj.FDLNID = ValueConvert.toInt(lnid);
                lnid.Text = (ValueConvert.toInt(lnid) + 1).ToString();
                return obj;
            }
        }
        public void Save()
        {
            Master.ClearMessage();
            int doco = ValueConvert.toInt(FHDOCO);
            C_F0920 F0920 = Master._DBHelper.Find<C_F0920>
                (p => p.FHDOCO == doco & p.FHDCTO == FHDCTO.Text);
            if (F0920 == null)
            {
                F0920 = new C_F0920(1);
                FHDOCO.Text = Master._Order.GetNextNumber("F1", Master.kcoo, "费用项目").ToString();
                FHDCTO.Text = "F1";
                F0920.FHTROG = Master.userID;
            }
            F0920.FHDOCO = ValueConvert.toInt(FHDOCO);
            F0920.FHDCTO = FHDCTO.Text;
            F0920.FHKCOO = FHKCOO.Text;
            F0920.FHMCU = FHMCU.Text;
            F0920.FHYAER = ValueConvert.toInt(FHYEAR);
            F0920.FHEFTJ = ValueConvert.toDate(FHEFTJ);
            F0920.FHEDXJ = ValueConvert.toDate(FHEDXJ);
            F0920.FHNAME = FHNAME.Text;
            F0920.FHDSC1 = FHDSC1.Text;
            F0920.FHDSC2 = FHDSC2.Text;
            F0920.FHSRP1 = FHSRP1.Text;
            F0920.FHLTTR = F0920.FHLTTR;
            F0920.FHNXTR = F0920.FHNXTR;
            F0920.FHUSER = Master.userID;
            F0920.FHPID = Master.progammeID;
            F0920.FHDATE = Master.now;
            F0920.FHTIME = Master.time;
            ViewState["C_F0920"] = F0920;

            Master.ValidateRecord<C_F0921>(Grid1.GetDeletedList(), Grid1.GetModifiedDict(), Grid1.GetNewAddedList(), GetGridRowData);
            if (Master.messageList.Count > 0)
            {
                Alert.Show(Master.messageList[0]);
                return;
            }
            if (Master._DBHelper.AddorUpdate<C_F0920>(F0920) > 0)
            {
                saveRecord<C_F0921>(Grid1.GetDeletedList(), Grid1.GetModifiedDict(), Grid1.GetNewAddedList(), GetGridRowData);
            }
            else
            {
                Master.AddMessage(Master._Message.GetMessage("WARM", "000").MSDSC1);
                Alert.Show(Master.messageList[0]);
                return;
            }
        }

        public dynamic saveRecord<T>(List<int> deletedRows, Dictionary<int, Dictionary<string, object>> modifiedDict,
           List<Dictionary<string, object>> newAddedList, Func<Dictionary<string, object>, object[], int, dynamic> GetGridRowData) where T : ModelBase
        {
            // newAdded,modified
            T lobj = default(T);
            // 修改的现有数据

            if (modifiedDict != null)
            {
                foreach (int rowIndex in modifiedDict.Keys)
                {
                    lobj = GetGridRowData(null, Grid1.Rows[rowIndex].Values, 0);

                    Master.AddMessage(_Account.AccountLimitedCheck(lobj as C_F0921, "modified"));
                    if (Master.messageList.Count() > 0)
                    {
                        Alert.Show(Master.messageList[0]);
                        return null;
                    }
                    else
                    {
                        Master._DBHelper.AddorUpdate<C_F0921>(lobj as C_F0921);
                        _Account.AccountMastertEditApply(lobj as C_F0921);
                    }
                }
            }
            if (newAddedList != null)
            {
                // 新增数据
                for (int i = newAddedList.Count - 1; i >= 0; i--)
                {
                    lobj = GetGridRowData(newAddedList[i], null, 0);
                    Master.AddMessage(_Account.AccountLimitedCheck(lobj as C_F0921, "newAdded"));
                    if (Master.messageList.Count() > 0)
                    {
                        Alert.Show(Master.messageList[0]);
                        return null;
                    }
                    else
                    {
                        Master._DBHelper.AddorUpdate<C_F0921>(lobj as C_F0921);
                        _Account.AccountMastertEditApply(lobj as C_F0921);
                    }
                }
            }


            return lobj;
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
            PageContext.RegisterStartupScript("Print();");
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

    }
}