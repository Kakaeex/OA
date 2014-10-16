using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using FineUI;
using Newtonsoft.Json;
using OA.Interface;
using OA.Common;
using OAContext;
using DBContextHelper;


namespace OA.View.Account.Users
{
    public partial class UserInfor : PagedBase, IEditPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void BindGrid()
        {
            if (ABAN8.Text == "") return;
            int an8 = ValueConvert.toInt(ABAN8);
            Master.bind<C_F9008, string>(p => p.AUAN8 == an8, p => p.AUMCU);
        }

        public void Bind()
        {
            if (ABAN8.Text == "") return;
            int an8 = ValueConvert.toInt(ABAN8);
            V_F0101A obj = Master._DBHelper.Find<V_F0101A>(p => p.ABAN8 == an8);
            if (obj == null) return;
            ABALPH.Text = obj.ABALPH;
        }

        public dynamic GetGridRowData(Dictionary<string, object> rowDict = null, object[] values = null, int deletedRows = -1)
        {
            C_F9008 obj = new C_F9008(1);
            if (rowDict != null)
            {
                #region 新增
                obj.AUKCOO = Master.kcoo;
                obj.AUMCU = rowDict["AUMCU"].ToString();
                obj.AUAN8 = ValueConvert.toInt(ABAN8);
                obj.AUDEL1 = rowDict["AUDEL1"].ToString();
                obj.AUDEL2 = rowDict["AUDEL2"].ToString();
                obj.AUSRP1 = rowDict["AUSRP1"].ToString();
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
                obj.AUKCOO = Master.kcoo;
                obj.AUMCU = values[1].ToString();
                obj.AUAN8 = ValueConvert.toInt(ABAN8);
                obj.AUDEL1 = values[2].ToString();
                obj.AUDEL2 = values[3].ToString();
                obj.AUSRP1 = values[4].ToString();
                obj.AUUSER = Master.userID;
                obj.AUPID = Master.progammeID;
                obj.AUDATE = Master.now;
                obj.AUTIME = Master.time;
                return obj;
                #endregion
            }
            else if (deletedRows >0)
            {
                #region 删除
                string SY = Grid1.DataKeys[deletedRows][0].ToString();
                obj = Master._DBHelper.Find<C_F9008>(p => p.AUKCOO == "" & p.AUMCU == "" & p.AUAN8 == 0);
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
            string password = NewPassword1.Text == NewPassword2.Text ? NewPassword1.Text : null;
            Master._UserAuthorization.SaveUser(ABAN8.Text, password);
            Master.SaveRecord<C_F9008>(Grid1.GetDeletedList(), Grid1.GetModifiedDict(), Grid1.GetNewAddedList(), GetGridRowData);
        }

        public string GetFromMode()
        {
            return "Windows";
            //return "Tab";
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