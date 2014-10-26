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
    public partial class SelectAIDRelation : PagedBase, ISelectionPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            mode.Text = "1";
        }

        public void BindGrid()
        {
            if (Master.QueryString.ContainsKey("AID"))
            {
                var query = Master._DBHelper.GetQueryable<C_F0903>(p => 1 == 1);
                string AID = Master.QueryString["AID"];
                query = query.Where(p => p.GDMAID == AID);
                query = GMDL01.Text.Trim().Equals("") ? query : query.Where(p => p.GDFDL01.Contains(GMDL01.Text));
                Master.bind<C_F0903, string>(query, p => p.GDFAID);
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