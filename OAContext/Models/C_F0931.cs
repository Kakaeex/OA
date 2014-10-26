using System;
using System.Collections.Generic;
using DBContextHelper;

namespace OAContext
{
    [Serializable]
    public partial class C_F0931 : ModelBase
    {
        public  C_F0931 ()
        {}

        public  C_F0931 (int i)
        {
                    CDKCOO = "" ;
                CDDOCO = 0 ;
                CDDCTO = "" ;
                CDDLNID = 0 ;
                CDDOC = 0 ;
                CDDCT = "" ;
                CDDSC1 = "" ;
                CDDSC2 = "" ;
                CDMAID = "" ;
                CDMMCU = "" ;
                CDMOBJ = "" ;
                CDMSUB = "" ;
                CDDEL1 = "" ;
                CDFAID = "" ;
                CDFMCU = "" ;
                CDFOBJ = "" ;
                CDFSUB = "" ;
                CDDEL2 = "" ;
                CDTRDJ = System.DateTime.Now ;
                CDDRQJ = System.DateTime.Now ;
                CDPDDJ = System.DateTime.Now ;
                CDADDJ = System.DateTime.Now ;
                CDCNDJ = System.DateTime.Now ;
                CDUPRC = 0 ;
                CDAEXP = 0 ;
                CDUNCS = 0 ;
                CDECST = 0 ;
                CDSOQS = 0 ;
                CDUORG = 0 ;
                CDVR01 = "" ;
                CDVR02 = "" ;
                CDSRP1 = "" ;
                CDSRP2 = "" ;
                CDSRP3 = "" ;
                CDSRP4 = "" ;
                CDSRP5 = "" ;
                CDPRP1 = 0 ;
                CDPRP2 = 0 ;
                CDPRP3 = 0 ;
                CDPRP4 = 0 ;
                CDPRP5 = 0 ;
                CDUSER = "" ;
                CDPID = "" ;
                CDDATE = System.DateTime.Now ;
                CDTIME = DateTime.Now.TimeOfDay ;
        }

        public string CDKCOO { get; set; }
        public int CDDOCO { get; set; }
        public string CDDCTO { get; set; }
        public int CDDLNID { get; set; }
        public int CDDOC { get; set; }
        public string CDDCT { get; set; }
        public string CDDSC1 { get; set; }
        public string CDDSC2 { get; set; }
        public string CDMAID { get; set; }
        public string CDMMCU { get; set; }
        public string CDMOBJ { get; set; }
        public string CDMSUB { get; set; }
        public string CDDEL1 { get; set; }
        public string CDFAID { get; set; }
        public string CDFMCU { get; set; }
        public string CDFOBJ { get; set; }
        public string CDFSUB { get; set; }
        public string CDDEL2 { get; set; }
        public System.DateTime CDTRDJ { get; set; }
        public System.DateTime CDDRQJ { get; set; }
        public System.DateTime CDPDDJ { get; set; }
        public System.DateTime CDADDJ { get; set; }
        public System.DateTime CDCNDJ { get; set; }
        public decimal CDUPRC { get; set; }
        public decimal CDAEXP { get; set; }
        public decimal CDUNCS { get; set; }
        public decimal CDECST { get; set; }
        public decimal CDSOQS { get; set; }
        public decimal CDUORG { get; set; }
        public string CDVR01 { get; set; }
        public string CDVR02 { get; set; }
        public string CDSRP1 { get; set; }
        public string CDSRP2 { get; set; }
        public string CDSRP3 { get; set; }
        public string CDSRP4 { get; set; }
        public string CDSRP5 { get; set; }
        public int CDPRP1 { get; set; }
        public int CDPRP2 { get; set; }
        public int CDPRP3 { get; set; }
        public int CDPRP4 { get; set; }
        public int CDPRP5 { get; set; }
        public string CDUSER { get; set; }
        public string CDPID { get; set; }
        public System.DateTime CDDATE { get; set; }
        public System.TimeSpan CDTIME { get; set; }
    }
}