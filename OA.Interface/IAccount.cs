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

       dynamic AccountLimitedCheck(C_F0921 F0921, string mode);

       dynamic AccountMastertEditApply(C_F0921 F0921);

       dynamic CostProjectLimitedCheck(C_F0931 F0931, string mode);

       dynamic CostProjectEditApply(C_F0931 F0931);

       dynamic CostProjectEditActual(C_F0931 F0931);

       string ReleaseCostProjectApply(int cddoco, string cddcto, string mode);
    }
}
