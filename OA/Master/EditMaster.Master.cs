﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using DBContextHelper;
using OA.Service;
using OA.Interface;
using FineUI;
using Newtonsoft.Json;

namespace OA.Master
{
    public partial class EditMaster : System.Web.UI.MasterPage
    {
        public DateTime now;
        public TimeSpan time;
        public string progammeID;
        public string userID;
        public string kcoo;
        public string role;
        public IDataRepository _DBHelper { get; set; }
        public IUserAuthorization _UserAuthorization { get; set; }
        public IValueManage _vm { get; set; }

        #region Page

        /// <summary>
        /// 重写Page属性
        /// </summary>
        private new IEditPage Page
        {
            get
            {
                return (IEditPage)base.Page;
            }
        }

        #endregion

        #region Page_Init

        protected void Page_Init(object sender, EventArgs e)
        {
            Page.Grid.EnableRowDoubleClickEvent = true;
            Page.Grid.RowDoubleClick += grid_RowDoubleClick;

            Page.Grid.PageIndexChange += grid_PageIndexChange;
            Page.Grid.Sort += grid_Sort;

            SetToolBar();
            SetGridPageItems();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                now = DateTime.Now;
                time = DateTime.Now.TimeOfDay;
                progammeID = System.IO.Path.GetFileName(System.Web.HttpContext.Current.Request.PhysicalPath);
                userID = base.Page.User.Identity.Name != null ? base.Page.User.Identity.Name : "???";
                kcoo = _UserAuthorization.GetUserKcoo(userID);
                role = System.Web.HttpContext.Current.Session["role"] as string;
                _UserAuthorization.ApplicationAuthorization(kcoo, role, progammeID, Page.Toolbar);
                Page.Bind();
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

            Button toolSaveAndClose = new Button();
            toolSaveAndClose.ID = "toolSaveAndClose";
            toolSaveAndClose.Text = "保存并关闭";
            toolSaveAndClose.Icon = Icon.SystemSaveClose;
            toolSaveAndClose.EnablePostBack = true;

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
            toolBarDelete.Click += Delete_Click;
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
        #endregion

        #region Events

        /// <summary>
        /// 点击新增按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void New_Click(object sender, EventArgs e)
        {
            Newtonsoft.Json.Linq.JObject deserializeObject = (Newtonsoft.Json.Linq.JObject)JsonConvert.DeserializeObject(JsonConvert.SerializeObject(Page.GetGridRowData()));
            Page.Grid.AddNewRecord(deserializeObject);
        }

        /// <summary>
        /// 点击保存按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Save_Click(object sender, EventArgs e)
        {
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
            if (Page.Grid.SelectedRowIndexArray.Length == 0)
            {
                Alert.ShowInTop("请至少选择一条记录！");
                return;
            }

            Page.DeleteRow();
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


        #endregion
    }
}