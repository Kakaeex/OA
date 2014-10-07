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

        }
        
        public void BindGrid()
        {
            var query = Master._DBHelper.GetQueryable<C_F0101>(p => 1 == 1);
            query = ABALPH.Text.Trim().Equals("") ? null : Master._DBHelper.GetQueryable<C_F0101>(p => p.ABALPH.Contains(ABALPH.Text));
            Master.bind<C_F0101, int>(query, p => p.ABAN8);
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