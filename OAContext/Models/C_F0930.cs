using System;
using System.Collections.Generic;
using DBContextHelper;

namespace OAContext
{
    [Serializable]
    public partial class C_F0930 : ModelBase
    {
        public  C_F0930 ()
        {}

        public  C_F0930 (int i)
        {
                    CHKCOO = "" ;
                CHDOCO = 0 ;
                CHDCTO = "" ;
                CHNXTR = "" ;
                CHLTTR = "" ;
                CHDOC = 0 ;
                CHDCT = "" ;
                CHDSC1 = "" ;
                CHDSC2 = "" ;
                CHMCU = "" ;
                CHTRDJ = System.DateTime.Now ;
                CHDRQJ = System.DateTime.Now ;
                CHPDDJ = System.DateTime.Now ;
                CHADDJ = System.DateTime.Now ;
                CHCNDJ = System.DateTime.Now ;
                CHUPRC = 0 ;
                CHAEXP = 0 ;
                CHUNCS = 0 ;
                CHECST = 0 ;
                CHSOQS = 0 ;
                CHUORG = 0 ;
                CHTORG = "" ;
                CHVR01 = "" ;
                CHVR02 = "" ;
                CHSRP1 = "" ;
                CHSRP2 = "" ;
                CHSRP3 = "" ;
                CHSRP4 = "" ;
                CHSRP5 = "" ;
                CHPRP1 = 0 ;
                CHPRP2 = 0 ;
                CHPRP3 = 0 ;
                CHPRP4 = 0 ;
                CHPRP5 = 0 ;
                CHUSER = "" ;
                CHPID = "" ;
                CHDATE = System.DateTime.Now ;
                CHTIME = DateTime.Now.TimeOfDay ;
        }

        public string CHKCOO { get; set; }
        public int CHDOCO { get; set; }
        public string CHDCTO { get; set; }
        public string CHNXTR { get; set; }
        public string CHLTTR { get; set; }
        public int CHDOC { get; set; }
        public string CHDCT { get; set; }
        public string CHDSC1 { get; set; }
        public string CHDSC2 { get; set; }
        public string CHMCU { get; set; }
        public System.DateTime CHTRDJ { get; set; }
        public System.DateTime CHDRQJ { get; set; }
        public System.DateTime CHPDDJ { get; set; }
        public System.DateTime CHADDJ { get; set; }
        public System.DateTime CHCNDJ { get; set; }
        public decimal CHUPRC { get; set; }
        public decimal CHAEXP { get; set; }
        public decimal CHUNCS { get; set; }
        public decimal CHECST { get; set; }
        public decimal CHSOQS { get; set; }
        public decimal CHUORG { get; set; }
        public string CHTORG { get; set; }
        public string CHVR01 { get; set; }
        public string CHVR02 { get; set; }
        public string CHSRP1 { get; set; }
        public string CHSRP2 { get; set; }
        public string CHSRP3 { get; set; }
        public string CHSRP4 { get; set; }
        public string CHSRP5 { get; set; }
        public int CHPRP1 { get; set; }
        public int CHPRP2 { get; set; }
        public int CHPRP3 { get; set; }
        public int CHPRP4 { get; set; }
        public int CHPRP5 { get; set; }
        public string CHUSER { get; set; }
        public string CHPID { get; set; }
        public System.DateTime CHDATE { get; set; }
        public System.TimeSpan CHTIME { get; set; }
    }
}