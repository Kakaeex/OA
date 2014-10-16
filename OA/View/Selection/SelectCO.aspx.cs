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
    public partial class SelectCO : PagedBase, ISelectionPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void BindGrid()
        {
            var query = Master._DBHelper.GetQueryable<C_F0010>(p => 1 == 1);
            query = CCNAME.Text.Trim().Equals("") ? query : Master._DBHelper.GetQueryable<C_F0010>(p => p.CCNAME.Contains(CCNAME.Text));
            Master.bind<C_F0010, string>(query, p => p.CCCO);
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