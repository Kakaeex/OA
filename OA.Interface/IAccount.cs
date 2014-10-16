using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OAContext;

namespace OA.Interface
{
   public interface IAccount
    {
       dynamic AccountLedgerAdd(C_F0911 _F0911);

       dynamic AccountMasterAdjust(C_F0902 C_F0902);

       dynamic EDI_Z_ODS_F0902(int doco, string status, string user, string pid);
    }
}
