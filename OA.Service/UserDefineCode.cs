using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OA.Interface;
using OAContext;
using FineUI;
using DBContextHelper;

namespace OA.Service
{
    public class UserDefineCode : IUserDefineCode
    {
        public IDataRepository _DBHelper { get; set; }

        public UserDefineCode()
        { }

        public UserDefineCode(IDataRepository DBHelper)
        {
            _DBHelper = DBHelper;
        }

        public List<C_F0005> GetUDCList(string sy, string rt)
        {
            return _DBHelper.FindAll<C_F0005, string>(p => p.DRSY == sy & p.DRRT == rt, p => p.DRSY);
        }

        public C_F0005 GetUDC(string sy, string rt, string ky)
        {
            return _DBHelper.Find<C_F0005>(p => p.DRSY == sy & p.DRRT == rt & p.DRKY == ky);
        }

        public string GetSelectionView(string ky, string sy = "", string rt = "")
        {
            return _DBHelper.Find<C_F0005>(p => p.DRSY == sy & p.DRRT == rt & p.DRKY == ky).DRDEL1;
        }
    }
}
