using System;
using System.Collections.Generic;
using DBContextHelper;

namespace OAContext
{
    public partial class C_F0005 : ModelBase
    {
        public  C_F0005 ()
        {}

        public  C_F0005 (int i)
        {
                    DRKCOO =  " " ;
                DRLNGP =  " " ;
                DRSY =  " " ;
                DRRT =  " " ;
                DRKY =  " " ;
                DRDEL1 =  " " ;
                DRDEL2 =  " " ;
                DRSRP1 =  " " ;
                DRSRP2 =  " " ;
                DRSRP3 =  " " ;
                DRSRP4 =  " " ;
                DRSRP5 =  " " ;
                DRPRP1 = 0 ;
                DRPRP2 = 0 ;
                DRPRP3 = 0 ;
                DRPRP4 = 0 ;
                DRPRP5 = 0 ;
                DRUSER =  " " ;
                DRPID =  " " ;
                DRDATE = System.DateTime.Now ;
                DRTIME = DateTime.Now.TimeOfDay ;
        }

        public string DRKCOO { get; set; }
        public string DRLNGP { get; set; }
        public string DRSY { get; set; }
        public string DRRT { get; set; }
        public string DRKY { get; set; }
        public string DRDEL1 { get; set; }
        public string DRDEL2 { get; set; }
        public string DRSRP1 { get; set; }
        public string DRSRP2 { get; set; }
        public string DRSRP3 { get; set; }
        public string DRSRP4 { get; set; }
        public string DRSRP5 { get; set; }
        public int DRPRP1 { get; set; }
        public int DRPRP2 { get; set; }
        public int DRPRP3 { get; set; }
        public int DRPRP4 { get; set; }
        public int DRPRP5 { get; set; }
        public string DRUSER { get; set; }
        public string DRPID { get; set; }
        public System.DateTime DRDATE { get; set; }
        public System.TimeSpan DRTIME { get; set; }
    }
}