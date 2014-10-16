using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OAContext;
using DBContextHelper;

namespace OA.Interface
{
   public  interface IWorkflow
    {
       dynamic AddOrUpdateWorkflow<T>(T F2000) where T : ModelBase;

    }
}
