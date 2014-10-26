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
    public partial class P2012E : PagedBase, IFindPage
    {
        #region Event
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CHDOCO.Text = Master.QueryString["DOCO"];
                CHDCTO.Text = Master.QueryString["DCTO"];

                int doco = ValueConvert.toInt(CHDOCO);
                //报销单
                var F0930 = Master._DBHelper.Find<C_F0930>(p => p.CHDOCO == doco & p.CHDCTO == CHDCTO.Text);
                //工作流程
                var e_f2012 = _Workflow.GetWorkflow(F0930.CHDOCO, F0930.CHDCTO);

                if (e_f2012 != null)
                    AllField(!e_f2012.WFVR01.Contains(Master.userID));

                if (F0930.CHNXTR == "100")
                {
                    var e_F2001 = Master._DBHelper.FindAll<C_F2001, int>
                        (p => p.WDDOCO == F0930.CHDOC, p => p.WDLIND).First();
                    agreement.Readonly = true;
                    status.Readonly = true;
                    //按步骤审核，不可自由选择审核人
                    if (e_F2001.WDDCT == "01")
                    {
                        AN8.Text = e_F2001.WDSRP1;
                        AN8.Readonly = true;
                    }
                }
                else if (ValueConvert.toInt(F0930.CHNXTR) >= 200)
                {
                    int e_nextstep = _Workflow.GetNextStep(F0930.CHDOC, e_f2012.WFPRP1);
                    if (e_f2012.WFSRP4 == "01")
                    {
                        AN8.Text = e_f2012.WFVR01;
                        AN8.Readonly = true;
                    }
                    if (e_nextstep == e_f2012.WFPRP1)
                    {
                        NEXT.Text = "结束";
                        AN8.Readonly = true;
                    }
                }
                else if (F0930.CHNXTR == "999" || F0930.CHNXTR == "980")
                {
                    AllField(true);
                }
            }
        }
        protected void TriggerClick(object sender, EventArgs e)
        {

            TriggerBox tBox = sender as TriggerBox;
            if (tBox.Readonly == true) return;
            string URL = Master._IUDC.GetSelectionView(tBox.ID);
            PageContext.RegisterStartupScript(windows.GetSaveStateReference(tBox.ClientID) + windows.GetShowReference(URL));
            windows.Hidden = false;
        }
        protected void NEXT_Click(object sender, EventArgs e)
        {
            Master.ClearMessage();
            Master.AddMessage(
                _Workflow.ProccessCostWorkflow(ValueConvert.toInt(CHDOCO), CHDCTO.Text,
                AN8.Text, agreement.Text, status.SelectedItem.Value, Master.userID));
            if (Master.messageList.Count() == 0)
            {
                PageContext.RegisterStartupScript("closeActiveTab();");
            }
            else
            {
                Alert.Show(Master.messageList[0]);
            }
        }
        #endregion

        #region Methods
        public void BindGrid()
        {
            int doco = ValueConvert.toInt(CHDOCO);
            if (doco <= 0) return;

            var F0930 = Master._DBHelper.Find<C_F0930>(p => p.CHDOCO == doco & p.CHDCTO == CHDCTO.Text);
            if (F0930 == null)
            {
                Master._UserAuthorization.DisableToolbar(toolBar);
                return;
            }
            CHMCU.Text = F0930.CHMCU;
            CHDSC2.Text = F0930.CHDSC2;
            CHDSC1.Text = F0930.CHDSC1;

            Master.bind<C_F0931, int>(p => p.CDDOCO == doco & p.CDDCTO == CHDCTO.Text, p => p.CDDLNID);
        }

        public string GetNewUrl()
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("MODE", "add");
            return Master._UserAuthorization.GetApplication(Master.kcoo, "P0930E").Replace("~/", "")
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
                Master._UserAuthorization.GetApplication(Master.kcoo, "P0930E").Replace("~/", "")
                + Master._WebHelper.SetQueryString(dic) + ",用户修订";
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

        void AllField(bool enable)
        {
            ResolveFormField(delegate(Field field)
            {
                field.Readonly = enable;
            });
        }

        private void ResolveFormField(ProcessFormField process)
        {
            foreach (FormRow row in Form1.Rows)
            {
                foreach (var field in row.Items)
                {
                    if ((field is Field) & (field != null) &
                        ((field is TextBox) || (field is TriggerBox)
                    || (field is DropDownList) || (field is DatePicker)))
                    {
                        process(field as Field);
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