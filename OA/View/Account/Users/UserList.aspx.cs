using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using OAContext;
using DBContextHelper;
using FineUI;
using OA.Interface;

namespace OA.View.Account.Users
{
    public partial class UserList : PagedBase, IFindPage
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
        /// <summary>
        /// [ISingleGridPage]重新绑定表格
        /// </summary>
        public void BindGrid()
        {
            var query = Master._DBHelper.GetQueryable<V_F0101A>(p => 1 == 1);
            Master.bind<V_F0101A, int>(query, p => p.ABAN8);
        }

        /// <summary>
        /// [ISingleGridPage]删除表格数据
        /// </summary>
        public void DeleteSelectedRows()
        {
            Alert.ShowInTop("删除选中的 " + Grid1.SelectedRowIndexArray.Length + " 项纪录！");
        }

        public void Print()
        {
            PageContext.RegisterStartupScript("Print();");
        }
        public string GetNewUrl()
        {
            return Master._UserAuthorization.GetApplication(Master.kcoo, "USERINFOR").Replace("~/", "") + ",用户修订";
        }

        /// <summary>
        /// [ISingleGridPage]获取编辑地址
        /// </summary>
        /// <returns></returns>
        public string GetEditUrl()
        {
            object[] keys = Grid1.DataKeys[Grid1.SelectedRowIndex];

            return String.Format
                (Master._UserAuthorization.GetApplication(Master.kcoo, "USERINFOR").Replace("~/", "") + "?AN8={0}", keys[0]) + ",用户修订";
        }

        public string GetFromMode()
        {
            //return "Windows";
            return "Tab";
        }
        #endregion

        #region Methods
        /// <summary>
        /// [ISingleGridPage]主表格实例
        /// </summary>
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

        /// <summary>
        /// [ISingleGridPage]获取新增地址
        /// </summary>
        /// <returns></returns>

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