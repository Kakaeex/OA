using System;
using System.Collections.Generic;
using DBContextHelper;

namespace OAContext
{
    public partial class C_F2001 : ModelBase
    {
        public  C_F2001 ()
        {}

        public  C_F2001 (int i)
        {
                    WDKCOO =  " " ;
                WDDOCO = 0 ;
                WDDCTO =  " " ;
                WDLIND = 0 ;
                WDDSC1 =  " " ;
                WDDSC2 =  " " ;
                WDDCT =  " " ;
                WDTRDJ = System.DateTime.Now ;
                WDDRQJ = System.DateTime.Now ;
                WDPDDJ = System.DateTime.Now ;
                WDADDJ = System.DateTime.Now ;
                WDCNDJ = System.DateTime.Now ;
                WDUPRC = 0 ;
                WDAEXP = 0 ;
                WDUNCS = 0 ;
                WDECST = 0 ;
                WDSOQS = 0 ;
                WDUORG = 0 ;
                WDVR01 =  " " ;
                WDVR02 =  " " ;
                WDSRP1 =  " " ;
                WDSRP2 =  " " ;
                WDSRP3 =  " " ;
                WDSRP4 =  " " ;
                WDSRP5 =  " " ;
                WDPRP1 = 0 ;
                WDPRP2 = 0 ;
                WDPRP3 = 0 ;
                WDPRP4 = 0 ;
                WDPRP5 = 0 ;
                WDUSER =  " " ;
                WDPID =  " " ;
                WDDATE = System.DateTime.Now ;
                WDTIME = DateTime.Now.TimeOfDay ;
        }

        public string WDKCOO { get; set; }
        public int WDDOCO { get; set; }
        public string WDDCTO { get; set; }
        public int WDLIND { get; set; }
        public string WDDSC1 { get; set; }
        public string WDDSC2 { get; set; }
        public string WDDCT { get; set; }
        public Nullable<System.DateTime> WDTRDJ { get; set; }
        public Nullable<System.DateTime> WDDRQJ { get; set; }
        public Nullable<System.DateTime> WDPDDJ { get; set; }
        public Nullable<System.DateTime> WDADDJ { get; set; }
        public Nullable<System.DateTime> WDCNDJ { get; set; }
        public Nullable<decimal> WDUPRC { get; set; }
        public Nullable<decimal> WDAEXP { get; set; }
        public Nullable<decimal> WDUNCS { get; set; }
        public Nullable<decimal> WDECST { get; set; }
        public Nullable<decimal> WDSOQS { get; set; }
        public Nullable<decimal> WDUORG { get; set; }
        public string WDVR01 { get; set; }
        public string WDVR02 { get; set; }
        public string WDSRP1 { get; set; }
        public string WDSRP2 { get; set; }
        public string WDSRP3 { get; set; }
        public string WDSRP4 { get; set; }
        public string WDSRP5 { get; set; }
        public Nullable<int> WDPRP1 { get; set; }
        public Nullable<int> WDPRP2 { get; set; }
        public Nullable<int> WDPRP3 { get; set; }
        public Nullable<int> WDPRP4 { get; set; }
        public Nullable<int> WDPRP5 { get; set; }
        public string WDUSER { get; set; }
        public string WDPID { get; set; }
        public System.DateTime WDDATE { get; set; }
        public System.TimeSpan WDTIME { get; set; }
    }
}