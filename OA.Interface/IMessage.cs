using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OAContext;

namespace OA.Interface
{
   public  interface IMessage
    {
       List<dynamic> messageQuenee { get; set; }

       C_F0035 GetMessage(string type, string code, string kcoo="00068", string language = "CS");

    }
}
