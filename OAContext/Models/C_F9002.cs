using System;
using System.Collections.Generic;
using DBContextHelper;

namespace OAContext
{
    public partial class C_F9002 : ModelBase
    {
        public  C_F9002 ()
        {}

        public  C_F9002 (int i)
        {
                    RPKCOO = "" ;
                RPRUID = "" ;
                RPMENUID = 0 ;
                RPPARENTID = 0 ;
                RPAPID = 0 ;
                RPBARNEW = 0 ;
                RPBARSAVE = 0 ;
                RPBARSELECT = 0 ;
                RPBARDELETE = 0 ;
                RPBARCLOSE = 0 ;
                RPBARFIND = 0 ;
                RPBARSAVEAS = 0 ;
                RPSRP1 = "" ;
                RPSRP2 = "" ;
                RPSRP3 = "" ;
                RPSRP4 = "" ;
                RPSRP5 = "" ;
                RPPRP1 = 0 ;
                RPPRP2 = 0 ;
                RPPRP3 = 0 ;
                RPPRP4 = 0 ;
                RPPRP5 = 0 ;
                RPUSER = "" ;
                RPPID = "" ;
                RPDATE = System.DateTime.Now ;
                RPTIME = DateTime.Now.TimeOfDay ;
        }

        public string RPKCOO { get; set; }
        public string RPRUID { get; set; }
        public int RPMENUID { get; set; }
        public int RPPARENTID { get; set; }
        public int RPAPID { get; set; }
        public int RPBARNEW { get; set; }
        public int RPBARSAVE { get; set; }
        public int RPBARSELECT { get; set; }
        public int RPBARDELETE { get; set; }
        public int RPBARCLOSE { get; set; }
        public int RPBARFIND { get; set; }
        public int RPBARSAVEAS { get; set; }
        public string RPSRP1 { get; set; }
        public string RPSRP2 { get; set; }
        public string RPSRP3 { get; set; }
        public string RPSRP4 { get; set; }
        public string RPSRP5 { get; set; }
        public int RPPRP1 { get; set; }
        public int RPPRP2 { get; set; }
        public int RPPRP3 { get; set; }
        public int RPPRP4 { get; set; }
        public int RPPRP5 { get; set; }
        public string RPUSER { get; set; }
        public string RPPID { get; set; }
        public System.DateTime RPDATE { get; set; }
        public System.TimeSpan RPTIME { get; set; }
    }
}