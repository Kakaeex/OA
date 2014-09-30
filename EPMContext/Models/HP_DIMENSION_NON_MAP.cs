using System;
using System.Collections.Generic;

namespace EPMContext
{
    public partial class HP_DIMENSION_NON_MAP
    {
        public string CATEGORY_ID { get; set; }
        public string CATEGORY_DESC { get; set; }
        public string SOURCE_ID { get; set; }
        public string SOURCE_DESC { get; set; }
        public string JDE_DIMENSION_ID { get; set; }
        public string JDE_DIMENSION_DESC { get; set; }
        public string JDE_YEAR { get; set; }
        public string JDE_PERIOD { get; set; }
        public Nullable<System.DateTime> INSERT_DATE { get; set; }
    }
}
