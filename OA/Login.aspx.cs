using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.Security;
using System.Web.UI.WebControls;
using FineUI;

namespace OA
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //Roles.CreateRole("admin");
                //MembershipUser user = Membership.CreateUser("803811", "123", "Chen.dika@suibao.com");
                //Roles.AddUserToRole("803811", "admin");
                //MembershipUser user = Membership.GetUser("803811");
                //user.UnlockUser();
                //string p = user.ResetPassword();
                //user.ChangePassword(p, "123");
                FormsAuthentication.SignOut();
                HttpContext.Current.Session.Abandon();
                HttpContext.Current.Request.Cookies.Clear();
                PageContext.RegisterStartupScript("parent.__doPostBack('','exits');");
            }
        }

        protected void login_Click(object sender, EventArgs e)
        {
            //if (roles.SelectedValue == null) return;
            if (Membership.ValidateUser(UserID.Text, Pssd.Text))
            {
                FormsAuthentication.SetAuthCookie(UserID.Text, false);
                //Session["role"] = roles.SelectedValue;

                Response.Redirect("~/");
            }
        }
    }
}