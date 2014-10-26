using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using FineUI;
using Newtonsoft.Json;
using OA.Interface;
using OA.Common;
using OAContext;
using DBContextHelper;

namespace OA.View.Selection
{
    public partial class SelectAID : PagedBase, ISelectionPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            mode.Text = "1";
        }

        public void BindGrid()
        {
            if (Master.QueryString.ContainsKey("MODE") & Master.QueryString["MODE"] == "V_F0901B")
            {//获取会计科目
                if (Master.QueryString.ContainsKey("MCU"))
                {
                    var query = Master._DBHelper.GetQueryable<V_F0901B>(p => 1 == 1);
                    string mcu = Master.QueryString["MCU"];
                    query = query.Where(p => p.GMMCU == mcu);
                    query = GMDL01.Text.Trim().Equals("") ? query : query.Where(p => p.GMDL01.Contains(GMDL01.Text));
                    Master.bind<V_F0901B, string>(query, p => p.GBAID);
                }
            }
            else if (Master.QueryString.ContainsKey("MODE") & Master.QueryString["MODE"] == "V_F0901A")
            {//获取管理科目
                if (Master.QueryString.ContainsKey("MCU") & Master.QueryString.ContainsKey("KCOO") & Master.QueryString.ContainsKey("YEAR"))
                {
                    var query = Master._DBHelper.GetQueryable<V_F0901A>(p => 1 == 1);
                    string mcu = Master.QueryString["MCU"];
                    string kcoo = Master.QueryString["KCOO"];
                    int year = ValueConvert.toInt(Master.QueryString["YEAR"]);
                    query = query.Where(p => p.GBCO == kcoo & p.GBMCU == mcu & p.GBFY == year);
                    query = GMDL01.Text.Trim().Equals("") ? query : query.Where(p => p.GMDL01.Contains(GMDL01.Text));
                    Master.bind<V_F0901A, string>(query, p => p.GBAID);
                }
            }
            else if (Master.QueryString.ContainsKey("MODE") & Master.QueryString["MODE"] == "F")
            {
                var query = Master._DBHelper.GetQueryable<V_F0901B>(p => p.GMCO == "00068");
                Master.bind<V_F0901B, string>(query, p => p.GBAID);
            }
            else if (Master.QueryString.ContainsKey("MODE") & Master.QueryString["MODE"] == "M")
            {
                var query = Master._DBHelper.GetQueryable<V_F0901B>(p => p.GMCO == "99999");
                Master.bind<V_F0901B, string>(query, p => p.GBAID);
            }
        }

        public string[] GetValues()
        {
            return Master.GetSelected(mode.Text, 0);
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
    }
}