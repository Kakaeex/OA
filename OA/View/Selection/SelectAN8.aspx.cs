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
    public partial class SelectAN8 : PagedBase, ISelectionPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Master.QueryString.ContainsKey("MODE"))
            {
                mode.Text = Master.QueryString["MODE"].ToString();
                if (ValueConvert.toInt(mode.Text) > 2)
                {
                    Grid1.EnableMultiSelect = true;
                }
            }
            else
            {
                mode.Text = "1";
            }
        }
        
        public void BindGrid()
        {
            var query = Master._DBHelper.GetQueryable<C_F0101>(p => 1 == 1);
            query = ABALPH.Text.Trim().Equals("") ? query : Master._DBHelper.GetQueryable<C_F0101>(p => p.ABALPH.Contains(ABALPH.Text));
            Master.bind<C_F0101, int>(query, p => p.ABAN8);
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