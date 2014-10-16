using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OA.Interface;
using OAContext;
using FineUI;
using DBContextHelper;
using OA.Common;

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
            List<C_F0005> obj = GetUDCCache();

            return obj.FindAll(p => p.DRSY == sy & p.DRRT == rt);
        }

        public C_F0005 GetUDC(string sy, string rt, string ky)
        {
            List<C_F0005> obj = GetUDCCache();

            return obj.Find(p => p.DRSY == sy & p.DRRT == rt & p.DRKY == ky);
        }

        public C_F0005 GetUDC(string dd, string ky)
        {
            List<C_F0005> obj = GetUDCCache();
            var F0005 = obj.Find(p => p.DRSY == "SY" & p.DRRT == "DD" & p.DRKY == dd);
            return GetUDC(F0005.DRSRP1, F0005.DRSRP2, ky);
        }

        public string GetSelectionView(string ky, string sy = "SY", string rt = "DD")
        {
            List<C_F0005> obj = GetUDCCache();
            return obj.Find(p => p.DRSY == sy & p.DRRT == rt & p.DRKY == ky).DRDEL2;
        }

        List<C_F0005> GetUDCCache()
        {
            return CacheHelper.Get<List<C_F0005>>("UDC", () =>
            {
                List<C_F0005> C_F0005 = _DBHelper.FindAll<C_F0005, string>(null, p => p.DRKY);
                return C_F0005;
            });
        }
    }
}
