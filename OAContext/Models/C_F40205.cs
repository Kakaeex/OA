using System;
using System.Collections.Generic;
using DBContextHelper;

namespace OAContext
{
    [Serializable]
    public partial class C_F40205 : ModelBase
    {
        public  C_F40205 ()
        {}

        public  C_F40205 (int i)
        {
                    LFLNTY = "" ;
                LFLNDS = "" ;
                LFLND2 = "" ;
                LFSRP1 = "" ;
                LFSRP2 = "" ;
                LFSRP3 = "" ;
                LFSRP4 = "" ;
                LFSRP5 = "" ;
                LFSRP6 = "" ;
                LFSRP7 = "" ;
                LFSRP8 = "" ;
                LFSRP9 = "" ;
                LFSRP0 = "" ;
                LFCLASS01 = "" ;
                LFCLASS02 = "" ;
                LFCLASS03 = "" ;
                LFCLASS04 = "" ;
                LFCLASS05 = "" ;
                LFCLASS06 = "" ;
                LFCLASS07 = "" ;
                LFCLASS08 = "" ;
                LFCLASS09 = "" ;
                LFCLASS10 = "" ;
                LFPRP1 = 0 ;
                LFPRP2 = 0 ;
                LFPRP3 = 0 ;
                LFPRP4 = 0 ;
                LFPRP5 = 0 ;
                LFPRP6 = 0 ;
                LFPRP7 = 0 ;
                LFPRP8 = 0 ;
                LFPRP9 = 0 ;
                LFPRP0 = 0 ;
                LFUSER = "" ;
                LFPID = "" ;
                LFDATE = System.DateTime.Now ;
                LFTIME = DateTime.Now.TimeOfDay ;
        }

        public string LFLNTY { get; set; }
        public string LFLNDS { get; set; }
        public string LFLND2 { get; set; }
        public string LFSRP1 { get; set; }
        public string LFSRP2 { get; set; }
        public string LFSRP3 { get; set; }
        public string LFSRP4 { get; set; }
        public string LFSRP5 { get; set; }
        public string LFSRP6 { get; set; }
        public string LFSRP7 { get; set; }
        public string LFSRP8 { get; set; }
        public string LFSRP9 { get; set; }
        public string LFSRP0 { get; set; }
        public string LFCLASS01 { get; set; }
        public string LFCLASS02 { get; set; }
        public string LFCLASS03 { get; set; }
        public string LFCLASS04 { get; set; }
        public string LFCLASS05 { get; set; }
        public string LFCLASS06 { get; set; }
        public string LFCLASS07 { get; set; }
        public string LFCLASS08 { get; set; }
        public string LFCLASS09 { get; set; }
        public string LFCLASS10 { get; set; }
        public int LFPRP1 { get; set; }
        public int LFPRP2 { get; set; }
        public int LFPRP3 { get; set; }
        public int LFPRP4 { get; set; }
        public int LFPRP5 { get; set; }
        public int LFPRP6 { get; set; }
        public int LFPRP7 { get; set; }
        public int LFPRP8 { get; set; }
        public int LFPRP9 { get; set; }
        public int LFPRP0 { get; set; }
        public string LFUSER { get; set; }
        public string LFPID { get; set; }
        public System.DateTime LFDATE { get; set; }
        public System.TimeSpan LFTIME { get; set; }
    }
}