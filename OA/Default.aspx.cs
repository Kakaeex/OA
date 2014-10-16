using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DBContextHelper;
using OA.Service;
using OA.Interface;
using System.Configuration;
using System.Web.Security;

namespace OA
{
    public partial class Default : System.Web.UI.Page
    {
        public IUserAuthorization _UserAuthorization { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Title = ConfigurationManager.AppSettings["SiteName"];
        }

        protected void leftMenuTree_Init(object sender, EventArgs e)
        {
            leftMenuTree.DataSource = _UserAuthorization.GetRoleMenu(role, kcoo);
            leftMenuTree.DataBind();
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            HttpContext.Current.Session.Abandon();
            HttpContext.Current.Request.Cookies.Clear();
            //string comfirmurl = "~/Account/Login.aspx";
            //FineUI.PageContext.Redirect(comfirmurl);
        }

        #region 值
        public DateTime now
        {
            get { return DateTime.Now; }
        }
        public TimeSpan time
        {
            get { return DateTime.Now.TimeOfDay; }
        }
        public string progammeID
        {
            get { return System.IO.Path.GetFileName(System.Web.HttpContext.Current.Request.PhysicalPath); }
        }
        public string userID
        {
            get { return base.Page.User.Identity.Name != null ? base.Page.User.Identity.Name : "???"; }
        }
        public string kcoo
        {
            get
            {
                return _UserAuthorization.GetUserKcoo(userID); 
            }
        }
        public string role
        {
            get
            {
                return _UserAuthorization.GetCurrentRole(base.Page.User.Identity.Name);
            }
        }
        #endregion
    }
}