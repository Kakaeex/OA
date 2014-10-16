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

namespace OA.View.BaseInfor.P0101
{
    public partial class P0101E : PagedBase, IEditPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        #region BindGrid

        public void BindGrid()
        {
            var query = Master._DBHelper.GetQueryable<C_F0101>(p => 1 == 1);
            Master.bind<C_F0101, string>(query, p => p.ABKCOO);
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
            C_F0101 obj = new C_F0101(1);
            if (rowDict != null)
            {
                #region 新增
                obj.ABKCOO = rowDict["ABKCOO"].ToString();
                obj.ABAN8 = ValueConvert.toInt(rowDict["ABAN8"]);
                obj.ABALKY = rowDict["ABALKY"].ToString();
                obj.ABTAX = rowDict["ABTAX"].ToString();
                obj.ABALPH = rowDict["ABALPH"].ToString();
                obj.ABDC = rowDict["ABDC"].ToString();
                obj.ABMCU = rowDict["ABMCU"].ToString();
                obj.ABLNGP = rowDict["ABLNGP"].ToString();
                obj.ABAT1 = rowDict["ABAT1"].ToString();
                obj.ABCLASS01 = rowDict["ABCLASS01"].ToString();
                obj.ABCLASS02 = rowDict["ABCLASS02"].ToString();
                obj.ABCLASS03 = rowDict["ABCLASS03"].ToString();
                obj.ABCLASS04 = rowDict["ABCLASS04"].ToString();
                obj.ABCLASS05 = rowDict["ABCLASS05"].ToString();
                obj.ABCLASS06 = rowDict["ABCLASS06"].ToString();
                obj.ABCLASS07 = rowDict["ABCLASS07"].ToString();
                obj.ABCLASS08 = rowDict["ABCLASS08"].ToString();
                obj.ABCLASS09 = rowDict["ABCLASS09"].ToString();
                obj.ABCLASS10 = rowDict["ABCLASS10"].ToString();
                obj.ABPRP1 = ValueConvert.toInt(rowDict["ABPRP1"]);
                obj.ABPRP2 = ValueConvert.toInt(rowDict["ABPRP2"]);
                obj.ABPRP3 = ValueConvert.toInt(rowDict["ABPRP3"]);
                obj.ABPRP4 = ValueConvert.toInt(rowDict["ABPRP4"]);
                obj.ABPRP5 = ValueConvert.toInt(rowDict["ABPRP5"]);
                obj.ABPRP6 = ValueConvert.toInt(rowDict["ABPRP6"]);
                obj.ABPRP7 = ValueConvert.toInt(rowDict["ABPRP7"]);
                obj.ABPRP8 = ValueConvert.toInt(rowDict["ABPRP8"]);
                obj.ABPRP9 = ValueConvert.toInt(rowDict["ABPRP9"]);
                obj.ABPRP0 = ValueConvert.toInt(rowDict["ABPRP0"]);
                obj.ABUSER = Master.userID;
                obj.ABPID = Master.progammeID;
                obj.ABDATE = Master.now;
                obj.ABTIME = Master.time;
                return obj;
                #endregion
            }
            else if (values != null)
            {
                #region 修改
                obj.ABKCOO = values[0].ToString();
                obj.ABAN8 = ValueConvert.toInt(values[1]);
                obj.ABALKY = values[2].ToString();
                obj.ABTAX = values[3].ToString();
                obj.ABALPH = values[4].ToString();
                obj.ABDC = values[5].ToString();
                obj.ABMCU = values[6].ToString();
                obj.ABLNGP = values[7].ToString();
                obj.ABAT1 = values[8].ToString();
                obj.ABCLASS01 = values[9].ToString();
                obj.ABCLASS02 = values[10].ToString();
                obj.ABCLASS03 = values[11].ToString();
                obj.ABCLASS04 = values[12].ToString();
                obj.ABCLASS05 = values[13].ToString();
                obj.ABCLASS06 = values[14].ToString();
                obj.ABCLASS07 = values[15].ToString();
                obj.ABCLASS08 = values[16].ToString();
                obj.ABCLASS09 = values[17].ToString();
                obj.ABCLASS10 = values[18].ToString();
                obj.ABPRP1 = ValueConvert.toInt(values[19]);
                obj.ABPRP2 = ValueConvert.toInt(values[20]);
                obj.ABPRP3 = ValueConvert.toInt(values[21]);
                obj.ABPRP4 = ValueConvert.toInt(values[22]);
                obj.ABPRP5 = ValueConvert.toInt(values[23]);
                obj.ABPRP6 = ValueConvert.toInt(values[24]);
                obj.ABPRP7 = ValueConvert.toInt(values[25]);
                obj.ABPRP8 = ValueConvert.toInt(values[26]);
                obj.ABPRP9 = ValueConvert.toInt(values[27]);
                obj.ABPRP0 = ValueConvert.toInt(values[28]);
                obj.ABUSER = Master.userID;
                obj.ABPID = Master.progammeID;
                obj.ABDATE = Master.now;
                obj.ABTIME = Master.time;
                return obj;
                #endregion
            }
            else if (deletedRows >= 0)
            {
                #region 删除
                string SY = Grid1.DataKeys[deletedRows][0].ToString();
                obj = Master._DBHelper.Find<C_F0101>(p => p.ABKCOO == "" & p.ABAT1 == "" & p.ABAN8 == 0);
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
            Master.SaveRecord<C_F0101>(Grid1.GetDeletedList(), Grid1.GetModifiedDict(), Grid1.GetNewAddedList(), GetGridRowData);
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