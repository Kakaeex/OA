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
    public partial class SelectRoles : PagedBase, ISelectionPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void BindGrid()
        {
            var query = Master._DBHelper.GetQueryable<C_F9001>(p => 1 == 1);
            query = RUDEL1.Text.Trim().Equals("") ? query : query.Where(c => c.RUDEL1.Contains(RUDEL1.Text.Trim()));
            query = RUDEL2.Text.Trim().Equals("") ? query : query.Where(c => c.RUDEL1.Contains(RUDEL1.Text.Trim()));
            Master.bind<C_F9001, string>(query, p => p.RUID);
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