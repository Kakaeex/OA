using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Threading.Tasks;
using OA.Interface;
using OAContext;
using FineUI;
using DBContextHelper;
using System.Web;
using System.Web.Security;
using OA.Common;

namespace OA.Service
{
    public class UserAuthorization : IUserAuthorization
    {
        public OAContext.OAContext _DBHelper { get; set; }

        public UserAuthorization()
        { }

        public UserAuthorization(OAContext.OAContext DBHelper)
        {
            _DBHelper = DBHelper;
        }

        //public C_F0101 GetUserInfo(string UserID)
        //{
        //    int userID = 0;
        //    ValueManage.ToInt32(UserID, out userID);
        //    return CacheHelper.Get<C_F0101>("user_" + UserID, () =>
        //    {
        //        using (var dbContext = new DataManagementContext())
        //        {
        //            return dbContext.Find<C_F0101>(p => p.ABAN8 == userID);
        //        }
        //    });

        //    return new C_F0101();
        //}

        //public bool Login(string loginName, string password)
        //{
        //    if (Membership.ValidateUser(loginName, password))
        //    {
        //        GetUserInfo(loginName);
        //        FormsAuthentication.SetAuthCookie(loginName, false);
        //        Response.Redirect("~/");
        //        return true;
        //    }
        //    return false;
        //}

        //public void Logout(string UserID)
        //{
        //    CacheHelper.Remove("user_" + UserID);
        //    FormsAuthentication.SignOut();
        //    HttpContext.Current.Session.Abandon();
        //    HttpContext.Current.Request.Cookies.Clear();
        //    string comfirmurl = "~/Views/Account/Login.aspx";
        //    Response.Redirect(comfirmurl);
        //}

        //public string ChangePassword(string UserID, string CurrentPassword, string Password)
        //{
        //    MembershipUser user = Membership.GetUser(UserID);
        //    if (!Membership.ValidateUser(UserID, CurrentPassword))
        //    {
        //        return "用户名或密码错误!";
        //    }
        //    else if (!user.ChangePassword(CurrentPassword, Password))
        //    {
        //        return "新密码无效！";
        //    }
        //    else 
        //        return "更新成功！";
        //}

        //public List<C_F0101> GetUserList(string KCOO)
        //{
        //    using (var dbContext = new DataManagementContext())
        //    {
        //        return dbContext.FindAll<C_F0101, int>(p => p.ABKCOO == KCOO, p => p.ABAN8);
        //    }
        //}

        /// <summary>
        /// 新增用户
        /// </summary>
        /// <param name="User"></param>
        public void SaveUser(string AN8, string Password)
        {
            if (Membership.GetUser(AN8) != null)
            {

            }
            else
            {
                Membership.CreateUser(AN8, Password, "none@suibao.com");
                return;
            }
            if (Password != null)
            {
                MembershipUser user = Membership.GetUser(AN8);
                user.UnlockUser();
                user.ChangePassword(user.ResetPassword(), Password);
            }
        }

        //public void RemoveUserFromRole(string UserID, string Role)
        //{
        //    using (var dbContext = new DataManagementContext())
        //    {
        //        int userID = 0;
        //        ValueManage.ToInt32(UserID, out userID);
        //        Roles.RemoveUserFromRole(UserID, Role);
        //        CacheHelper.Remove("user_" + UserID);
        //        var role = dbContext.Find<C_F9006>(p => p.RAAN8 == userID & p.RAID == Role);
        //        if (role != null)
        //            dbContext.Delete<C_F9006>(role);
        //    }
        //}

        //public List<C_F9001> GetRoles(string UserID)
        //{
        //    int userID = 0;
        //    ValueManage.ToInt32(UserID, out userID);
        //    using (var dbContext = new DataManagementContext())
        //    {
        //        return (from e in dbContext.C_F9001
        //                join
        //                    p in dbContext.C_F9006 on e.RUID equals p.RAID
        //                where p.RAAN8 == userID
        //                select new C_F9001()
        //        ).ToList();
        //    }
        //}

