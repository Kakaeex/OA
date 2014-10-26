using System;
using System.Collections.Generic;
using DBContextHelper;

namespace OAContext
{
    [Serializable]
    public partial class C_F2012 : ModelBase
    {
        public  C_F2012 ()
        {}

        public  C_F2012 (int i)
        {
                    WFDOCO = 0 ;
                WFDCTO = "" ;
                WFLNID = 0 ;
                WFCDOC = 0 ;
                WFCDCT = "" ;
                WFDEL1 = "" ;
                WFDEL2 = "" ;
                WFFDOC = 0 ;
                WFFDCT = "" ;
                WFDSC1 = "" ;
                WFDSC2 = "" ;
                WFVR01 = "" ;
                WFVR02 = "" ;
                WFSRP1 = "" ;
                WFSRP2 = "" ;
                WFSRP3 = "" ;
                WFSRP4 = "" ;
                WFSRP5 = "" ;
                WFPRP1 = 0 ;
                WFPRP2 = 0 ;
                WFPRP3 = 0 ;
                WFPRP4 = 0 ;
                WFPRP5 = 0 ;
                WFUSER = "" ;
                WFPID = "" ;
                WFDATE = System.DateTime.Now ;
                WFTIME = DateTime.Now.TimeOfDay ;
        }

        public int WFDOCO { get; set; }
        public string WFDCTO { get; set; }
        public int WFLNID { get; set; }
        public int WFCDOC { get; set; }
        public string WFCDCT { get; set; }
        public string WFDEL1 { get; set; }
        public string WFDEL2 { get; set; }
        public int WFFDOC { get; set; }
        public string WFFDCT { get; set; }
        public string WFDSC1 { get; set; }
        public string WFDSC2 { get; set; }
        public string WFVR01 { get; set; }
        public string WFVR02 { get; set; }
        public string WFSRP1 { get; set; }
        public string WFSRP2 { get; set; }
        public string WFSRP3 { get; set; }
        public string WFSRP4 { get; set; }
        public string WFSRP5 { get; set; }
        public int WFPRP1 { get; set; }
        public int WFPRP2 { get; set; }
        public int WFPRP3 { get; set; }
        public int WFPRP4 { get; set; }
        public int WFPRP5 { get; set; }
        public string WFUSER { get; set; }
        public string WFPID { get; set; }
        public System.DateTime WFDATE { get; set; }
        public System.TimeSpan WFTIME { get; set; }
    }
}