using System;
using System.Collections.Generic;

namespace EPMContext
{
    public partial class PRODDETAIL_ACTUAL_TEMP
    {
        public decimal SORTID { get; set; }
        public string DCT { get; set; }
        public string JDE_BU_ID { get; set; }
        public string JDE_BU_DESC { get; set; }
        public string JDE_ACCOUNT_OBJ { get; set; }
        public string JDE_ACCOUNT_DESC { get; set; }
        public string LITM { get; set; }
        public string JDE_YEAR { get; set; }
        public string JDE_PERIOD { get; set; }
        public string JDE_DATE { get; set; }
        public Nullable<decimal> JDE_COST_DATA { get; set; }
        public Nullable<decimal> JDE_QUANTITY_DATA { get; set; }
        public string LAST_UPDATE_TIME { get; set; }
        public decimal ILUKID { get; set; }
        public string MCU { get; set; }
    }
}