        //public IEnumerable<C_F9001> GetRoleList(string KCOO)
        //{
        //    using (var dbContext = new DataManagementContext())
        //    {
        //        IQueryable<C_F9001> roles = dbContext.C_F9001;

        //        roles = roles.Where(u => u.RUKCOO == KCOO);

        //        return dbContext.FindAllByPage<C_F9001, string>(u => u.RUKCOO == KCOO, u => u.RUID);
        //    }
        //}

        //public void SaveRole(C_F9001 role)
        //{
        //    using (var dbContext = new DataManagementContext())
        //    {
        //        var obj = dbContext.Find<C_F9001>(p => p.RUID == role.RUID & p.RUKCOO == role.RUKCOO);
        //        if (obj != null)
        //        {
        //            obj.RUKCOO = role.RUKCOO;
        //            obj.RUID = role.RUID;
        //            obj.RUDEL1 = role.RUDEL1;
        //            obj.RUDEL2 = role.RUDEL2;
        //            obj.RUSRP1 = role.RUSRP1;
        //            obj.RUSRP2 = role.RUSRP2;
        //            obj.RUSRP3 = role.RUSRP3;
        //            obj.RUSRP4 = role.RUSRP4;
        //            obj.RUSRP5 = role.RUSRP5;
        //            obj.RUPRP1 = role.RUPRP1;
        //            obj.RUPRP2 = role.RUPRP2;
        //            obj.RUPRP3 = role.RUPRP3;
        //            obj.RUPRP4 = role.RUPRP4;
        //            obj.RUPRP5 = role.RUPRP5;
        //            obj.RUUSER = role.RUUSER;
        //            obj.RUPID = role.RUPID;
        //            obj.RUDATE = role.RUDATE;
        //            obj.RUTIME = role.RUTIME;
        //            dbContext.Update<C_F9001>(obj);
        //        }
        //        else
        //        {
        //            dbContext.Insert<C_F9001>(role);
        //        }
        //    }
        //}

        //public void DeleteRole(List<int> ids)
        //{
        //    using (var dbContext = new DataManagementContext())
        //    {

        //    }
        //}

        public XmlDocument GetRoleMenu(string RoleName, string KCOO)
        {
            var menulist = (from e in _DBHelper.C_F9002
                            from p in _DBHelper.C_F9005
                            where e.RPAPID == p.APID & e.RPKCOO == p.APKCOO & e.RPRUID == RoleName & e.RPKCOO == KCOO & p.APSRP3 == "Y" & e.RPSRP1=="Y"
                            select new
                            {
                                URL = p.APURL,
                                Name = p.APDEL1,
                                PID = e.RPPARENTID,
                                ID = e.RPAPID,
                                MenuID = e.RPMENUID,
                                MenuPID = e.RPPARENTID,
                                SRP1 = e.RPSRP1
                            }
                                     ).ToList();
            int boo = 1;
            XmlDocument xmlDoc = new XmlDocument();//new一个xml对象
            xmlDoc.AppendChild(xmlDoc.CreateXmlDeclaration("1.0", "gb2312", null));
            xmlDoc.AppendChild(xmlDoc.CreateElement("root"));//根节点
            XmlElement[] menu = new XmlElement[menulist.Count()];
            int ddd = menulist.Count();

            for (int i = 0; i < menulist.Count(); i++)
            {
                //创建一个xml元素并放到文档的根目录下
                menu[i] = xmlDoc.CreateElement("c" + menulist[i].ID.ToString()); //元素名: c+code
                menu[i].SetAttribute("NavigateUrl", menulist[i].URL);//URL
                menu[i].SetAttribute("Text", menulist[i].Name); //名称
                menu[i].SetAttribute("PID", menulist[i].PID.ToString()); //父ID
                menu[i].SetAttribute("ID", menulist[i].ID.ToString()); //ID
                menu[i].SetAttribute("SRP1", menulist[i].SRP1); //ID
                xmlDoc.DocumentElement.AppendChild(menu[i]);
            }


            //重新排列xml所有节点的位置
            for (int i = 0; i < menu.Length; i++)
            {
                boo = 1;
                if (menu[i].Attributes["PID"].Value != menu[i].Attributes["ID"].Value && boo == 1) //第一级目录
                {
                    //移动元素,复制一个到父节点下并删除当前元素
                    //根据当前元素判断父元素的元素名
                    string parentNodeName = "c" + menu[i].Attributes["PID"].Value;
                    string xpath = string.Format("//{0}[@ID={1}]", parentNodeName, menu[i].Attributes["PID"].Value);
                    try
                    {
                        xmlDoc.DocumentElement.SelectSingleNode(xpath).AppendChild(menu[i].Clone());
                        menu[i].ParentNode.RemoveChild(menu[i]);
                    }
                    catch
                    {
                        boo = 0;
                    }
                }
            }
            return xmlDoc;
        }

