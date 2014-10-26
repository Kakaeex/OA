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
    public partial class P9001E : PagedBase, IEditPage
    {
        #region Event
        protected void Page_Load(object sender, EventArgs e)
        {

        }
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

        #endregion

        #region Methods
        public void BindGrid()
        {
            var query = Master._DBHelper.GetQueryable<C_F9001>(p => 1 == 1);
            Master.bind<C_F9001, string>(query, p => p.RUID);
        }

        public void Bind()
        {

        }
        public dynamic OnValidate<T>(string type, T obj) where T : ModelBase
        {
            return "Y";
        }
        public dynamic GetGridRowData(Dictionary<string, object> rowDict = null, object[] values = null, int deletedRows = -1)
        {
            C_F9001 obj = new C_F9001(1);
            if (rowDict != null)
            {
                #region 新增
                obj.RUKCOO = rowDict["RUKCOO"].ToString();
                obj.RUID = rowDict["RUID"].ToString();
                obj.RUDEL1 = rowDict["RUDEL1"].ToString();
                obj.RUDEL2 = rowDict["RUDEL2"].ToString();
                obj.RUSRP1 = rowDict["RUSRP1"].ToString();
                obj.RUSRP2 = rowDict["RUSRP2"].ToString();
                obj.RUSRP3 = rowDict["RUSRP3"].ToString();
                obj.RUSRP4 = rowDict["RUSRP4"].ToString();
                obj.RUSRP5 = rowDict["RUSRP5"].ToString();
                obj.RUPRP1 = ValueConvert.toInt(rowDict["RUPRP1"]);
                obj.RUPRP2 = ValueConvert.toInt(rowDict["RUPRP2"]);
                obj.RUPRP3 = ValueConvert.toInt(rowDict["RUPRP3"]);
                obj.RUPRP4 = ValueConvert.toInt(rowDict["RUPRP4"]);
                obj.RUPRP5 = ValueConvert.toInt(rowDict["RUPRP5"]);
                obj.RUUSER = Master.userID;
                obj.RUPID = Master.progammeID;
                obj.RUDATE = Master.now;
                obj.RUTIME = Master.time;

                return obj;
                #endregion
            }
            else if (values != null)
            {
                #region 修改
                obj.RUKCOO = values[0].ToString();
                obj.RUID = values[1].ToString();
                obj.RUDEL1 = values[2].ToString();
                obj.RUDEL2 = values[3].ToString();
                obj.RUSRP1 = values[4].ToString();
                obj.RUSRP2 = values[5].ToString();
                obj.RUSRP3 = values[6].ToString();
                obj.RUSRP4 = values[7].ToString();
                obj.RUSRP5 = values[8].ToString();
                obj.RUPRP1 = ValueConvert.toInt(values[9]);
                obj.RUPRP2 = ValueConvert.toInt(values[10]);
                obj.RUPRP3 = ValueConvert.toInt(values[11]);
                obj.RUPRP4 = ValueConvert.toInt(values[12]);
                obj.RUPRP5 = ValueConvert.toInt(values[13]);
                obj.RUUSER = Master.userID;
                obj.RUPID = Master.progammeID;
                obj.RUDATE = Master.now;
                obj.RUTIME = Master.time;

                return obj;
                #endregion
            }
            else if (deletedRows >= 0)
            {
                #region 删除
                string SY = Grid1.DataKeys[deletedRows][0].ToString();
                obj = Master._DBHelper.Find<C_F9001>(p => p.RUKCOO == "" & p.RUID == "");
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
            Master.SaveRecord<C_F9001>(Grid1.GetDeletedList(), Grid1.GetModifiedDict(), Grid1.GetNewAddedList(), GetGridRowData);
        }

        public string GetFromMode()
        {
            //return "Windows";
            return "Tab";
        }
        public void DeleteRow()
        {

        }
        public void Print()
        {
            PageContext.RegisterStartupScript("Print();");
        }
        #endregion

        #region Object
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
                string[] _forms = { this.Form1.ID };
                return _forms;
            }
        }
        #endregion

    }
}