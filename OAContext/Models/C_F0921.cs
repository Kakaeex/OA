using System;
using System.Collections.Generic;
using DBContextHelper;

namespace OAContext
{
    [Serializable]
    public partial class C_F0921 : ModelBase
    {
        public  C_F0921 ()
        {}

        public  C_F0921 (int i)
        {
                    FDDOCO = 0 ;
                FDDCTO = "" ;
                FDLNID = 0 ;
                FDKCOO = "" ;
                FDMCU = "" ;
                FDAID = "" ;
                FDOBJ = "" ;
                FDSUB = "" ;
                FDYAER = 0 ;
                FDEFTJ = System.DateTime.Now ;
                FDEDXJ = System.DateTime.Now ;
                FDNAME = "" ;
                FDDSC1 = "" ;
                FDDSC2 = "" ;
                FDUPRC = 0 ;
                FDAPYN = 0 ;
                FDAWTD = 0 ;
                FDLTTR = "" ;
                FDNXTR = "" ;
                FDSRP1 = "" ;
                FDSRP2 = "" ;
                FDSRP3 = "" ;
                FDSRP4 = "" ;
                FDSRP5 = "" ;
                FDPRP1 = 0 ;
                FDPRP2 = 0 ;
                FDPRP3 = 0 ;
                FDPRP4 = 0 ;
                FDPRP5 = 0 ;
                FDTROG = "" ;
                FDUSER = "" ;
                FDPID = "" ;
                FDDATE = System.DateTime.Now ;
                FDTIME = DateTime.Now.TimeOfDay ;
        }

        public int FDDOCO { get; set; }
        public string FDDCTO { get; set; }
        public int FDLNID { get; set; }
        public string FDKCOO { get; set; }
        public string FDMCU { get; set; }
        public string FDAID { get; set; }
        public string FDOBJ { get; set; }
        public string FDSUB { get; set; }
        public int FDYAER { get; set; }
        public System.DateTime FDEFTJ { get; set; }
        public System.DateTime FDEDXJ { get; set; }
        public string FDNAME { get; set; }
        public string FDDSC1 { get; set; }
        public string FDDSC2 { get; set; }
        public decimal FDUPRC { get; set; }
        public decimal FDAPYN { get; set; }
        public decimal FDAWTD { get; set; }
        public string FDLTTR { get; set; }
        public string FDNXTR { get; set; }
        public string FDSRP1 { get; set; }
        public string FDSRP2 { get; set; }
        public string FDSRP3 { get; set; }
        public string FDSRP4 { get; set; }
        public string FDSRP5 { get; set; }
        public int FDPRP1 { get; set; }
        public int FDPRP2 { get; set; }
        public int FDPRP3 { get; set; }
        public int FDPRP4 { get; set; }
        public int FDPRP5 { get; set; }
        public string FDTROG { get; set; }
        public string FDUSER { get; set; }
        public string FDPID { get; set; }
        public System.DateTime FDDATE { get; set; }
        public System.TimeSpan FDTIME { get; set; }
    }
}