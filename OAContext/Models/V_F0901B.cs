using System;
using System.Collections.Generic;
using DBContextHelper;

namespace OAContext
{
    [Serializable]
    public partial class V_F0901B : ModelBase
    {
        public  V_F0901B ()
        {}

        public  V_F0901B (int i)
        {
                    GMCO = "" ;
                GBAID = "" ;
                GMPAID = "" ;
                GMMCU = "" ;
                GMOBJ = "" ;
                GMSUB = "" ;
                GMANS = "" ;
                GMDL01 = "" ;
                GMDL02 = "" ;
                GMLDA = "" ;
                GMR023 = "" ;
        }

        public string GMCO { get; set; }
        public string GBAID { get; set; }
        public string GMPAID { get; set; }
        public string GMMCU { get; set; }
        public string GMOBJ { get; set; }
        public string GMSUB { get; set; }
        public string GMANS { get; set; }
        public string GMDL01 { get; set; }
        public string GMDL02 { get; set; }
        public string GMLDA { get; set; }
        public string GMR023 { get; set; }
    }
}