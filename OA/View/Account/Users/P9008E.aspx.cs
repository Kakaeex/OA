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

namespace OA.View.Account.Users
{
    public partial class P9008E : PagedBase, IEditPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void BindGrid()
        {
            Master.bind<C_F9008, int>(null, p => p.AUAN8);
        }

        public void Bind()
        {

        }

        public dynamic GetGridRowData(Dictionary<string, object> rowDict = null, object[] values = null, int deletedRows = 0)
        {
            C_F9008 obj = new C_F9008(1);
            if (rowDict != null)
            {
                #region 新增
                obj.AUKCOO = rowDict["AUKCOO"].ToString();
                obj.AUMCU = rowDict["AUMCU"].ToString();
                obj.AUAN8 = ValueConvert.toInt(rowDict["AUAN8"]);
                obj.AUDEL1 = rowDict["AUDEL1"].ToString();
                obj.AUDEL2 = rowDict["AUDEL2"].ToString();
                obj.AUSRP1 = rowDict["AUSRP1"].ToString();
                obj.AUSRP2 = rowDict["AUSRP2"].ToString();
                obj.AUSRP3 = rowDict["AUSRP3"].ToString();
                obj.AUSRP4 = rowDict["AUSRP4"].ToString();
                obj.AUSRP5 = rowDict["AUSRP5"].ToString();
                obj.AUPRP1 = ValueConvert.toInt(rowDict["AUPRP1"]);
                obj.AUPRP2 = ValueConvert.toInt(rowDict["AUPRP2"]);
                obj.AUPRP3 = ValueConvert.toInt(rowDict["AUPRP3"]);
                obj.AUPRP4 = ValueConvert.toInt(rowDict["AUPRP4"]);
                obj.AUPRP5 = ValueConvert.toInt(rowDict["AUPRP5"]);
                obj.AUUSER = Master.userID;
                obj.AUPID = Master.progammeID;
                obj.AUDATE = Master.now;
                obj.AUTIME = Master.time;
                return obj;
                #endregion
            }
            else if (values != null)
            {
                #region 修改
                obj.AUKCOO = values[0].ToString();
                obj.AUMCU = values[1].ToString();
                obj.AUAN8 = ValueConvert.toInt(values[2]);
                obj.AUDEL1 = values[3].ToString();
                obj.AUDEL2 = values[4].ToString();
                obj.AUSRP1 = values[5].ToString();
                obj.AUSRP2 = values[6].ToString();
                obj.AUSRP3 = values[7].ToString();
                obj.AUSRP4 = values[8].ToString();
                obj.AUSRP5 = values[9].ToString();
                obj.AUPRP1 = ValueConvert.toInt(values[10]);
                obj.AUPRP2 = ValueConvert.toInt(values[11]);
                obj.AUPRP3 = ValueConvert.toInt(values[12]);
                obj.AUPRP4 = ValueConvert.toInt(values[13]);
                obj.AUPRP5 = ValueConvert.toInt(values[14]);
                obj.AUUSER = Master.userID;
                obj.AUPID = Master.progammeID;
                obj.AUDATE = Master.now;
                obj.AUTIME = Master.time;
                return obj;
                #endregion
            }
            else if (deletedRows > 0)
            {
                #region 删除
                string SY = Grid1.DataKeys[deletedRows][0].ToString();
                obj = Master._DBHelper.Find<C_F9008>(p => p.AUKCOO == "" & p.AUAN8 == 0 & p.AUMCU == "");
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
            Master.SaveRecord<C_F9008>(Grid1.GetDeletedList(), Grid1.GetModifiedDict(), Grid1.GetNewAddedList(), GetGridRowData);
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