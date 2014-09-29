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
    public class PagedBase : System.Web.UI.Page
    {
        public DateTime now;
        public TimeSpan time;
        public string progammeID;
        public string userID;
        public string kcoo;
        public string role;

        public PagedBase()
        {

        }

        //public PagedBase()
        //{
        //    now = DateTime.Now;
        //    time = DateTime.Now.TimeOfDay;
        //    progammeID = System.IO.Path.GetFileName(System.Web.HttpContext.Current.Request.PhysicalPath);
        //    //userID = Page.User.Identity.Name != null ? Page.User.Identity.Name : "???";
        //    kcoo = _UserAuthorization.GetUserKcoo(userID);
        //    //role = System.Web.HttpContext.Current.Session["role"] as string;
        //}
    }
}