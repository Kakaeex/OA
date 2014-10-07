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
    public class Order : IOrder
    {
        public IDataRepository _DBHelper { get; set; }

        private static readonly object olock = new object();

        public Order()
        { }

        public Order(IDataRepository DBHelper)
        {
            _DBHelper = DBHelper;
        }
        public int GetNextNumber(string dcto, string kcoo, string name)
        {
            lock (olock)
            {
                C_F00022 file = _DBHelper.Find<C_F00022>(p => p.UKKCOO == kcoo & p.UKDCTO == dcto & p.UKNAME == name);
                if (file != null)
                {
                    file.UKDOCO = file.UKDOCO + file.UKADD;
                }
                else
                {
                    file = new C_F00022();
                    file.UKKCOO = kcoo;
                    file.UKDCTO = dcto;
                    file.UKNAME = name;
                    file.UKDOCO = 1;
                    file.UKFROM = 1;
                    file.UKADD = 1;
                }
                return _DBHelper.AddorUpdate<C_F00022>(file) > 0 ? file.UKDOCO : 0;
            }
        }
    }
}
