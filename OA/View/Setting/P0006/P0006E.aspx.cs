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

namespace OA.View.Setting.P0006
{
    public partial class P0006E : PagedBase, IEditPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        #region BindGrid

        public void BindGrid()
        {
            var query = Master._DBHelper.GetQueryable<C_F0006>(p => 1 == 1);
            Master.bind<C_F0006, string>(query, p => p.MCMCU);
        }

        public void Bind()
        {

        }

        #endregion


        public void DeleteRow()
        {

        }

        public dynamic GetGridRowData(Dictionary<string, object> rowDict = null, object[] values = null, int deletedRows = -1)
        {
            C_F0006 obj = new C_F0006(1);
            if (rowDict != null)
            {
                #region 新增
                obj.MCKCOO = rowDict["MCKCOO"].ToString();
                obj.MCMCU = rowDict["MCMCU"].ToString();
                obj.MCSTYL = rowDict["MCSTYL"].ToString();
                obj.MCDC = rowDict["MCDC"].ToString();
                obj.MCLDM = ValueConvert.toInt(rowDict["MCLDM"]);
                obj.MCCO = rowDict["MCCO"].ToString();
                obj.MCPMCU = rowDict["MCPMCU"].ToString();
                obj.MCAN8 = ValueConvert.toInt(rowDict["MCAN8"]);
                obj.MCAN8O = ValueConvert.toInt(rowDict["MCAN8O"]);
                obj.MCCNTY = rowDict["MCCNTY"].ToString();
                obj.MCADDS = rowDict["MCADDS"].ToString();
                obj.MCDL01 = rowDict["MCDL01"].ToString();
                obj.MCDL02 = rowDict["MCDL02"].ToString();
                obj.MCDL03 = rowDict["MCDL03"].ToString();
                obj.MCDL04 = rowDict["MCDL04"].ToString();
                obj.MCSRP1 = rowDict["MCSRP1"].ToString();
                obj.MCSRP2 = rowDict["MCSRP2"].ToString();
                obj.MCSRP3 = rowDict["MCSRP3"].ToString();
                obj.MCSRP4 = rowDict["MCSRP4"].ToString();
                obj.MCSRP5 = rowDict["MCSRP5"].ToString();
                obj.MCPRP1 = ValueConvert.toInt(rowDict["MCPRP1"]);
                obj.MCPRP2 = ValueConvert.toInt(rowDict["MCPRP2"]);
                obj.MCPRP3 = ValueConvert.toInt(rowDict["MCPRP3"]);
                obj.MCPRP4 = ValueConvert.toInt(rowDict["MCPRP4"]);
                obj.MCPRP5 = ValueConvert.toInt(rowDict["MCPRP5"]);
                obj.MCUSER = Master.userID;
                obj.MCPID = Master.progammeID;
                obj.MCDATE = Master.now;
                obj.MCTIME = Master.time;
                return obj;
                #endregion
            }
            else if (values != null)
            {
                #region 修改
                obj.MCKCOO = values[0].ToString();
                obj.MCMCU = values[1].ToString();
                obj.MCSTYL = values[2].ToString();
                obj.MCDC = values[3].ToString();
                obj.MCLDM = ValueConvert.toInt(values[4]);
                obj.MCCO = values[5].ToString();
                obj.MCPMCU = values[6].ToString();
                obj.MCAN8 = ValueConvert.toInt(values[7]);
                obj.MCAN8O = ValueConvert.toInt(values[8]);
                obj.MCCNTY = values[9].ToString();
                obj.MCADDS = values[10].ToString();
                obj.MCDL01 = values[11].ToString();
                obj.MCDL02 = values[12].ToString();
                obj.MCDL03 = values[13].ToString();
                obj.MCDL04 = values[14].ToString();
                obj.MCSRP1 = values[15].ToString();
                obj.MCSRP2 = values[16].ToString();
                obj.MCSRP3 = values[17].ToString();
                obj.MCSRP4 = values[18].ToString();
                obj.MCSRP5 = values[19].ToString();
                obj.MCPRP1 = ValueConvert.toInt(values[20]);
                obj.MCPRP2 = ValueConvert.toInt(values[21]);
                obj.MCPRP3 = ValueConvert.toInt(values[22]);
                obj.MCPRP4 = ValueConvert.toInt(values[23]);
                obj.MCPRP5 = ValueConvert.toInt(values[24]);
                obj.MCUSER = Master.userID;
                obj.MCPID = Master.progammeID;
                obj.MCDATE = Master.now;
                obj.MCTIME = Master.time;
                return obj;
                #endregion
            }
            else if (deletedRows >= 0)
            {
                #region 删除
                string SY = Grid1.DataKeys[deletedRows][0].ToString();
                obj = Master._DBHelper.Find<C_F0006>(p => p.MCKCOO == "" & p.MCMCU == "");
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
            Master.SaveRecord<C_F0006>(Grid1.GetDeletedList(), Grid1.GetModifiedDict(), Grid1.GetNewAddedList(), GetGridRowData);
        }

        public string GetFromMode()
        {
            //return "Windows";
            return "Tab";
        }

        #region 实例
        public void AfterEdit(GridAfterEditEventArgs e)
        {

        }
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
                string[] _forms =  { FORM1.ID };
                return _forms;
            }
        }
        #endregion

        protected void TriggerClick(object sender, EventArgs e)
        {
            TriggerBox tBox = sender as TriggerBox;
            string URL = Master._UDC.GetSelectionView(tBox.ID);
            PageContext.RegisterStartupScript(windows.GetSaveStateReference(tBox.ClientID) + windows.GetShowReference(URL));
            windows.Hidden = false;
        }
    }
}