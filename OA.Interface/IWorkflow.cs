using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OAContext;
using DBContextHelper;

namespace OA.Interface
{
    public interface IWorkflow
    {
        string CreateCostWorkflow(int doco);

        string ProccessCostWorkflow(int doco, string dcto, string an8, string argeement, string status, string user_id);
         
        int GetWorkflowOrderNumber(string kcoo, string dcto);
        int GetNextStep(int doco, int step);
        C_F2012 GetWorkflow(int doco, string dcto);
    }
}
