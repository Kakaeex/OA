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
    public partial class SelectMCU : PagedBase, ISelectionPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Master.QueryString.ContainsKey("AN8") & Master.QueryString.ContainsKey("MODE"))
            {
                mode.Text = Master.QueryString["MODE"];
            }
            else
            {
                mode.Text = "0";
            }
        }

        public void BindGrid()
        {
            if (mode.Text == "0")
            {
                var query = Master._DBHelper.GetQueryable<C_F0006>(p => 1 == 1);
                query = MCDC.Text.Trim().Equals("") ? query : Master._DBHelper.GetQueryable<C_F0006>(p => p.MCDC.Contains(MCDC.Text));
                query = !Master.QueryString.ContainsKey("STYL") ?
                    Master._DBHelper.GetQueryable<C_F0006>(p => p.MCSTYL == "BU") :
                    Master._DBHelper.GetQueryable<C_F0006>(p => p.MCSTYL == Master.QueryString["STYL"]);
                Master.bind<C_F0006, string>(query, p => p.MCKCOO);
            }
            else
            {
                int an8 = ValueConvert.toInt(Master.QueryString["AN8"]);
                string STYL = !Master.QueryString.ContainsKey("STYL") ? "BU" : Master.QueryString["STYL"];
                var query = Master._DBHelper.GetQueryable<V_F9008A>(p => p.AUAN8 == an8);
                query = MCDC.Text == "" ? query : Master._DBHelper.GetQueryable<V_F9008A>(p => p.MCDC.Contains(MCDC.Text));
                query = Master._DBHelper.GetQueryable<V_F9008A>(p => p.AUSRP1 == STYL);
                Master.bind<V_F9008A, string>(query, p => p.MCKCOO);
            }
        }
        public string[] GetValues()
        {
            if (mode.Text == "4")
            {
                string[] arry = Master.QueryString["COLUMN"].ToString().Split(',');
                int[] column = new int[arry.Count()];
                for (int i = 0; i < arry.Count(); i++)
                {
                    column[i] = ValueConvert.toInt(arry[i]);
                }
                return Master.GetSelected(mode.Text, column);
            }
            else
            {
                return Master.GetSelected(mode.Text, 0);
            }
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