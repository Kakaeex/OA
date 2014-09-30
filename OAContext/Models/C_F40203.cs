using System;
using System.Collections.Generic;
using DBContextHelper;

namespace OAContext
{
    public partial class C_F40203 : ModelBase
    {
        public  C_F40203 ()
        {}

        public  C_F40203 (int i)
        {
                    FSDCTO =  " " ;
                FSTRTY =  " " ;
                FSDEL1 =  " " ;
                FSDEL2 =  " " ;
                FSLNTY =  " " ;
                FSLNDS =  " " ;
                FSLND2 =  " " ;
                FSNXTR =  " " ;
                FSA1TR =  " " ;
                FSA2TR =  " " ;
                FSA3TR =  " " ;
                FSA4TR =  " " ;
                FSA5TR =  " " ;
                FSWRTH =  " " ;
                FSORNN = 0 ;
                FSUSER =  " " ;
                FSPID =  " " ;
                FSDATE = System.DateTime.Now ;
                FSTIME = DateTime.Now.TimeOfDay ;
        }

        public string FSDCTO { get; set; }
        public string FSTRTY { get; set; }
        public string FSDEL1 { get; set; }
        public string FSDEL2 { get; set; }
        public string FSLNTY { get; set; }
        public string FSLNDS { get; set; }
        public string FSLND2 { get; set; }
        public string FSNXTR { get; set; }
        public string FSA1TR { get; set; }
        public string FSA2TR { get; set; }
        public string FSA3TR { get; set; }
        public string FSA4TR { get; set; }
        public string FSA5TR { get; set; }
        public string FSWRTH { get; set; }
        public Nullable<int> FSORNN { get; set; }
        public string FSUSER { get; set; }
        public string FSPID { get; set; }
        public System.DateTime FSDATE { get; set; }
        public System.TimeSpan FSTIME { get; set; }
    }
}