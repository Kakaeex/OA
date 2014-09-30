using System;
using System.Collections.Generic;

namespace EPMContext
{
    public partial class HP_ODS_ESS_LEND_ACTUAL_OUT
    {
        public decimal SORTID { get; set; }
        public string JDE_BU_ID { get; set; }
        public string JDE_BU_DESC { get; set; }
        public string JDE_ACCOUNT_ID { get; set; }
        public string JDE_ACCOUNT_DESC { get; set; }
        public string JDE_YEAR { get; set; }
        public string JDE_PERIOD { get; set; }
        public string JDE_DATE { get; set; }
        public Nullable<decimal> JDE_DATA { get; set; }
        public string LAST_UPDATE_TIME { get; set; }
        public string EHEXRPTTYP { get; set; }
        public string EHEXRPTNUM { get; set; }
        public decimal EHEMPLOYID { get; set; }
        public string EHEXRPTSTA { get; set; }
        public Nullable<decimal> RPAG { get; set; }
        public Nullable<decimal> RPAAP { get; set; }
        public decimal LIN { get; set; }
        public string RPKCO { get; set; }
        public decimal RPDOC { get; set; }
        public string RPDCT { get; set; }
        public string RPSFX { get; set; }
        public decimal RPSFXE { get; set; }
        public string EXRPTDES { get; set; }
        public Nullable<System.DateTime> DATA_INSERT_TIME { get; set; }
    }
}
