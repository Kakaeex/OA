using System;
using System.Collections.Generic;

namespace EPMContext
{
    public partial class V_HP_BUD_ACCOUNT
    {
        public decimal OBJECT_ID { get; set; }
        public string ACCOUNT_ID { get; set; }
        public string ACCOUNT_NAME { get; set; }
        public string PARENT_ID { get; set; }
        public Nullable<decimal> HAS_CHILDREN { get; set; }
        public string ACCOUNT_PARENT { get; set; }
    }
}
