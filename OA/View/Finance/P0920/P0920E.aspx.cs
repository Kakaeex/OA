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

namespace OA.View.Finance.P0920
{
    public partial class P0920E : PagedBase, IEditPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Master.QueryString.ContainsKey("DOCO") & Master.QueryString.ContainsKey("DCTO"))
            {
                FHDOCO.Text = Master.QueryString["DOCO"];
                FHDCTO.Text = Master.QueryString["DCTO"];
                mode.Text = "edit";
                int doco = ValueConvert.toInt(FHDOCO);
                var F0920 = Master._DBHelper.Find<C_F0920>(p => p.FHDOCO == doco & p.FHDCTO == FHDCTO.Text);
                if (F0920 == null) ;
                FHYEAR.Text = F0920.FHYAER.ToString();
                FHNAME.Text = F0920.FHNAME;
                FHEFTJ.Text = F0920.FHEFTJ.Value.Date.ToString("yyyy-MM-dd");
                FHEDXJ.Text = F0920.FHEDXJ.Value.Date.ToString("yyyy-MM-dd");
                FHDSC1.Text = F0920.FHDSC1;
                FHDSC2.Text = F0920.FHDSC2;
                FHSRP1.Text = F0920.FHSRP1;
                FHMCU.Text = F0920.FHMCU;
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
            int doco = ValueConvert.toInt(FHDOCO);
            if (doco <= 0) return;
            var obj = Master._DBHelper.Find<C_F0920>(p => p.FHDOCO == doco
                & p.FHDCTO == FHDCTO.Text);
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
                obj.FDAID = rowDict["FDAID"].ToString();
                obj.FDDSC1 = "";//Master._DBHelper.Find<C_F0901>(p => p.GMAID == obj.FDAID).GMDL01;
                obj.FDDSC2 = obj.FDDSC2;
                obj.FDMCU = FHMCU.Text;
                obj.FDYAER = ValueConvert.toInt(FHYEAR);
                obj.FDEFTJ = ValueConvert.toDate(FHEFTJ);
                obj.FDEDXJ = ValueConvert.toDate(FHEDXJ);
                obj.FDNAME = FHNAME.Text;
                obj.FDUPRC = ValueConvert.toDecimal(rowDict["FDUPRC"]);//划入金额
                obj.FDAPYN = ValueConvert.toDecimal(rowDict["FDAPYN"]);//占用金额
                obj.FDAWTD = ValueConvert.toDecimal(rowDict["FDAWTD"]);//发生金额
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
                obj.FDAID = values[1].ToString();
                obj.FDDSC1 = Master._DBHelper.Find<C_F0901>(p => p.GMAID == obj.FDAID).GMDL01;
                obj.FDDSC2 = obj.FDDSC2;
                obj.FDMCU = FHMCU.Text;
                obj.FDYAER = ValueConvert.toInt(FHYEAR);
                obj.FDEFTJ = ValueConvert.toDate(FHEFTJ);
                obj.FDEDXJ = ValueConvert.toDate(FHEDXJ);
                obj.FDNAME = FHNAME.Text;
                obj.FDUPRC = ValueConvert.toDecimal(values[3]);//划入金额
                obj.FDAPYN = ValueConvert.toDecimal(values[4]);//占用金额
                obj.FDAWTD = ValueConvert.toDecimal(values[5]);//发生金额
                obj.FDLTTR = obj.FDLTTR;
                obj.FDNXTR = obj.FDNXTR;
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
            if (mode.Text == "add") ;
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

            if (Master._DBHelper.AddorUpdate<C_F0920>(F0920) > 0)
            {
                ViewState["C_F0920"] = F0920;
                Master.SaveRecord<C_F0921>(Grid1.GetDeletedList(), Grid1.GetModifiedDict(), Grid1.GetNewAddedList(), GetGridRowData);
            }
            else
            {
                return;
            }
        }

        public string GetFromMode()
        {
            //return "Windows";
            return "Tab";
        }

        #region
        protected void TriggerClick(object sender, EventArgs e)
        {
            TriggerBox tBox = sender as TriggerBox;
            string URL = Master._UDC.GetSelectionView(tBox.ID);
            switch (tBox.ID)
            {
                case "FDAID": URL = String.Format(URL, FHMCU.Text); break;
                case "FHMCU": URL = String.Format(URL, Master.userID); break;
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
        public void DeleteRow()
        {

        }

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
                string[] _forms = {  this.Form1.ID };
                return _forms;
            }
        }
        #endregion
    }
}