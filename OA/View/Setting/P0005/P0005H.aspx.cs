using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using OA.Interface;
using FineUI;
using OAContext;
using DBContextHelper;

namespace OA.View.Setting.P0005
{
    public partial class P0005H : PagedBase, IFindPage
    {
        #region Event
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGrid();
            }
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
            PagedList<C_F0005> list = Master._DBHelper.FindAllByPage<C_F0005, string>
                (null, p => p.DRSY, Grid1.PageSize, Grid1.PageIndex);
            Grid1.RecordCount = list.TotalItemCount;
            Grid1.DataSource = list;
            Grid1.DataBind();
        }

        /// <summary>
        /// [ISingleGridPage]删除表格数据
        /// </summary>
        public void DeleteSelectedRows()
        {
            
        }
        /// <summary>
        /// [ISingleGridPage]获取新增地址
        /// </summary>
        /// <returns></returns>
        public string GetNewUrl()
        {
            return "~/grid/grid_iframe_window.aspx";
        }

        /// <summary>
        /// [ISingleGridPage]获取编辑地址
        /// </summary>
        /// <returns></returns>
        public string GetEditUrl()
        {
            object[] keys = Grid1.DataKeys[Grid1.SelectedRowIndex];
            return String.Format("~/grid/grid_iframe_window.aspx?id={0}&name={1}", keys[0], HttpUtility.UrlEncode(keys[1].ToString())) + ",用户修订"; ;
        }

        public string GetFromMode()
        {
            return "Windows";
            //return "Tab";
        }

        public void Print()
        {
            PageContext.RegisterStartupScript("Print();");
        }

        #endregion

        #region Object
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