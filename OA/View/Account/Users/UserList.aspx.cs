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
    public partial class UserList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        #region BindGrid

        /// <summary>
        /// [ISingleGridPage]重新绑定表格
        /// </summary>
        public void BindGrid()
        {
            PagedList<V_F0101A> list = Master._DBHelper.FindAllByPage<V_F0101A, int>(null, p => p.ABAN8, Grid1.PageSize, Grid1.PageIndex);
            Grid1.RecordCount = list.TotalItemCount;
            Grid1.DataSource = list;
            Grid1.DataBind();
        }

        #endregion


        /// <summary>
        /// [ISingleGridPage]删除表格数据
        /// </summary>
        public void DeleteSelectedRows()
        {
            Alert.ShowInTop("删除选中的 " + Grid1.SelectedRowIndexArray.Length + " 项纪录！");
        }

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
        public string GetNewUrl()
        {
            return Master._UserAuthorization.GetApplication(Master.kcoo, "");
        }

        /// <summary>
        /// [ISingleGridPage]获取编辑地址
        /// </summary>
        /// <returns></returns>
        public string GetEditUrl()
        {
            object[] keys = Grid1.DataKeys[Grid1.SelectedRowIndex];

            return String.Format(Master._UserAuthorization.GetApplication(Master.kcoo, ""), keys[0], HttpUtility.UrlEncode(keys[1].ToString()));
        }

        public string GetFromMode()
        {
            return "Windows";
            //return "Tab";
        }
    }
}