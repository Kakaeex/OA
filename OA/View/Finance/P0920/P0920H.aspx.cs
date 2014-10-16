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
        public IAccount _Account { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            _Account.EDI_Z_ODS_F0902(1, "N", Master.userID, Master.progammeID);
        }
        public void BindGrid()
        {
            int an8 = ValueConvert.toInt(Master.userID);
            var query = Master._DBHelper.GetQueryable<V_F0920>(p => p.MCAN8 == an8);
            Master.bind<V_F0920, string>(query, p => p.FHMCU);
        }

        public string GetNewUrl()
        {
            return Master._UserAuthorization.GetApplication(Master.kcoo, "P0920E").Replace("~/", "");
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
                + Master._WebHelper.SetQueryString(dic);
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