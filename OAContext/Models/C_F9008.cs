using System;
using System.Collections.Generic;
using DBContextHelper;

namespace OAContext
{
    [Serializable]
    public partial class C_F9008 : ModelBase
    {
        public  C_F9008 ()
        {}

        public  C_F9008 (int i)
        {
                    AUKCOO = "" ;
                AUMCU = "" ;
                AUAN8 = 0 ;
                AUDEL1 = "" ;
                AUDEL2 = "" ;
                AUSRP1 = "" ;
                AUSRP2 = "" ;
                AUSRP3 = "" ;
                AUSRP4 = "" ;
                AUSRP5 = "" ;
                AUPRP1 = 0 ;
                AUPRP2 = 0 ;
                AUPRP3 = 0 ;
                AUPRP4 = 0 ;
                AUPRP5 = 0 ;
                AUUSER = "" ;
                AUPID = "" ;
                AUDATE = System.DateTime.Now ;
                AUTIME = DateTime.Now.TimeOfDay ;
        }

        public string AUKCOO { get; set; }
        public string AUMCU { get; set; }
        public int AUAN8 { get; set; }
        public string AUDEL1 { get; set; }
        public string AUDEL2 { get; set; }
        public string AUSRP1 { get; set; }
        public string AUSRP2 { get; set; }
        public string AUSRP3 { get; set; }
        public string AUSRP4 { get; set; }
        public string AUSRP5 { get; set; }
        public int AUPRP1 { get; set; }
        public int AUPRP2 { get; set; }
        public int AUPRP3 { get; set; }
        public int AUPRP4 { get; set; }
        public int AUPRP5 { get; set; }
        public string AUUSER { get; set; }
        public string AUPID { get; set; }
        public System.DateTime AUDATE { get; set; }
        public System.TimeSpan AUTIME { get; set; }
    }
}