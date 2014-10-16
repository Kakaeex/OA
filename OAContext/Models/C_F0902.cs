using System;
using System.Collections.Generic;
using DBContextHelper;

namespace OAContext
{
    [Serializable]
    public partial class C_F0902 : ModelBase
    {
        public  C_F0902 ()
        {}

        public  C_F0902 (int i)
        {
                    GBCO = "" ;
                GBMCU = "" ;
                GBAID = "" ;
                GBCTRY = 0 ;
                GBFY = 0 ;
                GBLT = "" ;
                GBOBJ = "" ;
                GBSUB = "" ;
                GBAPYC = 0 ;
                GBAN01 = 0 ;
                GBAN02 = 0 ;
                GBAN03 = 0 ;
                GBAN04 = 0 ;
                GBAN05 = 0 ;
                GBAN06 = 0 ;
                GBAN07 = 0 ;
                GBAN08 = 0 ;
                GBAN09 = 0 ;
                GBAN10 = 0 ;
                GBAN11 = 0 ;
                GBAN12 = 0 ;
                GBAN13 = 0 ;
                GBAN14 = 0 ;
                GBQ00 = 0 ;
                GBQ01 = 0 ;
                GBQ02 = 0 ;
                GBQ03 = 0 ;
                GBQ04 = 0 ;
                GBQ05 = 0 ;
                GBAPYN = 0 ;
                GBAWTD = 0 ;
                GBBORG = 0 ;
                GBPOU = 0 ;
                GBPC = 0 ;
                GBTKER = 0 ;
                GBBREQ = 0 ;
                GBBAPR = 0 ;
                GBUSER = "" ;
                GBPID = "" ;
                GBDATE = System.DateTime.Now ;
                GBTIME = DateTime.Now.TimeOfDay ;
        }

        public string GBCO { get; set; }
        public string GBMCU { get; set; }
        public string GBAID { get; set; }
        public int GBCTRY { get; set; }
        public int GBFY { get; set; }
        public string GBLT { get; set; }
        public string GBOBJ { get; set; }
        public string GBSUB { get; set; }
        public Nullable<decimal> GBAPYC { get; set; }
        public Nullable<decimal> GBAN01 { get; set; }
        public Nullable<decimal> GBAN02 { get; set; }
        public Nullable<decimal> GBAN03 { get; set; }
        public Nullable<decimal> GBAN04 { get; set; }
        public Nullable<decimal> GBAN05 { get; set; }
        public Nullable<decimal> GBAN06 { get; set; }
        public Nullable<decimal> GBAN07 { get; set; }
        public Nullable<decimal> GBAN08 { get; set; }
        public Nullable<decimal> GBAN09 { get; set; }
        public Nullable<decimal> GBAN10 { get; set; }
        public Nullable<decimal> GBAN11 { get; set; }
        public Nullable<decimal> GBAN12 { get; set; }
        public Nullable<decimal> GBAN13 { get; set; }
        public Nullable<decimal> GBAN14 { get; set; }
        public Nullable<decimal> GBQ00 { get; set; }
        public Nullable<decimal> GBQ01 { get; set; }
        public Nullable<decimal> GBQ02 { get; set; }
        public Nullable<decimal> GBQ03 { get; set; }
        public Nullable<decimal> GBQ04 { get; set; }
        public Nullable<decimal> GBQ05 { get; set; }
        public Nullable<decimal> GBAPYN { get; set; }
        public Nullable<decimal> GBAWTD { get; set; }
        public Nullable<decimal> GBBORG { get; set; }
        public Nullable<decimal> GBPOU { get; set; }
        public Nullable<decimal> GBPC { get; set; }
        public Nullable<decimal> GBTKER { get; set; }
        public Nullable<decimal> GBBREQ { get; set; }
        public Nullable<decimal> GBBAPR { get; set; }
        public string GBUSER { get; set; }
        public string GBPID { get; set; }
        public System.DateTime GBDATE { get; set; }
        public System.TimeSpan GBTIME { get; set; }
    }
}