using DBContextHelper;
using FineUI;
using Newtonsoft.Json;
using OA.Interface;
using OA.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Web;
using System.Web.UI;

namespace OA.Master
{
    public partial class EditMaster : System.Web.UI.MasterPage
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
            get { return System.IO.Path.GetFileName(System.Web.HttpContext.Current.Request.PhysicalPath).ToUpper().Replace(".ASPX",""); }
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
                Dictionary<string, string> _QueryString = new Dictionary<string, string>();
                foreach (string key in Request.QueryString.AllKeys)
                {
                    _QueryString.Add(key, Request.QueryString[key].ToString());
                }
                return _QueryString;
            }
        }

        private new IEditPage Page
        {
            get
            {
                return (IEditPage)base.Page;
            }
        }
        #endregion

        //public IDataRepository _DBHelper { get; set; }
        public OAContext.OAContext _DBHelper { get; set; }
        public IUserAuthorization _UserAuthorization { get; set; }
        public IUserDefineCode _UDC { get; set; }
        public IOrder _Order { get; set; }
        public IWebHelper _WebHelper { get; set; }

        #region Page_Event

        protected void Page_Init(object sender, EventArgs e)
        {
            //Page.Grid.EnableRowDoubleClickEvent = true;
            //Page.Grid.RowDoubleClick += grid_RowDoubleClick;

            Page.Grid.PageIndexChange += grid_PageIndexChange;
            //Page.Grid.AfterEdit += grid_AfterEdit;
            Page.Grid.Sort += grid_Sort;
            SetToolBar();
            //SetGridPageItems();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                getInfor();
                _UserAuthorization.ApplicationAuthorization(kcoo, role, progammeID, Page.Toolbar);
                Page.Bind();
                Page.BindGrid();
            }
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            Page.Label.Text = ViewState["Message"] == null ? "" : ViewState["Message"] as string;
        }
        #endregion

        #region Events

        /// <summary>
        /// 点击新增按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void New_Click(object sender, EventArgs e)
        {
            //Newtonsoft.Json.Linq.JObject jObject = (Newtonsoft.Json.Linq.JObject)JsonConvert.DeserializeObject(JsonConvert.SerializeObject(Page.GetGridRowData()));
            Newtonsoft.Json.Linq.JObject jObject = Newtonsoft.Json.Linq.JObject.FromObject(Page.GetGridRowData());
            Page.Grid.AddNewRecord(jObject);
        }

        /// <summary>
        /// 点击保存按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Save_Click(object sender, EventArgs e)
        {
            getInfor();
            Page.Save();
        }

        /// <summary>
        /// 点击关闭按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void SaveAndClose_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 点击选择按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Select_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 点击删除按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Delete_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 点击关闭按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Close_Click(object sender, EventArgs e)
        {
            PageContext.RegisterStartupScript("closeActiveTab();");
        }

        /// <summary>
        /// 点击删除查找按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Find_Click(object sender, EventArgs e)
        {
            Page.Grid.GetResetReference();
            Page.Bind();
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

        protected void grid_AfterEdit(object sender, GridAfterEditEventArgs e)
        {
            Page.AfterEdit(e);
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
        #endregion

        #region Methods
        private void SetGridPageItems()
        {
            Page.Grid.PageItems.Add(new ToolbarSeparator());

            ToolbarText tbt = new ToolbarText();
            tbt.Text = "每页记录数：";
            Page.Grid.PageItems.Add(tbt);

            FineUI.DropDownList ddlGridPageSize = new FineUI.DropDownList();
            ddlGridPageSize.AutoPostBack = true;
            ddlGridPageSize.Items.Add(new FineUI.ListItem("5", "5"));
            ddlGridPageSize.Items.Add(new FineUI.ListItem("10", "10"));
            ddlGridPageSize.Items.Add(new FineUI.ListItem("15", "15"));
            ddlGridPageSize.Items.Add(new FineUI.ListItem("20", "20"));
            ddlGridPageSize.Width = 80;
            ddlGridPageSize.SelectedIndexChanged += ddlGridPageSize_SelectedIndexChanged;
            // 初始化选中值
            ddlGridPageSize.SelectedValue = Page.Grid.PageSize.ToString();
            Page.Grid.PageItems.Add(ddlGridPageSize);
        }
        private void SetToolBar()
        {
            Button toolBarNew = new Button();
            toolBarNew.ID = "toolBarNew";
            toolBarNew.Text = "新增";
            toolBarNew.Icon = Icon.Add;
            toolBarNew.EnablePostBack = true;

            Button toolSave = new Button();
            toolSave.ID = "toolSave";
            toolSave.Text = "保存";
            toolSave.Icon = Icon.SystemSave;
            toolSave.EnablePostBack = true;
            toolSave.ValidateForms = Page.Forms;

            Button toolSaveAndClose = new Button();
            toolSaveAndClose.ID = "toolSaveAndClose";
            toolSaveAndClose.Text = "保存并关闭";
            toolSaveAndClose.Icon = Icon.SystemSaveClose;
            toolSaveAndClose.EnablePostBack = true;
            toolSaveAndClose.ValidateForms = Page.Forms;

            Button toolBarSelect = new Button();
            toolBarSelect.ID = "toolBarSelect";
            toolBarSelect.Text = "选择";
            toolBarSelect.Icon = Icon.Accept;
            toolBarSelect.EnablePostBack = true;

            Button toolBarDelete = new Button();
            toolBarDelete.ID = "toolBarDelete";
            toolBarDelete.Text = "删除";
            toolBarDelete.Icon = Icon.Delete;
            toolBarDelete.EnablePostBack = true;

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

            toolBarNew.Click += New_Click;
            toolSave.Click += Save_Click;
            toolSaveAndClose.Click += SaveAndClose_Click;
            toolBarSelect.Click += Select_Click;
            toolBarDelete.OnClientClick += Page.Grid.GetNoSelectionAlertReference("请至少选择一项！") +
                Confirm.GetShowReference("删除选中行？", String.Empty, MessageBoxIcon.Question, Page.Grid.GetDeleteSelectedReference(), String.Empty);
            toolBarClose.Click += Close_Click;
            toolBarFind.Click += Find_Click;

            Page.Toolbar.Items.Insert(0, toolBarNew);
            Page.Toolbar.Items.Insert(0, toolSave);
            Page.Toolbar.Items.Insert(0, toolSaveAndClose);
            Page.Toolbar.Items.Insert(0, toolBarSelect);
            Page.Toolbar.Items.Insert(0, toolBarDelete);
            Page.Toolbar.Items.Insert(0, toolBarClose);
            Page.Toolbar.Items.Insert(0, toolBarFind);

        }
        protected void getInfor()
        {
            
        }
        public dynamic SaveRecord<T>(List<int> deletedRows, Dictionary<int, Dictionary<string, object>> modifiedDict,
            List<Dictionary<string, object>> newAddedList, Func<Dictionary<string, object>, object[], int, dynamic> GetGridRowData) where T : ModelBase
        {
            // 删除的现有数据
            List<T> lobj = new List<T>();
            foreach (int rowIndex in deletedRows)
            {
                lobj.Add(GetGridRowData(null, null, rowIndex));
            }
            if (lobj.Count > 0)
            {
                _DBHelper.DeleteList<T>(lobj);
            }

            // 修改的现有数据
            lobj = new List<T>();
            foreach (int rowIndex in modifiedDict.Keys)
            {
                lobj.Add(GetGridRowData(null, Page.Grid.Rows[rowIndex].Values, 0));
            }

            // 新增数据
            for (int i = newAddedList.Count - 1; i >= 0; i--)
            {
                lobj.Add(GetGridRowData(newAddedList[i], null, 0));
            }

            if (lobj.Count > 0)
            {
                _DBHelper.AddorUpdateList<T>(lobj);
            }

            return lobj;
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