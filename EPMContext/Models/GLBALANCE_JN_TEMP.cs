using System;
using System.Collections.Generic;

namespace EPMContext
{
    public partial class GLBALANCE_JN_TEMP
    {
        public decimal SORTID { get; set; }
        public string JDE_BU_ID { get; set; }
        public string JDE_BU_DESC { get; set; }
        public string JDE_ACCOUNT_OBJ { get; set; }
        public string JDE_ACCOUNT_SUB { get; set; }
        public string JDE_ACCOUNT_DESC { get; set; }
        public string JDE_SCENARIO { get; set; }
        public string JDE_YEAR { get; set; }
        public string JDE_PERIOD { get; set; }
        public string JDE_DATE { get; set; }
        public string LAST_UPDATE_TIME { get; set; }
        public Nullable<decimal> JDE_DATA { get; set; }
        public string GMAID { get; set; }
        public string SBL { get; set; }
        public string SBLT { get; set; }
        public string GLDCT { get; set; }
        public string GLKCO { get; set; }
        public decimal GLDOC { get; set; }
        public int GLDGJ { get; set; }
        public decimal GLJELN { get; set; }
        public string GLEXTL { get; set; }
    }
}
