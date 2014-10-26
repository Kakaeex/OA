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
    public class Message : IMessage
    {
       public OAContext.OAContext _DBHelper { get; set; }

        public Message()
        { }

        public Message(OAContext.OAContext DBHelper)
        {
            _DBHelper = DBHelper;
        }
       public  List<dynamic> messageQuenee { get; set; }

       public C_F0035 GetMessage(string type, string code, string kcoo = "00068", string language = "CS")
       {
           return _DBHelper.Find<C_F0035>
               (p => p.MSKCOO == kcoo & p.MSDCTO == type & p.MSCODE == code & p.MSLNGP == language);
       }
    }
}
