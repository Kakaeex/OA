using System;
using System.Collections.Generic;
using DBContextHelper;

namespace OAContext
{
    public partial class C_F0930 : ModelBase
    {
        public  C_F0930 ()
        {}

        public  C_F0930 (int i)
        {
                    CHKCOO = "" ;
                CHDOCO = 0 ;
                CHDCTO = "" ;
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
        public int CHDOC { get; set; }
        public string CHDCT { get; set; }
        public string CHDSC1 { get; set; }
        public string CHDSC2 { get; set; }
        public string CHMCU { get; set; }
        public Nullable<System.DateTime> CHTRDJ { get; set; }
        public Nullable<System.DateTime> CHDRQJ { get; set; }
        public Nullable<System.DateTime> CHPDDJ { get; set; }
        public Nullable<System.DateTime> CHADDJ { get; set; }
        public Nullable<System.DateTime> CHCNDJ { get; set; }
        public Nullable<decimal> CHUPRC { get; set; }
        public Nullable<decimal> CHAEXP { get; set; }
        public Nullable<decimal> CHUNCS { get; set; }
        public Nullable<decimal> CHECST { get; set; }
        public Nullable<decimal> CHSOQS { get; set; }
        public Nullable<decimal> CHUORG { get; set; }
        public string CHVR01 { get; set; }
        public string CHVR02 { get; set; }
        public string CHSRP1 { get; set; }
        public string CHSRP2 { get; set; }
        public string CHSRP3 { get; set; }
        public string CHSRP4 { get; set; }
        public string CHSRP5 { get; set; }
        public Nullable<int> CHPRP1 { get; set; }
        public Nullable<int> CHPRP2 { get; set; }
        public Nullable<int> CHPRP3 { get; set; }
        public Nullable<int> CHPRP4 { get; set; }
        public Nullable<int> CHPRP5 { get; set; }
        public string CHUSER { get; set; }
        public string CHPID { get; set; }
        public System.DateTime CHDATE { get; set; }
        public System.TimeSpan CHTIME { get; set; }
    }
}