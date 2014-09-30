using System;
using System.Collections.Generic;
using DBContextHelper;

namespace OAContext
{
    public partial class C_F0006 : ModelBase
    {
        public  C_F0006 ()
        {}

        public  C_F0006 (int i)
        {
                    MCKCOO =  " " ;
                MCMCU =  " " ;
                MCSTYL =  " " ;
                MCDC =  " " ;
                MCLDM = 0 ;
                MCCO =  " " ;
                MCPMCU =  " " ;
                MCAN8 = 0 ;
                MCAN8O = 0 ;
                MCCNTY =  " " ;
                MCADDS =  " " ;
                MCFMOD =  " " ;
                MCDL01 =  " " ;
                MCDL02 =  " " ;
                MCDL03 =  " " ;
                MCDL04 =  " " ;
                MCSRP1 =  " " ;
                MCSRP2 =  " " ;
                MCSRP3 =  " " ;
                MCSRP4 =  " " ;
                MCSRP5 =  " " ;
                MCPRP1 = 0 ;
                MCPRP2 = 0 ;
                MCPRP3 = 0 ;
                MCPRP4 = 0 ;
                MCPRP5 = 0 ;
                MCUSER =  " " ;
                MCPID =  " " ;
                MCDATE = System.DateTime.Now ;
                MCTIME = DateTime.Now.TimeOfDay ;
        }

        public string MCKCOO { get; set; }
        public string MCMCU { get; set; }
        public string MCSTYL { get; set; }
        public string MCDC { get; set; }
        public int MCLDM { get; set; }
        public string MCCO { get; set; }
        public string MCPMCU { get; set; }
        public int MCAN8 { get; set; }
        public int MCAN8O { get; set; }
        public string MCCNTY { get; set; }
        public string MCADDS { get; set; }
        public string MCFMOD { get; set; }
        public string MCDL01 { get; set; }
        public string MCDL02 { get; set; }
        public string MCDL03 { get; set; }
        public string MCDL04 { get; set; }
        public string MCSRP1 { get; set; }
        public string MCSRP2 { get; set; }
        public string MCSRP3 { get; set; }
        public string MCSRP4 { get; set; }
        public string MCSRP5 { get; set; }
        public int MCPRP1 { get; set; }
        public int MCPRP2 { get; set; }
        public int MCPRP3 { get; set; }
        public int MCPRP4 { get; set; }
        public int MCPRP5 { get; set; }
        public string MCUSER { get; set; }
        public string MCPID { get; set; }
        public System.DateTime MCDATE { get; set; }
        public System.TimeSpan MCTIME { get; set; }
    }
}