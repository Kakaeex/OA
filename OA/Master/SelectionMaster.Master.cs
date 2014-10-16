using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using DBContextHelper;
using OA.Service;
using OA.Interface;
using FineUI;
using System.Linq.Expressions;

namespace OA.Master
{
    public partial class SelectionMaster : System.Web.UI.MasterPage
    {
        #region 值
        public DateTime now
        {
            get { return DateTime.Now; }
        }
        public TimeSpan time
        {
            get { return DateTime.Now.TimeOfDay; }
        }
        public string progammeID
        {
            get { return System.IO.Path.GetFileName(System.Web.HttpContext.Current.Request.PhysicalPath); }
        }
        public string userID
        {
            get { return base.Page.User.Identity.Name != null ? base.Page.User.Identity.Name : "???"; }
        }
        public string kcoo
        {
            get
            {
                return _UserAuthorization.GetUserKcoo(userID);
            }
        }
        public string role
        {
            get
            {
                return _UserAuthorization.GetCurrentRole(base.Page.User.Identity.Name);
            }
        }
        public Dictionary<string, string> QueryString
        {
            get
            {
                return _WebHelper.GetQueryString(Request.QueryString);
            }
        }

        private new ISelectionPage Page
        {
            get
            {
                return (ISelectionPage)base.Page;
            }
        }

        public OAContext.OAContext _DBHelper { get; set; }
        public IUserAuthorization _UserAuthorization { get; set; }
        public IWebHelper _WebHelper { get; set; }
        #endregion


        #region Page_Init

        protected void Page_Init(object sender, EventArgs e)
        {
            Page.Grid.PageIndexChange += grid_PageIndexChange;
            Page.Grid.Sort += grid_Sort;

            SetToolBar();
            SetGridPageItems();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                getInfor();
                //_UserAuthorization.ApplicationAuthorization(kcoo, role, progammeID, Page.Toolbar);
                Page.BindGrid();
            }
        }

        private void SetGridPageItems()
        {
            Page.Grid.PageItems.Add(new ToolbarSeparator());

            ToolbarText tbt = new ToolbarText();
            tbt.Text = "每页记录数：";
            Page.Grid.PageItems.Add(tbt);

            FineUI.DropDownList ddlGridPageSize = new FineUI.DropDownList();
            ddlGridPageSize.AutoPostBack = true;
            ddlGridPageSize.Items.Add(new FineUI.ListItem("20", "20"));
            ddlGridPageSize.Items.Add(new FineUI.ListItem("50", "50"));
            ddlGridPageSize.Items.Add(new FineUI.ListItem("100", "100"));
            ddlGridPageSize.Items.Add(new FineUI.ListItem("200", "200"));
            ddlGridPageSize.Width = 80;
            ddlGridPageSize.SelectedIndexChanged += ddlGridPageSize_SelectedIndexChanged;
            // 初始化选中值
            ddlGridPageSize.SelectedValue = Page.Grid.PageSize.ToString();
            Page.Grid.PageItems.Add(ddlGridPageSize);
        }

        private void SetToolBar()
        {
            Button toolBarSelect = new Button();
            toolBarSelect.ID = "toolBarSelect";
            toolBarSelect.Text = "选择";
            toolBarSelect.Icon = Icon.Accept;
            toolBarSelect.EnablePostBack = true;

            Button toolBarClose = new Button();
            toolBarClose.ID = "toolBarClose";
            toolBarClose.Text = "关闭";
            toolBarClose.Icon = Icon.Cross;
            toolBarClose.EnablePostBack = true;

            Button toolBarFind = new Button();
            toolBarFind.ID = "toolBarFind";
            toolBarFind.Text = "查找";
            toolBarFind.Icon = Icon.Magnifier;
            toolBarFind.EnablePostBack = true;

            toolBarSelect.Click += Select_Click;
            toolBarClose.OnClientClick += ActiveWindow.GetHideReference();
            toolBarFind.Click += Find_Click;

            Page.Toolbar.Items.Insert(0, toolBarSelect);
            Page.Toolbar.Items.Insert(0, toolBarClose);
            Page.Toolbar.Items.Insert(0, toolBarFind);

        }
        #endregion

        #region Events

        /// <summary>
        /// 表格每页显示项数改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ddlGridPageSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            Page.Grid.PageSize = System.Convert.ToInt32(((DropDownList)sender).SelectedValue);

