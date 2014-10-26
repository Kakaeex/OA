using System;
using System.Collections.Generic;
using DBContextHelper;

namespace OAContext
{
    [Serializable]
    public partial class V_F0901A : ModelBase
    {
        public  V_F0901A ()
        {}

        public  V_F0901A (int i)
        {
                    GMDL01 = "" ;
                GMDL02 = "" ;
                GMLDA = "" ;
                GMR023 = "" ;
                GBFY = 0 ;
                GBCTRY = 0 ;
                GBLT = "" ;
                GBQ00 = 0 ;
                GBQ01 = 0 ;
                GBQ02 = 0 ;
                GBQ03 = 0 ;
                GBQ04 = 0 ;
                GBQ05 = 0 ;
                GBAPYN = 0 ;
                GBAWTD = 0 ;
                GBBORG = 0 ;
                GBCO = "" ;
                GBMCU = "" ;
                GBAID = "" ;
                GBOBJ = "" ;
                GBSUB = "" ;
        }

        public string GMDL01 { get; set; }
        public string GMDL02 { get; set; }
        public string GMLDA { get; set; }
        public string GMR023 { get; set; }
        public int GBFY { get; set; }
        public int GBCTRY { get; set; }
        public string GBLT { get; set; }
        public Nullable<decimal> GBQ00 { get; set; }
        public Nullable<decimal> GBQ01 { get; set; }
        public Nullable<decimal> GBQ02 { get; set; }
        public Nullable<decimal> GBQ03 { get; set; }
        public Nullable<decimal> GBQ04 { get; set; }
        public Nullable<decimal> GBQ05 { get; set; }
        public Nullable<decimal> GBAPYN { get; set; }
        public Nullable<decimal> GBAWTD { get; set; }
        public Nullable<decimal> GBBORG { get; set; }
        public string GBCO { get; set; }
        public string GBMCU { get; set; }
        public string GBAID { get; set; }
        public string GBOBJ { get; set; }
        public string GBSUB { get; set; }
    }
}