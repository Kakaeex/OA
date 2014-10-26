using System;
using System.Collections.Generic;
using DBContextHelper;

namespace OAContext
{
    [Serializable]
    public partial class C_F0903 : ModelBase
    {
        public  C_F0903 ()
        {}

        public  C_F0903 (int i)
        {
                    GDMAID = "" ;
                GDMMCU = "" ;
                GDMOBJ = "" ;
                GDMSUB = "" ;
                GDMDL01 = "" ;
                GDMDL02 = "" ;
                GDFAID = "" ;
                GDFMCU = "" ;
                GDFOBJ = "" ;
                GDFSUB = "" ;
                GDFDL01 = "" ;
                GDFDL02 = "" ;
                GDSRP1 = "" ;
                GDSRP2 = "" ;
                GDSRP3 = "" ;
                GDSRP4 = "" ;
                GDSRP5 = "" ;
                GDPRP1 = 0 ;
                GDPRP2 = 0 ;
                GDPRP3 = 0 ;
                GDPRP4 = 0 ;
                GDPRP5 = 0 ;
                GDUSER = "" ;
                GDPID = "" ;
                GDDATE = System.DateTime.Now ;
                GDTIME = DateTime.Now.TimeOfDay ;
        }

        public string GDMAID { get; set; }
        public string GDMMCU { get; set; }
        public string GDMOBJ { get; set; }
        public string GDMSUB { get; set; }
        public string GDMDL01 { get; set; }
        public string GDMDL02 { get; set; }
        public string GDFAID { get; set; }
        public string GDFMCU { get; set; }
        public string GDFOBJ { get; set; }
        public string GDFSUB { get; set; }
        public string GDFDL01 { get; set; }
        public string GDFDL02 { get; set; }
        public string GDSRP1 { get; set; }
        public string GDSRP2 { get; set; }
        public string GDSRP3 { get; set; }
        public string GDSRP4 { get; set; }
        public string GDSRP5 { get; set; }
        public int GDPRP1 { get; set; }
        public int GDPRP2 { get; set; }
        public int GDPRP3 { get; set; }
        public int GDPRP4 { get; set; }
        public int GDPRP5 { get; set; }
        public string GDUSER { get; set; }
        public string GDPID { get; set; }
        public System.DateTime GDDATE { get; set; }
        public System.TimeSpan GDTIME { get; set; }
    }
}