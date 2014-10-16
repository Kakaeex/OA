using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Interface
{
   public  interface IMessage
    {
       dynamic GetMessage(string type, string code);

    }
}
