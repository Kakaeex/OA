using DBContextHelper;
using FineUI;
using Newtonsoft.Json;
using OA.Interface;
using OA.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Web;
using System.Web.UI;

namespace OA.Master
{
    public partial class BlankMaster : System.Web.UI.MasterPage
    {
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
            get { return System.IO.Path.GetFileName(System.Web.HttpContext.Current.Request.PhysicalPath).ToUpper().Replace(".ASPX", ""); }
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
        public Dictionary<string, string> QueryString
        {
            get
            {
                Dictionary<string, string> _QueryString = new Dictionary<string, string>();
                foreach (string key in Request.QueryString.AllKeys)
                {
                    _QueryString.Add(key, Request.QueryString[key].ToString());
                }
                return _QueryString;
            }
        }
        public List<dynamic> messageList
        {
            get { return ViewState["messageList"] as List<dynamic>; }
            set { ViewState["messageList"] = value; }
        }
        
        //public IDataRepository _DBHelper { get; set; }
        public OAContext.OAContext _DBHelper { get; set; }
        public IUserAuthorization _UserAuthorization { get; set; }
        public IUserDefineCode _UDC { get; set; }
        public IOrder _Order { get; set; }
        public IWebHelper _WebHelper { get; set; }
        public IMessage _Message { get; set; }
        #endregion
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void AddMessage(string _message)
        {
            if (_message == "") return;
            messageList.Add(_message);
        }

        public void ClearMessage()
        {
            messageList = new List<dynamic>();
        }
    }
}