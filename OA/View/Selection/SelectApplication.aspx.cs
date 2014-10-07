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
    public partial class SelectApplication : PagedBase, ISelectionPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void BindGrid()
        {
            var query = Master._DBHelper.GetQueryable<C_F9005>(p => 1 == 1);
            query = APDEL1.Text.Trim().Equals("") ? query : query.Where(c => c.APDEL1.Contains(APDEL1.Text.Trim()));
            query = APURL.Text.Trim().Equals("") ? query : query.Where(c => c.APURL.Contains(APURL.Text.Trim()));
            query = APSRP1.Text.Trim().Equals("") ? query : query.Where(c => c.APSRP1.Contains(APSRP1.Text.Trim()));
            Master.bind<C_F9005, int>(query, p => p.APID);
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