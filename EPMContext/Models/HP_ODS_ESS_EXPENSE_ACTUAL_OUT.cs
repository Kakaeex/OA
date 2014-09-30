using System;
using System.Collections.Generic;

namespace EPMContext
{
    public partial class HP_ODS_ESS_EXPENSE_ACTUAL_OUT
    {
        public decimal JDE_SORTID { get; set; }
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
        public Nullable<decimal> EMPLOYID { get; set; }
        public Nullable<decimal> LIN { get; set; }
        public Nullable<System.DateTime> DATA_INSERT_TIME { get; set; }
    }
}
