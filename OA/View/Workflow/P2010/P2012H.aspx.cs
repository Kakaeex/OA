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
using System.Data;
namespace OA.View.Workflow.P2010
{
    public partial class P2012H : PagedBase, IFindPage
    {
        #region Event
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ResolveFormField(delegate(Field field)
                {
                    if ((field is DropDownList))
                    {
                        (field as DropDownList).DataSource=
                        Master._IUDC.GetUDCList(field.ID);
                        field.DataBind();
                    }
                });
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
        public void BindGrid()
        {
            var query = Master._DBHelper.GetQueryable<C_F2012>(p => p.WFVR01.Contains(Master.userID));
            query = WFSRP1.SelectedValue == "All" ? query : query.Where(p => p.WFSRP1 == WFSRP1.SelectedValue);
            Master.bind<C_F2012, int>(query, p => p.WFLNID);
        }

        public string GetNewUrl()
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("MODE", "add");
            return Master._UserAuthorization.GetApplication(Master.kcoo, "P2012E").Replace("~/", "")
                + Master._WebHelper.SetQueryString(dic) + ",用户修订";
        }
       
        public string GetEditUrl()
        {
            object[] keys = Grid1.DataKeys[Grid1.SelectedRowIndex];

            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("DOCO", keys[0].ToString());
            dic.Add("DCTO", keys[1].ToString());
            dic.Add("MODE", "edit");
            return
                Master._UserAuthorization.GetApplication(Master.kcoo, "P2012E").Replace("~/", "")
                + Master._WebHelper.SetQueryString(dic) + ",审批";
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

        private delegate void ProcessFormField(Field field);

        private void ResolveFormField(ProcessFormField process)
        {
            foreach (FormRow row in Form1.Rows)
            {
                foreach (Field field in row.Items)
                {
                    if (field != null)
                    {
                        process(field);
                    }
                }
            }
        }
        public void Print()
        {
            PageContext.RegisterStartupScript("Print();");
        }
        #endregion

        #region Object
        public IWorkflow _Workflow { get; set; }
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
                string[] _forms = { Form1.ID };
                return _forms;
            }
        }
        #endregion
    }
}