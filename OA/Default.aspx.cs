using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DBContextHelper;
using OA.Service;
using OA.Interface;

namespace OA
{
    public partial class Default : System.Web.UI.Page
    {
        public IDataRepository DBContextHelper { get; set; }

        public IUserAuthorization UserAuthorization { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            var dd = DBContextHelper.Find<OAContext.C_F0005>(p => p.DRKCOO == "");
            UserAuthorization.GetUserKcoo("");
        }
    }
}