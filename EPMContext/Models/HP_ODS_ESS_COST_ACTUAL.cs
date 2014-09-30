using System;
using System.Collections.Generic;

namespace EPMContext
{
    public partial class HP_ODS_ESS_COST_ACTUAL
    {
        public decimal JDE_SORTID { get; set; }
        public string HP_ENTITY { get; set; }
        public string HP_ACCOUNT { get; set; }
        public string HP_YEAR { get; set; }
        public string HP_PERIOD { get; set; }
        public string HP_CURRENCY { get; set; }
        public string HP_DETAIL { get; set; }
        public string HP_MODEL { get; set; }
        public string HP_PROJECT { get; set; }
        public string HP_SCENARIO { get; set; }
        public string HP_VERSION { get; set; }
        public Nullable<decimal> HP_DATA { get; set; }
        public string JDE_UPDATE_TIME { get; set; }
        public Nullable<System.DateTime> DATA_INSERT_TIME { get; set; }
        public string GLDCT { get; set; }
    }
}
