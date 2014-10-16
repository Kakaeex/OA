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

namespace OA.View.Finance.P0902
{
    public partial class P0902H : PagedBase, IFindPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// [ISingleGridPage]重新绑定表格
        /// </summary>
        public void BindGrid()
        {
            //var query = Master._DBHelper.GetQueryable<C_F0902>(p => 1 == 1);
            //query = DSC1.Text == "" ? query : query.Where(p => p.WHDSC1.Contains(DSC1.Text));
            //query = WHDCT.Text == "" ? query : query.Where(p => p.WHDCT == WHDCT.Text);
            //Master.bind<C_F0902, int>(query, p => p.WHDOCO);
        }

        public string GetNewUrl()
        {
            return Master._UserAuthorization.GetApplication(Master.kcoo, "P2000E").Replace("~/", "");
        }

        /// <summary>
        /// [ISingleGridPage]获取编辑地址
        /// </summary>
        /// <returns></returns>
        public string GetEditUrl()
        {
            object[] keys = Grid1.DataKeys[Grid1.SelectedRowIndex];

            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("KCOO", keys[0].ToString());
            dic.Add("DOCO", keys[1].ToString());
            dic.Add("DCTO", keys[2].ToString());
            return String.Format
                (Master._UserAuthorization.GetApplication(Master.kcoo, "P2000E").Replace("~/", "") + Master._WebHelper.SetQueryString(dic));
        }

        public string GetFromMode()
        {
            //return "Windows";
            return "Tab";
        }
        protected void TriggerClick(object sender, EventArgs e)
        {
            TriggerBox tBox = sender as TriggerBox;
            string URL = Master._IUDC.GetSelectionView(tBox.ID);
            PageContext.RegisterStartupScript(windows.GetSaveStateReference(tBox.ClientID) + windows.GetShowReference(URL));
            windows.Hidden = false;
        }

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

        public string[] Forms
        {
            get
            {
                string[] _forms = { FORM1.ID };
                return _forms;
            }
        }
    }
}