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

namespace OA.View.Finance.P0901
{
    public partial class P0903E : PagedBase, IEditPage
    {
        #region Event
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void TriggerClick(object sender, EventArgs e)
        {
            TriggerBox tBox = sender as TriggerBox;
            string URL = Master._UDC.GetSelectionView(tBox.ID);
            Dictionary<string, string> dic = new Dictionary<string, string>();
            switch (tBox.ID)
            {
                case "GDMAID":
                    dic.Add("MODE", "M");
                    URL += Master._WebHelper.SetQueryString(dic);
                    break;
                case "GDFAID":
                    dic.Add("MODE", "F");
                    URL += Master._WebHelper.SetQueryString(dic);
                    break;
            }
            PageContext.RegisterStartupScript(windows.GetSaveStateReference(tBox.ClientID) + windows.GetShowReference(URL));
            windows.Hidden = false;
        }
        public void AfterEdit(GridAfterEditEventArgs e)
        {

        }

        #endregion

        #region Methods
        public void BindGrid()
        {
            var query = Master._DBHelper.GetQueryable<C_F0903>(p => p.GDMAID == GDMAID.Text);
            Master.bind<C_F0903, string>(query, p => p.GDFAID);
        }
        public void Bind()
        {

        }
        public dynamic OnValidate<T>(string type, T obj) where T : ModelBase
        {
            return "Y";
        }
        public dynamic GetGridRowData(Dictionary<string, object> rowDict = null, object[] values = null, int deletedRows = -1)
        {
            var madi = Master._DBHelper.Find<C_F0901>(p => p.GMAID == GDMAID.Text);
            C_F0903 obj = new C_F0903(1);
            if (rowDict != null)
            {
                #region 新增
                obj.GDMAID = GDMAID.Text;
                obj.GDMMCU = madi.GMMCU;
                obj.GDMOBJ = madi.GMOBJ;
                obj.GDMSUB = madi.GMSUB;
                obj.GDMDL01 = madi.GMDL01;
                obj.GDMDL02 = madi.GMDL02;
                obj.GDFAID = rowDict["GDFAID"].ToString();
                var fadi = Master._DBHelper.Find<C_F0901>(p => p.GMAID == obj.GDFAID);
                obj.GDFMCU = fadi.GMMCU;
                obj.GDFOBJ = fadi.GMOBJ;
                obj.GDFSUB = fadi.GMSUB;
                obj.GDFDL01 = fadi.GMDL01;
                obj.GDFDL02 = fadi.GMDL02;
                obj.GDUSER = Master.userID;
                obj.GDPID = Master.progammeID;
                obj.GDDATE = Master.now;
                obj.GDTIME = Master.time;

                return obj;
                #endregion
            }
            else if (values != null)
            {
                #region 修改
                obj.GDMAID = GDMAID.Text;
                obj.GDMMCU = madi.GMMCU;
                obj.GDMOBJ = madi.GMOBJ;
                obj.GDMSUB = madi.GMSUB;
                obj.GDMDL01 = madi.GMDL01;
                obj.GDMDL02 = madi.GMDL02;
                obj.GDFAID = values[0].ToString();
                var fadi = Master._DBHelper.Find<C_F0901>(p => p.GMAID == obj.GDFAID);
                obj.GDFMCU = fadi.GMMCU;
                obj.GDFOBJ = fadi.GMOBJ;
                obj.GDFSUB = fadi.GMSUB;
                obj.GDFDL01 = fadi.GMDL01;
                obj.GDFDL02 = fadi.GMDL02;
                obj.GDUSER = Master.userID;
                obj.GDPID = Master.progammeID;
                obj.GDDATE = Master.now;
                obj.GDTIME = Master.time;

                return obj;
                #endregion
            }
            else if (deletedRows >= 0)
            {
                #region 删除
                string faid = Grid1.DataKeys[deletedRows][0].ToString();
                obj = Master._DBHelper.Find<C_F0903>(p => p.GDMAID == GDMAID.Text & p.GDFAID == faid);
                return obj;
                #endregion
            }
            else
            {
                return obj;
            }
        }
        public void Save()
        {
            Master.SaveRecord<C_F0903>(Grid1.GetDeletedList(), Grid1.GetModifiedDict(), Grid1.GetNewAddedList(), GetGridRowData);
        }

        public string GetFromMode()
        {
            //return "Windows";
            return "Tab";
        }
        public void DeleteRow()
        {

        }
        public void Print()
        {
            PageContext.RegisterStartupScript("Print();");
            //PageContext.RegisterStartupScript("window.open('http://www.baidu.com','_blank');");
        }
        #endregion

        #region Object
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
                string[] _forms = { this.Form1.ID };
                return _forms;
            }
        }
        #endregion
    }
}