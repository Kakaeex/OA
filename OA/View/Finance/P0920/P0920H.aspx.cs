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

namespace OA.View.Finance.P0920
{
    public partial class P0920H : PagedBase, IFindPage
    {
       
        #region Event

        protected void Page_Init(object sender, EventArgs e)
        {
            Button toolBarMember = new Button();
            toolBarMember.ID = "toolBarMember";
            toolBarMember.Text = "修订费用项目成员";
            toolBarMember.Icon = Icon.ApplicationAdd;
            toolBarMember.EnablePostBack = true;
            toolBarMember.Click += Member_Click;
            Toolbar.Items.Insert(0, toolBarMember);
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            //_Account.EDI_Z_ODS_F0902(1, "N", Master.userID, Master.progammeID);
        }
        protected void Member_Click(object sender, EventArgs e)
        {
            if (Grid1.SelectedRowIndexArray.Length == 0)
            {
                Alert.ShowInTop("请至少选择一条记录！");
                return;
            }
            object[] keys = Grid1.DataKeys[Grid1.SelectedRowIndex];

            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("DOCO", keys[0].ToString());
            string url = Master._UserAuthorization.GetApplication(Master.kcoo, "P9008EA").Replace("~/", "")
                + Master._WebHelper.SetQueryString(dic);

            PageContext.RegisterStartupScript(string.Format("AddActiveTab('{0}');", url));
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
            int an8 = ValueConvert.toInt(Master.userID);
            var query = Master._DBHelper.GetQueryable<V_F0920>(p => p.MCAN8 == an8);
            Master.bind<V_F0920, string>(query, p => p.FHMCU);
        }

        public string GetNewUrl()
        {
            return Master._UserAuthorization.GetApplication(Master.kcoo, "P0920E").Replace("~/", "") + ",新增费用项目"; 
        }

        /// <summary>
        /// [ISingleGridPage]获取编辑地址
        /// </summary>
        /// <returns></returns>
        public string GetEditUrl()
        {
            object[] keys = Grid1.DataKeys[Grid1.SelectedRowIndex];

            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("DOCO", keys[0].ToString());
            dic.Add("DCTO", keys[1].ToString());
            return Master._UserAuthorization.GetApplication(Master.kcoo, "P0920E").Replace("~/", "")
                + Master._WebHelper.SetQueryString(dic) + ",修改费用项目"; 
        }

        public string GetFromMode()
        {
            //return "Windows";
            return "Tab";
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
        #endregion

        #region Object
        public IAccount _Account { get; set; }
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