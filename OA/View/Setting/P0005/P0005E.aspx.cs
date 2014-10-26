using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using OAContext;
using DBContextHelper;
using FineUI;
using OA.Interface;
using OA.Common;
using Newtonsoft.Json;

namespace OA.View.Setting.P0005
{
    public partial class P0005E : PagedBase, IEditPage
    {
        #region Event
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Master.QueryString.ContainsKey("SY") & Master.QueryString.ContainsKey("RT"))
            {
                DRSY.Text = Master.QueryString["SY"];
                DRRT.Text = Master.QueryString["RT"];
            }
            else
            {

            }
        }
        protected void TriggerClick(object sender, EventArgs e)
        {
            TriggerBox tBox = sender as TriggerBox;
            string URL = Master._UDC.GetSelectionView(tBox.ID);
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
            var query = Master._DBHelper.GetQueryable<C_F0005>(p => 1 == 1);
            query = DRSY.Text.Trim().Equals("") ? query : query.Where(c => c.DRSY == DRSY.Text.Trim());
            query = DRRT.Text.Trim().Equals("") ? query : query.Where(c => c.DRRT == DRRT.Text.Trim());
            query = DRDEL1.Text.Trim().Equals("") ? query : query.Where(c => c.DRDEL1.Contains(DRDEL1.Text.Trim()));
            Master.bind<C_F0005, string>(query, p => p.DRSY);
        }
        public void Bind()
        {

        }
        public void DeleteRow()
        {
            
        }
        public dynamic OnValidate<T>(string type, T obj) where T : ModelBase
        {
            return "Y";
        }
        public dynamic GetGridRowData(Dictionary<string, object> rowDict = null, object[] values = null, int deletedRows = -1)
        {
             C_F0005 obj = new C_F0005(1);
            if (rowDict != null)
            {
                #region 新增
                obj.DRKCOO = Master.kcoo;
                obj.DRLNGP = "CS";
                obj.DRSY = rowDict["DRSY"].ToString();
                obj.DRRT = rowDict["DRRT"].ToString();
                obj.DRKY = rowDict["DRKY"].ToString();
                obj.DRDEL1 = rowDict["DRDEL1"].ToString();
                obj.DRDEL2 = rowDict["DRDEL2"].ToString();
                obj.DRSRP1 = rowDict["DRSRP1"].ToString();
                obj.DRSRP2 = rowDict["DRSRP2"].ToString();
                obj.DRSRP3 = rowDict["DRSRP3"].ToString();
                obj.DRSRP4 = rowDict["DRSRP4"].ToString();
                obj.DRSRP5 = rowDict["DRSRP5"].ToString();
                obj.DRPRP1 =  ValueConvert.toInt(rowDict["DRPRP1"]);
                obj.DRPRP2 =  ValueConvert.toInt(rowDict["DRPRP2"]);
                obj.DRPRP3 =  ValueConvert.toInt(rowDict["DRPRP3"]);
                obj.DRPRP4 =  ValueConvert.toInt(rowDict["DRPRP4"]);
                obj.DRPRP5 =  ValueConvert.toInt(rowDict["DRPRP5"]);
                obj.DRUSER = Master.userID;
                obj.DRPID = Master.progammeID;
                obj.DRDATE = Master.now;
                obj.DRTIME = Master.time;

                return obj;
                 #endregion
            }
            else if (values != null)
            {
                #region 修改
                obj.DRKCOO = Master.kcoo;
                obj.DRLNGP = "CS";
                obj.DRSY = values[0].ToString();
                obj.DRRT = values[1].ToString();
                obj.DRKY = values[2].ToString();
                obj.DRDEL1 = values[3].ToString();
                obj.DRDEL2 = values[4].ToString();
                obj.DRSRP1 = values[5].ToString();
                obj.DRSRP2 = values[6].ToString();
                obj.DRSRP3 = values[7].ToString();
                obj.DRSRP4 = values[8].ToString();
                obj.DRSRP5 = values[9].ToString();
                obj.DRPRP1 = ValueConvert.toInt(values[10]);
                obj.DRPRP2 = ValueConvert.toInt(values[11]);
                obj.DRPRP3 = ValueConvert.toInt(values[12]);
                obj.DRPRP4 = ValueConvert.toInt(values[13]);
                obj.DRPRP5 = ValueConvert.toInt(values[14]);
                obj.DRUSER = Master.userID;
                obj.DRPID = Master.progammeID;
                obj.DRDATE = Master.now;
                obj.DRTIME = Master.time;
                return obj;
                 #endregion
            }
            else if (deletedRows >= 0)
            {
                #region 删除
                string SY = Grid1.DataKeys[deletedRows][0].ToString();
                obj = Master._DBHelper.Find<C_F0005>(p => p.DRKCOO == "" & p.DRSY == "" & p.DRKY == "" & p.DRRT == "" & p.DRLNGP == "");
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
            Master.SaveRecord<C_F0005>(Grid1.GetDeletedList(), Grid1.GetModifiedDict(), Grid1.GetNewAddedList(), GetGridRowData);
        }
        public string GetFromMode()
        {
            //return "Windows";
            return "Tab";
        }
        public void Print()
        {
            PageContext.RegisterStartupScript("Print();");
        }
        #endregion

        #region Object
     
        public Grid Grid
        {
            get
            {
                Grid1.PageSize = 100000;
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