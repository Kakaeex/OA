using System;
using System.Collections.Generic;
using DBContextHelper;

namespace OAContext
{
    [Serializable]
    public partial class C_F0101 : ModelBase
    {
        public  C_F0101 ()
        {}

        public  C_F0101 (int i)
        {
                    ABKCOO = "" ;
                ABAN8 = 0 ;
                ABALKY = "" ;
                ABTAX = "" ;
                ABALPH = "" ;
                ABDC = "" ;
                ABMCU = "" ;
                ABSIC = "" ;
                ABLNGP = "" ;
                ABAT1 = "" ;
                ABCM = "" ;
                ABCLASS01 = "" ;
                ABCLASS02 = "" ;
                ABCLASS03 = "" ;
                ABCLASS04 = "" ;
                ABCLASS05 = "" ;
                ABCLASS06 = "" ;
                ABCLASS07 = "" ;
                ABCLASS08 = "" ;
                ABCLASS09 = "" ;
                ABCLASS10 = "" ;
                ABPRP1 = 0 ;
                ABPRP2 = 0 ;
                ABPRP3 = 0 ;
                ABPRP4 = 0 ;
                ABPRP5 = 0 ;
                ABPRP6 = 0 ;
                ABPRP7 = 0 ;
                ABPRP8 = 0 ;
                ABPRP9 = 0 ;
                ABPRP0 = 0 ;
                ABUSER = "" ;
                ABPID = "" ;
                ABDATE = System.DateTime.Now ;
                ABTIME = DateTime.Now.TimeOfDay ;
        }

        public string ABKCOO { get; set; }
        public int ABAN8 { get; set; }
        public string ABALKY { get; set; }
        public string ABTAX { get; set; }
        public string ABALPH { get; set; }
        public string ABDC { get; set; }
        public string ABMCU { get; set; }
        public string ABSIC { get; set; }
        public string ABLNGP { get; set; }
        public string ABAT1 { get; set; }
        public string ABCM { get; set; }
        public string ABCLASS01 { get; set; }
        public string ABCLASS02 { get; set; }
        public string ABCLASS03 { get; set; }
        public string ABCLASS04 { get; set; }
        public string ABCLASS05 { get; set; }
        public string ABCLASS06 { get; set; }
        public string ABCLASS07 { get; set; }
        public string ABCLASS08 { get; set; }
        public string ABCLASS09 { get; set; }
        public string ABCLASS10 { get; set; }
        public int ABPRP1 { get; set; }
        public int ABPRP2 { get; set; }
        public int ABPRP3 { get; set; }
        public int ABPRP4 { get; set; }
        public int ABPRP5 { get; set; }
        public int ABPRP6 { get; set; }
        public int ABPRP7 { get; set; }
        public int ABPRP8 { get; set; }
        public int ABPRP9 { get; set; }
        public int ABPRP0 { get; set; }
        public string ABUSER { get; set; }
        public string ABPID { get; set; }
        public System.DateTime ABDATE { get; set; }
        public System.TimeSpan ABTIME { get; set; }
    }
}