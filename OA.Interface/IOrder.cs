using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Interface
{
    public interface IOrder
    {
        int GetNextNumber(string dcto, string kcoo, string name);
    }
}