        public string GetApplication(string kcoo, string App)
        {
            List<C_F9005> obj = CacheHelper.Get<List<C_F9005>>(string.Format("SY_ApplicationList_{0}", kcoo), () =>
            {
                List<C_F9005> f9005 = _DBHelper.FindAll<C_F9005, int>(p => p.APKCOO == kcoo, p => p.APID);
                    return f9005;
            });

            return obj.Find(delegate(C_F9005 p) { return p.APSRP2 == App; }).APURL;
        }

        public string GetCurrentRole(string id)
        {
            return Roles.GetRolesForUser(id).FirstOrDefault();
        }

        public string GetUserKcoo(string UserID)
        {
            int userID = 0;
            userID = ValueConvert.toInt(UserID);
            C_F0101 obj = CacheHelper.Get<C_F0101>(string.Format("User_{0}_F0101", UserID), () =>
            {
                C_F0101 f0101 = _DBHelper.Find<C_F0101>(p => p.ABAN8 == userID);
                return f0101;
            });
            return obj.ABKCOO;
        }

        public void ApplicationAuthorization(string kcoo, string Role, string App, FineUI.Toolbar toolbar)
        {
                var f9005 = _DBHelper.Find<C_F9005>(p => p.APKCOO == kcoo & p.APSRP2 == App);
                if (f9005 != null)
                {
                    var f9002 = _DBHelper.Find<C_F9002>(p => p.RPKCOO == kcoo & p.RPRUID == Role & p.RPAPID == f9005.APID);
                    if (f9002 != null)
                    {
                        for (int i = 0; i < toolbar.Items.Count; i++)
                        {
                            if (toolbar.Items[i].ID == "toolBarNew") toolbar.Items[i].Hidden = f9002.RPBARNEW == 0;
                            if (toolbar.Items[i].ID == "toolSave" || toolbar.Items[i].ID == "toolSaveAndClose") toolbar.Items[i].Hidden = f9002.RPBARSAVE == 0;
                            if (toolbar.Items[i].ID == "toolBarSelect") toolbar.Items[i].Hidden = f9002.RPBARSELECT == 0;
                            if (toolbar.Items[i].ID == "toolBarDelete") toolbar.Items[i].Hidden = f9002.RPBARDELETE == 0;
                            if (toolbar.Items[i].ID == "toolBarClose") toolbar.Items[i].Hidden = f9002.RPBARCLOSE == 0;
                            if (toolbar.Items[i].ID == "toolBarFind") toolbar.Items[i].Hidden = f9002.RPBARFIND == 0;
                            if (toolbar.Items[i].ID == "toolBarSaveAs") toolbar.Items[i].Hidden = f9002.RPBARSAVEAS == 0;
                            if (toolbar.Items[i].ID == "toolBarKCOO") toolbar.Items[i].Hidden = Role != "Administrator";
                        }
                        return;
                    }
                    else if (f9005.APSRP1 == "S")
                    {
                        return;
                    }
                }
                FineUI.PageContext.Redirect(GetApplication(kcoo, "P9005E"));
        }

        public C_F9001 GetRole(string ruid)
        {
            C_F9001 C_F9001 = _DBHelper.Find<C_F9001>(p => p.RUID == ruid);
            return C_F9001;
        }

        public void DisableToolbar(FineUI.Toolbar toolbar)
        {
            for (int i = 0; i < toolbar.Items.Count; i++)
            {
                toolbar.Items[i].Visible = false;
            }
        }
    }
}
