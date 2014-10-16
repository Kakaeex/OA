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
    public partial class P9006E : PagedBase, IEditPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void BindGrid()
        {
            int an8 = ValueConvert.toInt(AN8);
            Master.bind<C_F9006, int>(p => p.RAAN8 == an8, p => p.RAAN8);
        }

        public void Bind()
        {

        }

        public dynamic GetGridRowData(Dictionary<string, object> rowDict = null, object[] values = null, int deletedRows = -1)
        {
            C_F9006 obj = new C_F9006(1);
            if (rowDict != null)
            {
               
                #region 新增
                
                obj.RAAN8 = ValueConvert.toInt(AN8);
                obj.RAID = rowDict["RAID"].ToString();
                C_F9001 del1 = Master._UserAuthorization.GetRole(obj.RAID);
                obj.RAKCOO = del1.RUKCOO;
                obj.RADEL1 = del1.RUDEL1; //rowDict["RADEL1"].ToString();
                obj.RADEL2 = rowDict["RADEL2"].ToString();
                obj.RASRP1 = rowDict["RASRP1"].ToString();
                obj.RASRP2 = rowDict["RASRP2"].ToString();
                obj.RASRP3 = rowDict["RASRP3"].ToString();
                obj.RASRP4 = rowDict["RASRP4"].ToString();
                obj.RASRP5 = rowDict["RASRP5"].ToString();
                obj.RAPRP1 = ValueConvert.toInt(rowDict["RAPRP1"]);
                obj.RAPRP2 = ValueConvert.toInt(rowDict["RAPRP2"]);
                obj.RAPRP3 = ValueConvert.toInt(rowDict["RAPRP3"]);
                obj.RAPRP4 = ValueConvert.toInt(rowDict["RAPRP4"]);
                obj.RAPRP5 = ValueConvert.toInt(rowDict["RAPRP5"]);
                obj.RAUSER = Master.userID;
                obj.RAPID = Master.progammeID;
                obj.RADATE = Master.now;
                obj.RATIME = Master.time;
                return obj;
                #endregion
            }
            else if (values != null)
            {
                #region 修改
                //obj.RAKCOO = Master.kcoo;
                obj.RAAN8 = ValueConvert.toInt(AN8);
                obj.RAKCOO = values[0].ToString();
                obj.RAID = values[1].ToString();
                C_F9001 del1 = Master._UserAuthorization.GetRole(obj.RAID);
                obj.RADEL1 = del1.RUDEL1;//obj.RADEL1 = values[1].ToString();
                obj.RADEL2 = values[3].ToString();
                obj.RASRP1 = values[4].ToString();
                obj.RASRP2 = values[5].ToString();
                obj.RASRP3 = values[6].ToString();
                obj.RASRP4 = values[7].ToString();
                obj.RASRP5 = values[8].ToString();
                obj.RAPRP1 = ValueConvert.toInt(values[9]);
                obj.RAPRP2 = ValueConvert.toInt(values[10]);
                obj.RAPRP3 = ValueConvert.toInt(values[11]);
                obj.RAPRP4 = ValueConvert.toInt(values[12]);
                obj.RAPRP5 = ValueConvert.toInt(values[13]);
                obj.RAUSER = Master.userID;
                obj.RAPID = Master.progammeID;
                obj.RADATE = Master.now;
                obj.RATIME = Master.time;
                return obj;
                #endregion
            }
            else if (deletedRows >= 0)
            {
                #region 删除
                string CO = Grid1.DataKeys[deletedRows][0].ToString();
                string SY = Grid1.DataKeys[deletedRows][1].ToString();
                int an8 = ValueConvert.toInt(AN8);
                obj = Master._DBHelper.Find<C_F9006>(p => p.RAKCOO == CO & p.RAAN8 == an8 & p.RAID == SY);
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
            Master.SaveRecord<C_F9006>(Grid1.GetDeletedList(), Grid1.GetModifiedDict(), Grid1.GetNewAddedList(), GetGridRowData);
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