using System;
using System.Collections.Generic;
using DBContextHelper;

namespace OAContext
{
    public partial class C_F9006 : ModelBase
    {
        public  C_F9006 ()
        {}

        public  C_F9006 (int i)
        {
                    RAKCOO = "" ;
                RAAN8 = 0 ;
                RAID = "" ;
                RADEL1 = "" ;
                RADEL2 = "" ;
                RASRP1 = "" ;
                RASRP2 = "" ;
                RASRP3 = "" ;
                RASRP4 = "" ;
                RASRP5 = "" ;
                RAPRP1 = 0 ;
                RAPRP2 = 0 ;
                RAPRP3 = 0 ;
                RAPRP4 = 0 ;
                RAPRP5 = 0 ;
                RAUSER = "" ;
                RAPID = "" ;
                RADATE = System.DateTime.Now ;
                RATIME = DateTime.Now.TimeOfDay ;
        }

        public string RAKCOO { get; set; }
        public int RAAN8 { get; set; }
        public string RAID { get; set; }
        public string RADEL1 { get; set; }
        public string RADEL2 { get; set; }
        public string RASRP1 { get; set; }
        public string RASRP2 { get; set; }
        public string RASRP3 { get; set; }
        public string RASRP4 { get; set; }
        public string RASRP5 { get; set; }
        public int RAPRP1 { get; set; }
        public int RAPRP2 { get; set; }
        public int RAPRP3 { get; set; }
        public int RAPRP4 { get; set; }
        public int RAPRP5 { get; set; }
        public string RAUSER { get; set; }
        public string RAPID { get; set; }
        public System.DateTime RADATE { get; set; }
        public System.TimeSpan RATIME { get; set; }
    }
}