using System;
using System.Collections.Generic;

namespace EPMContext
{
    public partial class V_HP_BUD_ENTITY
    {
        public decimal OBJECT_ID { get; set; }
        public string ENTITY_CODE { get; set; }
        public string ENTITY_NAME { get; set; }
        public string PARENT_ID { get; set; }
        public Nullable<decimal> HAS_CHILDREN { get; set; }
        public string ENTITY_PARENT { get; set; }
    }
}
