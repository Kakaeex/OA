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

namespace OA.View.Finance.P0930
{
    public partial class P0930H : PagedBase, IFindPage
    {
        #region Event
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
        protected void TriggerClick(object sender, EventArgs e)
        {
            TriggerBox tBox = sender as TriggerBox;
            string URL = Master._IUDC.GetSelectionView(tBox.ID);
            PageContext.RegisterStartupScript(windows.GetSaveStateReference(tBox.ClientID) + windows.GetShowReference(URL));
            windows.Hidden = false;
        }
        #endregion

        #region Methods
        public void BindGrid()
        {
            var query = Master._DBHelper.GetQueryable<C_F0930>(p => p.CHUSER == Master.userID);
            query = CHDSC1.Text == "" ? query : query.Where(p => p.CHDSC1.Contains(CHDSC1.Text));
            query = CHDCTO.Text == "" ? query : query.Where(p => p.CHDCTO == CHDCTO.Text);
            Master.bind<C_F0930, int>(query, p => p.CHDOCO);
        }

        public string GetNewUrl()
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("MODE", "add");
            return Master._UserAuthorization.GetApplication(Master.kcoo, "P0930E").Replace("~/", "")
                + Master._WebHelper.SetQueryString(dic) + ",新增报销单";
        }

        public string GetEditUrl()
        {
            object[] keys = Grid1.DataKeys[Grid1.SelectedRowIndex];

            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("DOCO", keys[0].ToString());
            dic.Add("DCTO", keys[1].ToString());
            dic.Add("MODE", "edit");
            return 
                Master._UserAuthorization.GetApplication(Master.kcoo, "P0930E").Replace("~/", "")
                + Master._WebHelper.SetQueryString(dic) + ",查看报销单";
        }

        public string GetFromMode()
        {
            //return "Windows";
            return "Tab";
        }

        public void DeleteSelectedRows()
        {
            Alert.ShowInTop("删除选中的 " + Grid1.SelectedRowIndexArray.Length + " 项纪录！");
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
                string[] _forms = { FORM1.ID };
                return _forms;
            }
        }
        #endregion
    }
}