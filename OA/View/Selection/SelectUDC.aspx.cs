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
    public partial class SelectUDC : PagedBase, ISelectionPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Master.QueryString.ContainsKey("SY") & Master.QueryString.ContainsKey("RT"))
            {
                DRSY.Text = Master.QueryString["SY"];
                DRRT.Text = Master.QueryString["RT"];
                mode.Text = "disable";
            }
            else
            {
                mode.Text = "enable";
            }
        }

        public void BindGrid()
        {
            if (mode.Text == "enable") { DRSY.Readonly = false; DRRT.Readonly = false; }
            var query = Master._DBHelper.GetQueryable<C_F0005>(p => 1 == 1);
            query = DRSY.Text.Trim().Equals("") ? query : query.Where(c => c.DRSY == DRSY.Text.Trim());
            query = DRRT.Text.Trim().Equals("") ? query : query.Where(c => c.DRRT == DRRT.Text.Trim());
            query = DRDEL1.Text.Trim().Equals("") ? query : query.Where(c => c.DRDEL1.Contains(DRDEL1.Text.Trim()));
            query = DRDEL2.Text.Trim().Equals("") ? query : query.Where(c => c.DRDEL2.Contains(DRDEL2.Text.Trim()));
            query = DRKY.Text.Trim().Equals("") ? query : query.Where(c => c.DRKY.Contains(DRKY.Text.Trim()));
            Master.bind<C_F0005, string>(query, p => p.DRKY);
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