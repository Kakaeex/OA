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

namespace OA.View.Account.P9005
{
    public partial class P9005E : PagedBase, IEditPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        public void BindGrid()
        {
            var query = Master._DBHelper.GetQueryable<C_F9005>(p => 1 == 1);
            Master.bind<C_F9005, int>(query, p => p.APID);
        }

        public void Bind()
        {

        }

        public dynamic GetGridRowData(Dictionary<string, object> rowDict = null, object[] values = null, int deletedRows = -1)
        {
            C_F9005 obj = new C_F9005(1);
            if (rowDict != null)
            {
                #region 新增
                obj.APKCOO = rowDict["APKCOO"].ToString();
                obj.APID = ValueConvert.toInt(rowDict["APID"]);
                obj.APDEL1 = rowDict["APDEL1"].ToString();
                obj.APDEL2 = rowDict["APDEL2"].ToString();
                obj.APURL = rowDict["APURL"].ToString();
                obj.APSRP1 = rowDict["APSRP1"].ToString();
                obj.APSRP2 = rowDict["APSRP2"].ToString();
                obj.APSRP3 = rowDict["APSRP3"].ToString();
                obj.APSRP4 = rowDict["APSRP4"].ToString();
                obj.APSRP5 = rowDict["APSRP5"].ToString();
                obj.APPRP1 = ValueConvert.toInt(rowDict["APPRP1"]);
                obj.APPRP2 = ValueConvert.toInt(rowDict["APPRP2"]);
                obj.APPRP3 = ValueConvert.toInt(rowDict["APPRP3"]);
                obj.APPRP4 = ValueConvert.toInt(rowDict["APPRP4"]);
                obj.APPRP5 = ValueConvert.toInt(rowDict["APPRP5"]);
                obj.APUSER = Master.userID;
                obj.APPID = Master.progammeID;
                obj.APDATE = Master.now;

                return obj;
                #endregion
            }
            else if (values != null)
            {
                #region 修改
                obj.APKCOO = values[0].ToString();
                obj.APID = ValueConvert.toInt(values[1]);
                obj.APDEL1 = values[2].ToString();
                obj.APDEL2 = values[3].ToString();
                obj.APURL = values[4].ToString();
                obj.APSRP1 = values[5].ToString();
                obj.APSRP2 = values[6].ToString();
                obj.APSRP3 = values[7].ToString();
                obj.APSRP4 = values[8].ToString();
                obj.APSRP5 = values[9].ToString();
                obj.APPRP1 = ValueConvert.toInt(values[10]);
                obj.APPRP2 = ValueConvert.toInt(values[11]);
                obj.APPRP3 = ValueConvert.toInt(values[12]);
                obj.APPRP4 = ValueConvert.toInt(values[13]);
                obj.APPRP5 = ValueConvert.toInt(values[14]);
                obj.APUSER = Master.userID;
                obj.APPID = Master.progammeID;
                obj.APDATE = Master.now;
                obj.APTIME = Master.time;


                return obj;
                #endregion
            }
            else if (deletedRows >= 0)
            {
                #region 删除
                string co = Grid1.DataKeys[deletedRows][0].ToString();
                int id = ValueConvert.toInt(Grid1.DataKeys[deletedRows][1]);
                obj = Master._DBHelper.Find<C_F9005>(p => p.APKCOO == co & p.APID == id);
                return obj;
                #endregion
            }
            else
            {
                obj.APID = Master._Order.GetNextNumber("AP", "00068", "Application");
                return obj;
            }
        }
        public void Save()
        {
            Master.SaveRecord<C_F9005>(Grid1.GetDeletedList(), Grid1.GetModifiedDict(), Grid1.GetNewAddedList(), GetGridRowData);
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
        public void AfterEdit(GridAfterEditEventArgs e)
        {

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
                string[] _forms =  { FORM1.ID };
                return _forms;
            }
        }
        #endregion
    }
}