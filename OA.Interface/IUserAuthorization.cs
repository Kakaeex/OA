using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using OAContext;
using System.Xml;

namespace OA.Interface
{
    public interface IUserAuthorization
    {
        //C_F0101 GetUserInfo(string UserID);

        //bool Login(string loginName, string password);

        //void Logout(string UserID);

        //string ChangePassword(string UserID, string CurrentPassword, string Password);

        //List<C_F0101> GetUserList(string KCOO);

        //bool SaveUser(C_F0101 f0101);

        //void RemoveUserFromRole(string UserID, string Role);

        //List<C_F9001> GetRoles(string UserID);

        //IEnumerable<C_F9001> GetRoleList(string KCOO);

        //void SaveRole(C_F9001 role);

        //void DeleteRole(List<int> ids);

        //XmlDocument GetRoleMenu(string RoleName, string KCOO);

        string GetApplication(string kcoo, string App);

        //string GetCurrentRole();

        string GetUserKcoo(string UserID);

        void ApplicationAuthorization(string kcoo, string Role, string App, FineUI.Toolbar toolbar);
    }
}
