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

namespace OA.View.Account.Users
{
    public partial class UserInfor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
             
        }

        #region BindGrid

        public void BindGrid()
        {
            int an8 = Master._vm.toInt(ABAN8);
            PagedList<C_F9008> list = Master._DBHelper.FindAllByPage<C_F9008, string>(p => p.AUAN8 == an8, p => p.AUMCU, Grid1.PageSize, Grid1.PageIndex);
            Grid1.RecordCount = list.TotalItemCount;
            Grid1.DataSource = list;
            Grid1.DataBind();
        }

        public void Bind()
        {
            int an8 = Master._vm.toInt(ABAN8);
            V_F0101A obj = Master._DBHelper.Find<V_F0101A>(p => p.ABAN8 == an8);
            if (obj == null) return;
            ABALPH.Text = obj.ABALPH;
        }

        #endregion


        public void DeleteRow()
        {
            Alert.ShowInTop("删除选中的 " + Grid1.SelectedRowIndexArray.Length + " 项纪录！");
        }

        protected C_F9008 GetGridRowData(Dictionary<string, object> rowDict = null, string[] values = null)
        {
            if (rowDict != null)
            {
                C_F9008 obj = new C_F9008(1);
                obj.AUKCOO = Master.kcoo;
                obj.AUMCU = rowDict["AUMCU"];
                obj.AUAN8 = Master._vm.toInt(ABAN8);
                obj.AUDEL1 = rowDict["AUDEL1"];
                obj.AUDEL2 = rowDict["AUDEL2"];
                obj.AUSRP1 = rowDict["AUSRP1"];
                obj.AUUSER = Master.userID;
                obj.AUPID = Master.progammeID;
                obj.AUDATE = Master.now;
                obj.AUTIME = Master.time;

                return obj;
            }
            else if (values != null)
            {
                C_F9008 obj = new C_F9008(1);
                obj.AUKCOO = Master.kcoo;
                obj.AUMCU = values[1];
                obj.AUAN8 = Master._vm.toInt(ABAN8);
                obj.AUDEL1 = values[2];
                obj.AUDEL2 = values[3];
                obj.AUSRP1 = values[4];
                obj.AUUSER = Master.userID;
                obj.AUPID = Master.progammeID;
                obj.AUDATE = Master.now;
                obj.AUTIME = Master.time;

                return obj;
            }
            else
            {
                return new C_F9008(1);
            }
        }
        public void Save()
        {
            // 删除现有数据
            List<int> deletedRows = Grid1.GetDeletedList();
            foreach (int rowIndex in deletedRows)
            {
                int rowID = Master._vm.toInt(Grid1.DataKeys[rowIndex][0].ToString());
                var obj = Master._DBHelper.Find<C_F9008>(p => p.AUKCOO == Master.kcoo & p.APID == rowID);
                if (obj != null)
                {
                    Master._DBHelper.Delete<C_F9008>(obj);
                }
            }

            // 修改的现有数据
            Dictionary<int, Dictionary<string, object>> modifiedDict = Grid1.GetModifiedDict();
            foreach (int rowIndex in modifiedDict.Keys)
            {
                Master._DBHelper.Update<C_F9008>(GetGridRowData(null, Grid1.Rows[rowIndex].Values));
            }

            // 新增数据
            List<Dictionary<string, object>> newAddedList = Grid1.GetNewAddedList();
            for (int i = newAddedList.Count - 1; i >= 0; i--)
            {
                Master._DBHelper.Insert<C_F9008>(GetGridRowData(newAddedList[i]));
            }
        }

        public string GetFromMode()
        {
            return "Windows";
            //return "Tab";
        }

        #region 实例

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