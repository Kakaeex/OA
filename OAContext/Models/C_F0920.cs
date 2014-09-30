using System;
using System.Collections.Generic;
using DBContextHelper;

namespace OAContext
{
    public partial class C_F0920 : ModelBase
    {
        public  C_F0920 ()
        {}

        public  C_F0920 (int i)
        {
                    FHDOCO = 0 ;
                FHDCTO =  " " ;
                FHMCU =  " " ;
                FHYAER = 0 ;
                FHEFTJ = System.DateTime.Now ;
                FHEDXJ = System.DateTime.Now ;
                FHNAME =  " " ;
                FHDSC1 =  " " ;
                FHDSC2 =  " " ;
                FHUPRC = 0 ;
                FHAPYN = 0 ;
                FHAWTD = 0 ;
                FHLTTR =  " " ;
                FHNXTR =  " " ;
                FHSRP1 =  " " ;
                FHSRP2 =  " " ;
                FHSRP3 =  " " ;
                FHSRP4 =  " " ;
                FHSRP5 =  " " ;
                FHSRP6 =  " " ;
                FHSRP7 =  " " ;
                FHSRP8 =  " " ;
                FHSRP9 =  " " ;
                FHSRP0 =  " " ;
                FHPRP1 = 0 ;
                FHPRP2 = 0 ;
                FHPRP3 = 0 ;
                FHPRP4 = 0 ;
                FHPRP5 = 0 ;
                FHPRP6 = 0 ;
                FHPRP7 = 0 ;
                FHPRP8 = 0 ;
                FHPRP9 = 0 ;
                FHPRP0 = 0 ;
                FHTROG =  " " ;
                FHUSER =  " " ;
                FHPID =  " " ;
                FHDATE = System.DateTime.Now ;
                FHTIME = System.DateTime.Now.TimeOfDay ;
        }

        public int FHDOCO { get; set; }
        public string FHDCTO { get; set; }
        public string FHMCU { get; set; }
        public Nullable<int> FHYAER { get; set; }
        public Nullable<System.DateTime> FHEFTJ { get; set; }
        public Nullable<System.DateTime> FHEDXJ { get; set; }
        public string FHNAME { get; set; }
        public string FHDSC1 { get; set; }
        public string FHDSC2 { get; set; }
        public Nullable<decimal> FHUPRC { get; set; }
        public Nullable<decimal> FHAPYN { get; set; }
        public Nullable<decimal> FHAWTD { get; set; }
        public string FHLTTR { get; set; }
        public string FHNXTR { get; set; }
        public string FHSRP1 { get; set; }
        public string FHSRP2 { get; set; }
        public string FHSRP3 { get; set; }
        public string FHSRP4 { get; set; }
        public string FHSRP5 { get; set; }
        public string FHSRP6 { get; set; }
        public string FHSRP7 { get; set; }
        public string FHSRP8 { get; set; }
        public string FHSRP9 { get; set; }
        public string FHSRP0 { get; set; }
        public Nullable<int> FHPRP1 { get; set; }
        public Nullable<int> FHPRP2 { get; set; }
        public Nullable<int> FHPRP3 { get; set; }
        public Nullable<int> FHPRP4 { get; set; }
        public Nullable<int> FHPRP5 { get; set; }
        public Nullable<int> FHPRP6 { get; set; }
        public Nullable<int> FHPRP7 { get; set; }
        public Nullable<int> FHPRP8 { get; set; }
        public Nullable<int> FHPRP9 { get; set; }
        public Nullable<int> FHPRP0 { get; set; }
        public string FHTROG { get; set; }
        public string FHUSER { get; set; }
        public string FHPID { get; set; }
        public Nullable<System.DateTime> FHDATE { get; set; }
        public Nullable<System.TimeSpan> FHTIME { get; set; }
    }
}