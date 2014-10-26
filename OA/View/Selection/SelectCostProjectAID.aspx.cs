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
    public partial class SelectCostProjectAID : PagedBase, ISelectionPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            mode.Text = "1";
        }
        
        public void BindGrid()
        {
            if (Master.QueryString.ContainsKey("DOCO"))
            {
                var query = Master._DBHelper.GetQueryable<C_F0921>(p => 1 == 1);

                int DOCO = ValueConvert.toInt(Master.QueryString["DOCO"]);

                query = Master._DBHelper.GetQueryable<C_F0921>(p => p.FDDOCO == DOCO);

                Master.bind<C_F0921, int>(query, p => p.FDLNID);
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

        protected void Grid1_RowDataBound(object sender, GridRowEventArgs e)
        {
            if (Master.QueryString.ContainsKey("DOCO"))
            {
                C_F0921 row = e.DataItem as C_F0921;
                e.Values[4] = row.FDUPRC - row.FDAPYN - row.FDAWTD;
            }
        }
    }
}