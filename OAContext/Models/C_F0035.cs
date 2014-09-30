using System;
using System.Collections.Generic;
using DBContextHelper;

namespace OAContext
{
    public partial class C_F0035 : ModelBase
    {
        public  C_F0035 ()
        {}

        public  C_F0035 (int i)
        {
                MSKCOO =  " " ;
                MSDCTO =  " " ;
                MSCODE =  " " ;
                MSLNGP =  " " ;
                MSDSC1 =  " " ;
                MSDSC2 =  " " ;
                MSSRP1 =  " " ;
                MSSRP2 =  " " ;
                MSSRP3 =  " " ;
                MSSRP4 =  " " ;
                MSSRP5 =  " " ;
                MSPRP1 =  " " ;
                MSPRP2 =  " " ;
                MSPRP3 =  " " ;
                MSPRP4 =  " " ;
                MSPRP5 =  " " ;
                MSUSER =  " " ;
                MSPID =  " " ;
                MSDATE = System.DateTime.Now ;
                MSTIME = System.DateTime.Now.TimeOfDay;
        }

        public string MSKCOO { get; set; }
        public string MSDCTO { get; set; }
        public string MSCODE { get; set; }
        public string MSLNGP { get; set; }
        public string MSDSC1 { get; set; }
        public string MSDSC2 { get; set; }
        public string MSSRP1 { get; set; }
        public string MSSRP2 { get; set; }
        public string MSSRP3 { get; set; }
        public string MSSRP4 { get; set; }
        public string MSSRP5 { get; set; }
        public string MSPRP1 { get; set; }
        public string MSPRP2 { get; set; }
        public string MSPRP3 { get; set; }
        public string MSPRP4 { get; set; }
        public string MSPRP5 { get; set; }
        public string MSUSER { get; set; }
        public string MSPID { get; set; }
        public Nullable<System.DateTime> MSDATE { get; set; }
        public Nullable<System.TimeSpan> MSTIME { get; set; }
    }
}