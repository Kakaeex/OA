using System;
using System.Collections.Generic;
using DBContextHelper;

namespace OAContext
{
    public partial class C_F00022 : ModelBase
    {
        public  C_F00022 ()
        {}

        public  C_F00022 (int i)
        {
                    UKKCOO = "" ;
                UKDOCO = 0 ;
                UKDCTO = "" ;
                UKNAME = "" ;
                UKFROM = 0 ;
                UKADD = 0 ;
        }

        public string UKKCOO { get; set; }
        public int UKDOCO { get; set; }
        public string UKDCTO { get; set; }
        public string UKNAME { get; set; }
        public int UKFROM { get; set; }
        public int UKADD { get; set; }
    }
}