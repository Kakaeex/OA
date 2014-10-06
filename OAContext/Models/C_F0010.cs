using System;
using System.Collections.Generic;
using DBContextHelper;

namespace OAContext
{
    public partial class C_F0010 : ModelBase
    {
        public  C_F0010 ()
        {}

        public  C_F0010 (int i)
        {
                    CCCO = "" ;
                CCNAME = "" ;
                CCDSC1 = "" ;
                CCDSC2 = "" ;
                CCCTRY = 0 ;
                CCFY = 0 ;
                CCCRCD = "" ;
                CCAN8 = 0 ;
                CCADDZ = "" ;
                CCCTY1 = "" ;
                CCCOUN = "" ;
                CCADDS = "" ;
                CCSRP1 = "" ;
                CCSRP2 = "" ;
                CCSRP3 = "" ;
                CCSRP4 = "" ;
                CCSRP5 = "" ;
                CCSRP6 = "" ;
                CCSRP7 = "" ;
                CCSRP8 = "" ;
                CCSRP9 = "" ;
                CCSRP0 = "" ;
                CCPRP1 = 0 ;
                CCPRP2 = 0 ;
                CCPRP3 = 0 ;
                CCPRP4 = 0 ;
                CCPRP5 = 0 ;
                CCPRP6 = 0 ;
                CCPRP7 = 0 ;
                CCPRP8 = 0 ;
                CCPRP9 = 0 ;
                CCPRP0 = 0 ;
                CCUSER = "" ;
                CCPID = "" ;
                CCDATE = System.DateTime.Now ;
                CCTIME = System.DateTime.Now.TimeOfDay ;
        }

        public string CCCO { get; set; }
        public string CCNAME { get; set; }
        public string CCDSC1 { get; set; }
        public string CCDSC2 { get; set; }
        public Nullable<int> CCCTRY { get; set; }
        public Nullable<int> CCFY { get; set; }
        public string CCCRCD { get; set; }
        public Nullable<int> CCAN8 { get; set; }
        public string CCADDZ { get; set; }
        public string CCCTY1 { get; set; }
        public string CCCOUN { get; set; }
        public string CCADDS { get; set; }
        public string CCSRP1 { get; set; }
        public string CCSRP2 { get; set; }
        public string CCSRP3 { get; set; }
        public string CCSRP4 { get; set; }
        public string CCSRP5 { get; set; }
        public string CCSRP6 { get; set; }
        public string CCSRP7 { get; set; }
        public string CCSRP8 { get; set; }
        public string CCSRP9 { get; set; }
        public string CCSRP0 { get; set; }
        public Nullable<int> CCPRP1 { get; set; }
        public Nullable<int> CCPRP2 { get; set; }
        public Nullable<int> CCPRP3 { get; set; }
        public Nullable<int> CCPRP4 { get; set; }
        public Nullable<int> CCPRP5 { get; set; }
        public Nullable<int> CCPRP6 { get; set; }
        public Nullable<int> CCPRP7 { get; set; }
        public Nullable<int> CCPRP8 { get; set; }
        public Nullable<int> CCPRP9 { get; set; }
        public Nullable<int> CCPRP0 { get; set; }
        public string CCUSER { get; set; }
        public string CCPID { get; set; }
        public Nullable<System.DateTime> CCDATE { get; set; }
        public Nullable<System.TimeSpan> CCTIME { get; set; }
    }
}