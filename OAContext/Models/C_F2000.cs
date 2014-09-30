using System;
using System.Collections.Generic;
using DBContextHelper;

namespace OAContext
{
    public partial class C_F2000 : ModelBase
    {
        public  C_F2000 ()
        {}

        public  C_F2000 (int i)
        {
                    WHKCOO =  " " ;
                WHDOCO = 0 ;
                WHDCTO =  " " ;
                WHDSC1 =  " " ;
                WHDSC2 =  " " ;
                WHDCT =  " " ;
                WHTRDJ = System.DateTime.Now ;
                WHDRQJ = System.DateTime.Now ;
                WHPDDJ = System.DateTime.Now ;
                WHADDJ = System.DateTime.Now ;
                WHCNDJ = System.DateTime.Now ;
                WHUPRC = 0 ;
                WHAEXP = 0 ;
                WHUNCS = 0 ;
                WHECST = 0 ;
                WHSOQS = 0 ;
                WHUORG = 0 ;
                WHVR01 =  " " ;
                WHVR02 =  " " ;
                WHSRP1 =  " " ;
                WHSRP2 =  " " ;
                WHSRP3 =  " " ;
                WHSRP4 =  " " ;
                WHSRP5 =  " " ;
                WHPRP1 = 0 ;
                WHPRP2 = 0 ;
                WHPRP3 = 0 ;
                WHPRP4 = 0 ;
                WHPRP5 = 0 ;
                WHUSER =  " " ;
                WHPID =  " " ;
                WHDATE = System.DateTime.Now ;
                WHTIME = DateTime.Now.TimeOfDay ;
        }

        public string WHKCOO { get; set; }
        public int WHDOCO { get; set; }
        public string WHDCTO { get; set; }
        public string WHDSC1 { get; set; }
        public string WHDSC2 { get; set; }
        public string WHDCT { get; set; }
        public Nullable<System.DateTime> WHTRDJ { get; set; }
        public Nullable<System.DateTime> WHDRQJ { get; set; }
        public Nullable<System.DateTime> WHPDDJ { get; set; }
        public Nullable<System.DateTime> WHADDJ { get; set; }
        public Nullable<System.DateTime> WHCNDJ { get; set; }
        public Nullable<decimal> WHUPRC { get; set; }
        public Nullable<decimal> WHAEXP { get; set; }
        public Nullable<decimal> WHUNCS { get; set; }
        public Nullable<decimal> WHECST { get; set; }
        public Nullable<decimal> WHSOQS { get; set; }
        public Nullable<decimal> WHUORG { get; set; }
        public string WHVR01 { get; set; }
        public string WHVR02 { get; set; }
        public string WHSRP1 { get; set; }
        public string WHSRP2 { get; set; }
        public string WHSRP3 { get; set; }
        public string WHSRP4 { get; set; }
        public string WHSRP5 { get; set; }
        public Nullable<int> WHPRP1 { get; set; }
        public Nullable<int> WHPRP2 { get; set; }
        public Nullable<int> WHPRP3 { get; set; }
        public Nullable<int> WHPRP4 { get; set; }
        public Nullable<int> WHPRP5 { get; set; }
        public string WHUSER { get; set; }
        public string WHPID { get; set; }
        public System.DateTime WHDATE { get; set; }
        public System.TimeSpan WHTIME { get; set; }
    }
}