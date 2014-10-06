using System;
using System.Collections.Generic;
using DBContextHelper;

namespace OAContext
{
    public partial class C_F9005 : ModelBase
    {
        public  C_F9005 ()
        {}

        public  C_F9005 (int i)
        {
                    APKCOO = "" ;
                APID = 0 ;
                APDEL1 = "" ;
                APDEL2 = "" ;
                APURL = "" ;
                APSRP1 = "" ;
                APSRP2 = "" ;
                APSRP3 = "" ;
                APSRP4 = "" ;
                APSRP5 = "" ;
                APPRP1 = 0 ;
                APPRP2 = 0 ;
                APPRP3 = 0 ;
                APPRP4 = 0 ;
                APPRP5 = 0 ;
                APUSER = "" ;
                APPID = "" ;
                APDATE = System.DateTime.Now ;
                APTIME = DateTime.Now.TimeOfDay ;
        }

        public string APKCOO { get; set; }
        public int APID { get; set; }
        public string APDEL1 { get; set; }
        public string APDEL2 { get; set; }
        public string APURL { get; set; }
        public string APSRP1 { get; set; }
        public string APSRP2 { get; set; }
        public string APSRP3 { get; set; }
        public string APSRP4 { get; set; }
        public string APSRP5 { get; set; }
        public int APPRP1 { get; set; }
        public int APPRP2 { get; set; }
        public int APPRP3 { get; set; }
        public int APPRP4 { get; set; }
        public int APPRP5 { get; set; }
        public string APUSER { get; set; }
        public string APPID { get; set; }
        public System.DateTime APDATE { get; set; }
        public System.TimeSpan APTIME { get; set; }
    }
}