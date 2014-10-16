using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using OAContext;
using DBContextHelper;
using FineUI;
using OA.Interface;
using Newtonsoft.Json;

namespace OA.View.Setting.P0035
{
    public partial class P0035E : PagedBase, IEditPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        #region BindGrid

        public void BindGrid()
        {
            var query = Master._DBHelper.GetQueryable<C_F0035>(p => 1 == 1);
            Master.bind<C_F0035, string>(query, p => p.MSCODE);
        }

        public void Bind()
        {

        }

        #endregion


        public void DeleteRow()
        {

        }

        public dynamic GetGridRowData(Dictionary<string, object> rowDict = null, object[] values = null, int deletedRows =0)
        {
            C_F0035 obj = new C_F0035(1);
            if (rowDict != null)
            {
                #region 新增
                obj.MSKCOO = rowDict["MSKCOO"].ToString();
                obj.MSDCTO = rowDict["MSDCTO"].ToString();
                obj.MSCODE = rowDict["MSCODE"].ToString();
                obj.MSLNGP = rowDict["MSLNGP"].ToString();
                obj.MSDSC1 = rowDict["MSDSC1"].ToString();
                obj.MSDSC2 = rowDict["MSDSC2"].ToString();
                obj.MSSRP1 = rowDict["MSSRP1"].ToString();
                obj.MSSRP2 = rowDict["MSSRP2"].ToString();
                obj.MSSRP3 = rowDict["MSSRP3"].ToString();
                obj.MSSRP4 = rowDict["MSSRP4"].ToString();
                obj.MSSRP5 = rowDict["MSSRP5"].ToString();
                obj.MSPRP1 = rowDict["MSPRP1"].ToString();
                obj.MSPRP2 = rowDict["MSPRP2"].ToString();
                obj.MSPRP3 = rowDict["MSPRP3"].ToString();
                obj.MSPRP4 = rowDict["MSPRP4"].ToString();
                obj.MSPRP5 = rowDict["MSPRP5"].ToString();
                obj.MSUSER = Master.userID;
                obj.MSPID = Master.progammeID;
                obj.MSDATE = Master.now;
                obj.MSTIME = Master.time;

                return obj;
                #endregion
            }
            else if (values != null)
            {
                #region 修改
                obj.MSKCOO = values[0].ToString();
                obj.MSDCTO = values[1].ToString();
                obj.MSCODE = values[2].ToString();
                obj.MSLNGP = values[3].ToString();
                obj.MSDSC1 = values[4].ToString();
                obj.MSDSC2 = values[5].ToString();
                obj.MSSRP1 = values[6].ToString();
                obj.MSSRP2 = values[7].ToString();
                obj.MSSRP3 = values[8].ToString();
                obj.MSSRP4 = values[9].ToString();
                obj.MSSRP5 = values[10].ToString();
                obj.MSPRP1 = values[11].ToString();
                obj.MSPRP2 = values[12].ToString();
                obj.MSPRP3 = values[13].ToString();
                obj.MSPRP4 = values[14].ToString();
                obj.MSPRP5 = values[15].ToString();
                obj.MSUSER = Master.userID;
                obj.MSPID = Master.progammeID;
                obj.MSDATE = Master.now;
                obj.MSTIME = Master.time;

                return obj;
                #endregion
            }
            else if (deletedRows >= 0)
            {
                #region 删除
                string SY = Grid1.DataKeys[deletedRows][0].ToString();
                obj = Master._DBHelper.Find<C_F0035>(p => p.MSKCOO == "" & p.MSDCTO == "" & p.MSLNGP == "" & p.MSCODE == "");
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
            Master.SaveRecord<C_F0035>(Grid1.GetDeletedList(), Grid1.GetModifiedDict(), Grid1.GetNewAddedList(), GetGridRowData);
        }

        public string GetFromMode()
        {
            //return "Windows";
            return "Tab";
        }

        #region 实例
        public void AfterEdit(GridAfterEditEventArgs e)
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

        protected void TriggerClick(object sender, EventArgs e)
        {
            TriggerBox tBox = sender as TriggerBox;
            string URL = Master._UDC.GetSelectionView(tBox.ID);
            PageContext.RegisterStartupScript(windows.GetSaveStateReference(tBox.ClientID) + windows.GetShowReference(URL));
            windows.Hidden = false;
        }
        public string[] Forms
        {
            get
            {
                string[] _forms =  { FORM1.ID };
                return _forms;
            }
        }
    }
}