            Page.BindGrid();
        }

        /// <summary>
        /// 点击选择按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Select_Click(object sender, EventArgs e)
        {
            //PageContext.RegisterStartupScript(
            //    ActiveWindow.GetWriteBackValueReference(Page.Grid.Rows[Page.Grid.SelectedRowIndex].Values[0].ToString()) + 
            //    ActiveWindow.GetHideReference());
            PageContext.RegisterStartupScript(
                ActiveWindow.GetWriteBackValueReference(Page.GetValues()) +
                ActiveWindow.GetHideReference());
        }

        /// <summary>
        /// 点击关闭按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Close_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 点击删除查找按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Find_Click(object sender, EventArgs e)
        {
            Page.BindGrid();
        }

        /// <summary>
        /// 弹出窗体关闭事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Window1_Close(object sender, EventArgs e)
        {
            Page.BindGrid();
        }

        /// <summary>
        /// 表格行双击（编辑本行）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void grid_RowDoubleClick(object sender, GridRowClickEventArgs e)
        {
            Select_Click(null, null);
        }

        /// <summary>
        /// 表格分页改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void grid_PageIndexChange(object sender, GridPageEventArgs e)
        {
            Page.Grid.PageIndex = e.NewPageIndex;

            Page.BindGrid();
        }

        /// <summary>
        /// 表格排序事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void grid_Sort(object sender, GridSortEventArgs e)
        {
            Page.Grid.SortDirection = e.SortDirection;
            Page.Grid.SortField = e.SortField;

            Page.BindGrid();
        }

        #endregion

        #region Methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mode">1：一个选中值，2：一行多列，3：一列多行合并返回，4：一列多行</param>
        /// <param name="cloumes"></param>
        /// <returns></returns>
        public string[] GetSelected(string mode, params int[] cloumes)
        {
            string[] _values = null;
            int i;
            switch (mode)
            {
                case "1": //x1
                    _values = new string[1];
                    _values[0] = Page.Grid.Rows[Page.Grid.SelectedRowIndex].Values[cloumes[0]].ToString();
                    break;
                case "2": //x1&x2
                    _values = new string[1];
                    foreach (int _i in cloumes)
                        _values[0] += Page.Grid.Rows[Page.Grid.SelectedRowIndex].Values[cloumes[_i]].ToString() + ";";
                    _values[0] = _values[0].ToString().TrimEnd(';');
                    break;
                case "3": //x1&y1
                    _values = new string[1];
                    foreach (int row in Page.Grid.SelectedRowIndexArray)
                    {
                        _values[0] += Page.Grid.Rows[row].Values[cloumes[0]].ToString() + ";";
                    }
                    _values[0] = _values[0].ToString().TrimEnd(';');
                    break;
                case "4": //x1,y1
                    _values = new string[Page.Grid.SelectedRowIndexArray.Count()];
                    i = 0;
                    foreach (int row in Page.Grid.SelectedRowIndexArray)
                    {
                        _values[i] = Page.Grid.Rows[row].Values[cloumes[0]].ToString();
                        i++;
                    }
                    break;
                default:
                    _values = new string[1];
                    _values[0] = Page.Grid.Rows[Page.Grid.SelectedRowIndex].Values[cloumes[0]].ToString();
                    break;
            }
            return _values;
        }

        protected void getInfor()
        {
            //now = DateTime.Now;
            //time = DateTime.Now.TimeOfDay;
            //progammeID = System.IO.Path.GetFileName(System.Web.HttpContext.Current.Request.PhysicalPath);
            //userID = base.Page.User.Identity.Name != null ? base.Page.User.Identity.Name : "???";
            //kcoo = "";//_UserAuthorization.GetUserKcoo(userID);
            //role = "";//System.Web.HttpContext.Current.Session["role"] as string;
        }

        public void bind<T, F>(Expression<Func<T, bool>> findConditions, Expression<Func<T, F>> orderBy) where T : ModelBase
        {
            PagedList<T> list = _DBHelper.FindAllByPage<T, F>(findConditions, orderBy, Page.Grid.PageSize, Page.Grid.PageIndex);
            Page.Grid.RecordCount = list.TotalItemCount;
            Page.Grid.DataSource = list;
            Page.Grid.DataBind();
        }

        public void bind<T, F>(IQueryable<T> findConditions, Expression<Func<T, F>> orderBy) where T : ModelBase
        {
            PagedList<T> list = _DBHelper.FindQueryByPage<T, F>(findConditions, orderBy, Page.Grid.PageSize, Page.Grid.PageIndex);
            Page.Grid.RecordCount = list.TotalItemCount;
            Page.Grid.DataSource = list;
            Page.Grid.DataBind();
        }

        #endregion
    }
}