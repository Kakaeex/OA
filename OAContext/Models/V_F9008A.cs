using System;
using System.Collections.Generic;
using DBContextHelper;

namespace OAContext
{
    [Serializable]
    public partial class V_F9008A : ModelBase
    {
        public  V_F9008A ()
        {}

        public  V_F9008A (int i)
        {
                    AUAN8 = 0 ;
                MCDC = "" ;
                AUDEL2 = "" ;
                AUSRP1 = "" ;
                AUSRP2 = "" ;
                AUSRP3 = "" ;
                AUSRP4 = "" ;
                AUSRP5 = "" ;
                AUPRP1 = 0 ;
                AUPRP2 = 0 ;
                AUPRP3 = 0 ;
                AUPRP5 = 0 ;
                AUPRP4 = 0 ;
                MCKCOO = "" ;
                MCMCU = "" ;
        }

        public int AUAN8 { get; set; }
        public string MCDC { get; set; }
        public string AUDEL2 { get; set; }
        public string AUSRP1 { get; set; }
        public string AUSRP2 { get; set; }
        public string AUSRP3 { get; set; }
        public string AUSRP4 { get; set; }
        public string AUSRP5 { get; set; }
        public int AUPRP1 { get; set; }
        public int AUPRP2 { get; set; }
        public int AUPRP3 { get; set; }
        public int AUPRP5 { get; set; }
        public int AUPRP4 { get; set; }
        public string MCKCOO { get; set; }
        public string MCMCU { get; set; }
    }
}