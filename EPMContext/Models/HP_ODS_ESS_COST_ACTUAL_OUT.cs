using System;
using System.Collections.Generic;

namespace EPMContext
{
    public partial class HP_ODS_ESS_COST_ACTUAL_OUT
    {
        public decimal SORTID { get; set; }
        public string JDE_BU_ID { get; set; }
        public string JDE_ACCOUNT_OBJ { get; set; }
        public string JDE_ACCOUNT_SUB { get; set; }
        public string JDE_SCENARIO { get; set; }
        public string JDE_YEAR { get; set; }
        public string JDE_PERIOD { get; set; }
        public string JDE_DATE { get; set; }
        public string LAST_UPDATE_TIME { get; set; }
        public Nullable<decimal> JDE_DATA { get; set; }
        public string GMAID { get; set; }
        public string GLDCT { get; set; }
        public Nullable<System.DateTime> DATA_INSERT_TIME { get; set; }
    }
}
