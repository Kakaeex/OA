using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using OAContext;
using DBContextHelper;
using FineUI;
using OA.Interface;
using Newtonsoft.Json;
using OA.Common;

namespace OA.View.Setting.P0010
{
    public partial class P0010E : PagedBase, IEditPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void BindGrid()
        {
            Master.bind<C_F0010, string>(null, p => p.CCCO);
        }

        public void Bind()
        {

        }

        public dynamic GetGridRowData(Dictionary<string, object> rowDict = null, object[] values = null, int deletedRows = 0)
        {
            C_F0010 obj = new C_F0010(1);
            if (rowDict != null)
            {
                #region 新增
                obj.CCCO = rowDict["CCCO"].ToString();
                obj.CCNAME = rowDict["CCNAME"].ToString();
                obj.CCDSC1 = rowDict["CCDSC1"].ToString();
                obj.CCDSC2 = rowDict["CCDSC2"].ToString();
                obj.CCCTRY = ValueConvert.toInt(rowDict["CCCTRY"]);
                obj.CCFY = ValueConvert.toInt(rowDict["CCFY"]);
                obj.CCCRCD = rowDict["CCCRCD"].ToString();
                obj.CCAN8 = ValueConvert.toInt(rowDict["CCAN8"]);
                obj.CCADDZ = rowDict["CCADDZ"].ToString();
                obj.CCCTY1 = rowDict["CCCTY1"].ToString();
                obj.CCCOUN = rowDict["CCCOUN"].ToString();
                obj.CCADDS = rowDict["CCADDS"].ToString();
                obj.CCSRP1 = rowDict["CCSRP1"].ToString();
                obj.CCSRP2 = rowDict["CCSRP2"].ToString();
                obj.CCSRP3 = rowDict["CCSRP3"].ToString();
                obj.CCSRP4 = rowDict["CCSRP4"].ToString();
                obj.CCSRP5 = rowDict["CCSRP5"].ToString();
                obj.CCSRP6 = rowDict["CCSRP6"].ToString();
                obj.CCSRP7 = rowDict["CCSRP7"].ToString();
                obj.CCSRP8 = rowDict["CCSRP8"].ToString();
                obj.CCSRP9 = rowDict["CCSRP9"].ToString();
                obj.CCSRP0 = rowDict["CCSRP0"].ToString();
                obj.CCPRP1 = ValueConvert.toInt(rowDict["CCPRP1"]);
                obj.CCPRP2 = ValueConvert.toInt(rowDict["CCPRP2"]);
                obj.CCPRP3 = ValueConvert.toInt(rowDict["CCPRP3"]);
                obj.CCPRP4 = ValueConvert.toInt(rowDict["CCPRP4"]);
                obj.CCPRP5 = ValueConvert.toInt(rowDict["CCPRP5"]);
                obj.CCPRP6 = ValueConvert.toInt(rowDict["CCPRP6"]);
                obj.CCPRP7 = ValueConvert.toInt(rowDict["CCPRP7"]);
                obj.CCPRP8 = ValueConvert.toInt(rowDict["CCPRP8"]);
                obj.CCPRP9 = ValueConvert.toInt(rowDict["CCPRP9"]);
                obj.CCPRP0 = ValueConvert.toInt(rowDict["CCPRP0"]);
                obj.CCUSER = Master.userID;
                obj.CCPID = Master.progammeID;
                obj.CCDATE = Master.now;
                obj.CCTIME = Master.time;
                return obj;
                #endregion
            }
            else if (values != null)
            {
                #region 修改
                obj.CCCO = values[0].ToString();
                obj.CCNAME = values[1].ToString();
                obj.CCDSC1 = values[2].ToString();
                obj.CCDSC2 = values[3].ToString();
                obj.CCCTRY = ValueConvert.toInt(values[4]);
                obj.CCFY = ValueConvert.toInt(values[5]);
                obj.CCCRCD = values[6].ToString();
                obj.CCAN8 = ValueConvert.toInt(values[7]);
                obj.CCADDZ = values[8].ToString();
                obj.CCCTY1 = values[9].ToString();
                obj.CCCOUN = values[10].ToString();
                obj.CCADDS = values[11].ToString();
                obj.CCSRP1 = values[12].ToString();
                obj.CCSRP2 = values[13].ToString();
                obj.CCSRP3 = values[14].ToString();
                obj.CCSRP4 = values[15].ToString();
                obj.CCSRP5 = values[16].ToString();
                obj.CCSRP6 = values[17].ToString();
                obj.CCSRP7 = values[18].ToString();
                obj.CCSRP8 = values[19].ToString();
                obj.CCSRP9 = values[20].ToString();
                obj.CCSRP0 = values[21].ToString();
                obj.CCPRP1 = ValueConvert.toInt(values[22]);
                obj.CCPRP2 = ValueConvert.toInt(values[23]);
                obj.CCPRP3 = ValueConvert.toInt(values[24]);
                obj.CCPRP4 = ValueConvert.toInt(values[25]);
                obj.CCPRP5 = ValueConvert.toInt(values[26]);
                obj.CCPRP6 = ValueConvert.toInt(values[27]);
                obj.CCPRP7 = ValueConvert.toInt(values[28]);
                obj.CCPRP8 = ValueConvert.toInt(values[29]);
                obj.CCPRP9 = ValueConvert.toInt(values[30]);
                obj.CCPRP0 = ValueConvert.toInt(values[31]);
                obj.CCUSER = Master.userID;
                obj.CCPID = Master.progammeID;
                obj.CCDATE = Master.now;
                obj.CCTIME = Master.time;
                return obj;
                #endregion
            }
            else if (deletedRows > 0)
            {
                #region 删除
                string SY = Grid1.DataKeys[deletedRows][0].ToString();
                obj = Master._DBHelper.Find<C_F0010>(p => p.CCCO == "");
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
            Master.SaveRecord<C_F0010>(Grid1.GetDeletedList(), Grid1.GetModifiedDict(), Grid1.GetNewAddedList(), GetGridRowData);
        }

        public string GetFromMode()
        {
            //return "Windows";
            return "Tab";
        }

        #region 
        protected void TriggerClick(object sender, EventArgs e)
        {
            TriggerBox tBox = sender as TriggerBox;
            string URL = Master._UDC.GetSelectionView(tBox.ID);
            PageContext.RegisterStartupScript(windows.GetSaveStateReference(tBox.ClientID) + windows.GetShowReference(URL));
            windows.Hidden = false;
        }

        public void DeleteRow()
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
        #endregion

        
    }
}