using System;
using System.Collections.Generic;
using DBContextHelper;

namespace OAContext
{
    public partial class C_F2000 : ModelBase
    {
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
