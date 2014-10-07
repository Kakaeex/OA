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

namespace OA.View.Account.P9001
{
    public partial class P9002E : PagedBase, IEditPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void BindGrid()
        {
            var query = Master._DBHelper.GetQueryable<C_F9002>(p => 1 == 1);
            int id = ValueConvert.toInt(RPPARENTID.Text);
            Master.bind<C_F9002, int>(p => p.RPRUID == RPRUID.Text & p.RPPARENTID == id, p => p.RPMENUID);
        }

        public void Bind()
        {

        }

        public dynamic GetGridRowData(Dictionary<string, object> rowDict = null, object[] values = null, int deletedRows = 0)
        {
            C_F9002 obj = new C_F9002(1);
            if (rowDict != null)
            {
                #region 新增
                obj.RPKCOO = "";
                obj.RPRUID = RPRUID.Text;
                obj.RPMENUID = ValueConvert.toInt(rowDict["RPMENUID"]);
                obj.RPPARENTID = ValueConvert.toInt(RPPARENTID.Text);
                obj.RPAPID = ValueConvert.toInt(rowDict["RPAPID"]);
                obj.RPBARNEW = ValueConvert.toInt(rowDict["RPBARNEW"]);
                obj.RPBARSAVE = ValueConvert.toInt(rowDict["RPBARSAVE"]);
                obj.RPBARSELECT = ValueConvert.toInt(rowDict["RPBARSELECT"]);
                obj.RPBARDELETE = ValueConvert.toInt(rowDict["RPBARDELETE"]);
                obj.RPBARCLOSE = ValueConvert.toInt(rowDict["RPBARCLOSE"]);
                obj.RPBARFIND = ValueConvert.toInt(rowDict["RPBARFIND"]);
                obj.RPBARSAVEAS = ValueConvert.toInt(rowDict["RPBARSAVEAS"]);
                obj.RPSRP1 = rowDict["RPSRP1"].ToString();
                obj.RPSRP2 = rowDict["RPSRP2"].ToString();
                obj.RPSRP3 = rowDict["RPSRP3"].ToString();
                obj.RPSRP4 = rowDict["RPSRP4"].ToString();
                obj.RPSRP5 = Master._DBHelper.Find<C_F9005>(p => p.APID == obj.RPAPID).APDEL1;//rowDict["RPSRP5"].ToString();
                obj.RPPRP1 = ValueConvert.toInt(rowDict["RPPRP1"]);
                obj.RPPRP2 = ValueConvert.toInt(rowDict["RPPRP2"]);
                obj.RPPRP3 = ValueConvert.toInt(rowDict["RPPRP3"]);
                obj.RPPRP4 = ValueConvert.toInt(rowDict["RPPRP4"]);
                obj.RPPRP5 = ValueConvert.toInt(rowDict["RPPRP5"]);
                obj.RPUSER = Master.userID;
                obj.RPPID = Master.progammeID;
                obj.RPDATE = Master.now;
                obj.RPTIME = Master.time;
                return obj;
                #endregion
            }
            else if (values != null)
            {
                #region 修改
                obj.RPKCOO = "";
                obj.RPRUID = RPRUID.Text;
                obj.RPMENUID = ValueConvert.toInt(values[0]);
                obj.RPPARENTID = ValueConvert.toInt(RPPARENTID.Text);
                obj.RPAPID = ValueConvert.toInt(values[1]);
                obj.RPBARNEW = ValueConvert.toInt(values[2]);
                obj.RPBARSAVE = ValueConvert.toInt(values[3]);
                obj.RPBARSELECT = ValueConvert.toInt(values[4]);
                obj.RPBARDELETE = ValueConvert.toInt(values[5]);
                obj.RPBARCLOSE = ValueConvert.toInt(values[6]);
                obj.RPBARFIND = ValueConvert.toInt(values[7]);
                obj.RPBARSAVEAS = ValueConvert.toInt(values[8]);
                obj.RPSRP1 = values[9].ToString();
                obj.RPSRP2 = values[10].ToString();
                obj.RPSRP3 = values[11].ToString();
                obj.RPSRP4 = values[12].ToString();
                obj.RPSRP5 = values[13].ToString();
                obj.RPPRP1 = ValueConvert.toInt(values[14]);
                obj.RPPRP2 = ValueConvert.toInt(values[15]);
                obj.RPPRP3 = ValueConvert.toInt(values[16]);
                obj.RPPRP4 = ValueConvert.toInt(values[17]);
                obj.RPPRP5 = ValueConvert.toInt(values[18]);
                obj.RPUSER = Master.userID;
                obj.RPPID = Master.progammeID;
                obj.RPDATE = Master.now;
                obj.RPTIME = Master.time;
                return obj;
                #endregion
            }
            else if (deletedRows > 0)
            {
                #region 删除
                string key1 = Grid1.DataKeys[deletedRows][0].ToString();
                obj = Master._DBHelper.Find<C_F9002>(p => p.RPMENUID == ValueConvert.toInt(key1));
                return obj;
                #endregion
            }
            else
            {
                obj.RPMENUID = Master._Order.GetNextNumber("Mu", "00068", "Menu");
                return obj;
            }
        }
        public void Save()
        {
            Master.SaveRecord<C_F9002>(Grid1.GetDeletedList(), Grid1.GetModifiedDict(), Grid1.GetNewAddedList(), GetGridRowData);
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
            TriggerBox tBox = sender as TriggerBox;
            string URL = Master._UDC.GetSelectionView(tBox.ID);
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
        #endregion
    }
}