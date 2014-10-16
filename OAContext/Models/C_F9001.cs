using System;
using System.Collections.Generic;
using DBContextHelper;

namespace OAContext
{
    [Serializable]
    public partial class C_F9001 : ModelBase
    {
        public  C_F9001 ()
        {}

        public  C_F9001 (int i)
        {
                    RUKCOO = "" ;
                RUID = "" ;
                RUDEL1 = "" ;
                RUDEL2 = "" ;
                RUSRP1 = "" ;
                RUSRP2 = "" ;
                RUSRP3 = "" ;
                RUSRP4 = "" ;
                RUSRP5 = "" ;
                RUPRP1 = 0 ;
                RUPRP2 = 0 ;
                RUPRP3 = 0 ;
                RUPRP4 = 0 ;
                RUPRP5 = 0 ;
                RUUSER = "" ;
                RUPID = "" ;
                RUDATE = System.DateTime.Now ;
                RUTIME = DateTime.Now.TimeOfDay ;
        }

        public string RUKCOO { get; set; }
        public string RUID { get; set; }
        public string RUDEL1 { get; set; }
        public string RUDEL2 { get; set; }
        public string RUSRP1 { get; set; }
        public string RUSRP2 { get; set; }
        public string RUSRP3 { get; set; }
        public string RUSRP4 { get; set; }
        public string RUSRP5 { get; set; }
        public int RUPRP1 { get; set; }
        public int RUPRP2 { get; set; }
        public int RUPRP3 { get; set; }
        public int RUPRP4 { get; set; }
        public int RUPRP5 { get; set; }
        public string RUUSER { get; set; }
        public string RUPID { get; set; }
        public System.DateTime RUDATE { get; set; }
        public System.TimeSpan RUTIME { get; set; }
    }
}