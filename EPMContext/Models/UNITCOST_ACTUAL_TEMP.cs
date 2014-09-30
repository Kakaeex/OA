using System;
using System.Collections.Generic;

namespace EPMContext
{
    public partial class UNITCOST_ACTUAL_TEMP
    {
        public decimal SORTID { get; set; }
        public string LEDG { get; set; }
        public string JDE_BU_ID { get; set; }
        public string JDE_BU_DESC { get; set; }
        public string JDE_ACCOUNT_OBJ { get; set; }
        public string JDE_ACCOUNT_DESC { get; set; }
        public string LITM { get; set; }
        public Nullable<decimal> JDE_COST_DATA { get; set; }
        public string LAST_UPDATE_TIME { get; set; }
        public string COCSIN { get; set; }
        public string GMCO { get; set; }
        public string COLOCN { get; set; }
        public string COLOTN { get; set; }
        public decimal ITM { get; set; }
    }
}
