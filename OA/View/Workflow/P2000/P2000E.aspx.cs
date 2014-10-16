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

namespace OA.View.Workflow.P2000
{
    public partial class P2000E : PagedBase, IEditPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Master.QueryString.ContainsKey("KCOO") & Master.QueryString.ContainsKey("DOCO") & Master.QueryString.ContainsKey("DCTO"))
            {
                WHDOCO.Text = Master.QueryString["DOCO"];
                WHDCTO.Text = Master.QueryString["DCTO"];
                mode.Text = "edit";
            }
            else
            {
                mode.Text = "add";
            }
        }

        public void BindGrid()
        {
            if (mode.Text == "add") return;
            int doco = ValueConvert.toInt(WHDOCO);
            if (doco <= 0) return;
            Master.bind<C_F2001, int>(p => p.WDDOCO == doco & p.WDDCTO == WHDCTO.Text & p.WDKCOO == Master.kcoo, p => p.WDLIND);
            if (mode.Text == "edit" & Grid1.RecordCount <= 0) Master._UserAuthorization.DisableToolbar(toolBar);
        }

        public void Bind()
        {
            int doco = ValueConvert.toInt(WHDOCO);
            if (doco <= 0) return;
            WHDSC1.Text = Master._DBHelper.Find<C_F2000>(p => p.WHDOCO == doco 
                & p.WHDCTO == WHDCTO.Text & p.WHKCOO == Master.kcoo).WHDSC1;
        }

        public dynamic GetGridRowData(Dictionary<string, object> rowDict = null, object[] values = null, int deletedRows = -1)
        {
            C_F2000 F2000 = ViewState["C_F2000"] as C_F2000;
            C_F2001 obj = new C_F2001(1);
            if (rowDict != null)
            {
                #region 新增
                obj.WDKCOO = F2000.WHKCOO;
                obj.WDDOCO = F2000.WHDOCO;
                obj.WDDCTO = F2000.WHDCTO;
                obj.WDLIND = ValueConvert.toInt(rowDict["WDLIND"]);
                obj.WDDSC1 = rowDict["WDDSC1"].ToString();
                obj.WDDSC2 = obj.WDDSC2;
                obj.WDDCT = rowDict["WDDCT"].ToString();
                obj.WDTRDJ = Master.now;
                obj.WDDRQJ = Master.now;
                obj.WDPDDJ = Master.now;
                obj.WDADDJ = Master.now;
                obj.WDCNDJ = Master.now;
                obj.WDUPRC = 0;
                obj.WDAEXP = 0;
                obj.WDUNCS = 0;
                obj.WDECST = 0;
                obj.WDSOQS = 0;
                obj.WDUORG = 0;
                obj.WDVR01 = Master._UDC.GetUDC("WDDCT", obj.WDDCT).DRDEL1; //rowDict["WDVR01"].ToString();
                obj.WDVR02 = obj.WDVR02;
                obj.WDSRP1 = rowDict["WDSRP1"].ToString();
                obj.WDSRP2 = rowDict["WDSRP2"].ToString();
                obj.WDSRP3 = obj.WDSRP3;
                obj.WDSRP4 = obj.WDSRP4;
                obj.WDSRP5 = obj.WDSRP5;
                obj.WDPRP1 = obj.WDPRP1;
                obj.WDPRP2 = obj.WDPRP2;
                obj.WDPRP3 = obj.WDPRP3;
                obj.WDPRP4 = obj.WDPRP4;
                obj.WDPRP5 = obj.WDPRP5;
                obj.WDUSER = Master.userID;
                obj.WDPID = Master.progammeID;
                obj.WDDATE = Master.now;
                obj.WDTIME = Master.time;
                return obj;
                #endregion
            }
            else if (values != null)
            {
                #region 修改
                int _lind = ValueConvert.toInt(values[0]);
                var _obj = Master._DBHelper.Find<C_F2001>(p => p.WDKCOO == F2000.WHKCOO
                    & p.WDDOCO == F2000.WHDOCO & p.WDDCTO == F2000.WHDCTO
                    & p.WDLIND == _lind);
                if (_obj == null) return obj;
                obj.WDKCOO = F2000.WHKCOO;
                obj.WDDOCO = F2000.WHDOCO;
                obj.WDDCTO = F2000.WHDCTO;
                obj.WDLIND = ValueConvert.toInt(values[0]);
                obj.WDDSC1 = values[1].ToString();
                obj.WDDSC2 = _obj.WDDSC2;
                obj.WDDCT = values[2].ToString();
                obj.WDTRDJ = _obj.WDTRDJ;
                obj.WDDRQJ = _obj.WDDRQJ;
                obj.WDPDDJ = _obj.WDPDDJ;
                obj.WDADDJ = _obj.WDADDJ;
                obj.WDCNDJ = _obj.WDCNDJ;
                obj.WDUPRC = _obj.WDUPRC;
                obj.WDAEXP = _obj.WDAEXP;
                obj.WDUNCS = _obj.WDUNCS;
                obj.WDECST = _obj.WDECST;
                obj.WDSOQS = _obj.WDSOQS;
                obj.WDUORG = _obj.WDUORG;
                obj.WDVR01 = Master._UDC.GetUDC("WDDCT", obj.WDDCT).DRDEL1; //values[3].ToString();
                obj.WDVR02 = _obj.WDVR02;
                obj.WDSRP1 = values[4].ToString();
                obj.WDSRP2 = values[5].ToString();
                obj.WDSRP3 = _obj.WDSRP3;
                obj.WDSRP4 = _obj.WDSRP4;
                obj.WDSRP5 = _obj.WDSRP5;
                obj.WDPRP1 = _obj.WDPRP1;
                obj.WDPRP2 = _obj.WDPRP2;
                obj.WDPRP3 = _obj.WDPRP3;
                obj.WDPRP4 = _obj.WDPRP4;
                obj.WDPRP5 = _obj.WDPRP5;
                obj.WDUSER = Master.userID;
                obj.WDPID = Master.progammeID;
                obj.WDDATE = Master.now;
                obj.WDTIME = Master.time;
                return obj;
                #endregion
            }
            else if (deletedRows >= 0)
            {
                #region 删除
                string CO = F2000.WHKCOO;
                int DOCO = F2000.WHDOCO;
                string DCTO = F2000.WHDCTO;
                int LIND = ValueConvert.toInt(Grid1.DataKeys[deletedRows][0]);
                obj = Master._DBHelper.Find<C_F2001>(p => p.WDKCOO == CO & p.WDDOCO == DOCO & p.WDDCTO == DCTO & p.WDLIND == LIND);
                return obj;
                #endregion
            }
            else
            {
                return obj;
            }
        }
        public void Save()
        {
            int doco = ValueConvert.toInt(WHDOCO);
            C_F2000 F2000 = Master._DBHelper.Find<C_F2000>
                (p => p.WHDOCO == doco & p.WHKCOO == Master.kcoo & p.WHDCTO == WHDCTO.Text);
            if (F2000 == null)
            {
                F2000 = new C_F2000(1);
                WHDOCO.Text = Master._Order.GetNextNumber("WF", Master.kcoo, "工作流").ToString();
                WHDCTO.Text = "WF";
            }
            F2000.WHKCOO = Master.kcoo;
            F2000.WHDOCO = ValueConvert.toInt(WHDOCO);
            F2000.WHDCTO = WHDCTO.Text;
            F2000.WHDSC1 = WHDSC1.Text;
            F2000.WHUSER = Master.userID;
            F2000.WHPID = Master.progammeID;
            F2000.WHDATE = Master.now;
            F2000.WHTIME = Master.time;
            if (Master._DBHelper.AddorUpdate<C_F2000>(F2000) > 0)
            {
                ViewState["C_F2000"] = F2000;
                Master.SaveRecord<C_F2001>(Grid1.GetDeletedList(), Grid1.GetModifiedDict(), Grid1.GetNewAddedList(), GetGridRowData);
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
                string[] _forms =  { FORM1.ID };
                return _forms;
            }
        }
        #endregion
    }
}