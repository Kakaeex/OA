using System;
using System.Collections.Generic;

namespace EPMContext
{
    public partial class EXPENSE_ACTUAL_TEMP
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
        public string NXTR { get; set; }
        public string EXRPTDES { get; set; }
        public string EXRPTTYP { get; set; }
        public string EXRPTNUM { get; set; }
        public decimal EMPLOYID { get; set; }
        public decimal LIN { get; set; }
    }
}
