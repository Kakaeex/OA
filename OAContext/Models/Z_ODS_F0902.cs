using System;
using System.Collections.Generic;
using DBContextHelper;

namespace OAContext
{
    [Serializable]
    public partial class Z_ODS_F0902 : ModelBase
    {
        public  Z_ODS_F0902 ()
        {}

        public  Z_ODS_F0902 (int i)
        {
                    DOCO = 0 ;
                OU_ID = "" ;
                BU_ID = "" ;
                ACCOUNT_OBJ = "" ;
                ACCOUNT_SUB = "" ;
                YEAR_ID = "" ;
                PERIOD = "" ;
                LT = "" ;
                FY = 0 ;
                YEAR = 0 ;
                BUDGET_DATA = 0 ;
                ACTUAL_DATA = 0 ;
                APPLY_DATA = 0 ;
                STATUS = "" ;
        }

        public int DOCO { get; set; }
        public string OU_ID { get; set; }
        public string BU_ID { get; set; }
        public string ACCOUNT_OBJ { get; set; }
        public string ACCOUNT_SUB { get; set; }
        public string YEAR_ID { get; set; }
        public string PERIOD { get; set; }
        public string LT { get; set; }
        public Nullable<int> FY { get; set; }
        public Nullable<int> YEAR { get; set; }
        public Nullable<decimal> BUDGET_DATA { get; set; }
        public Nullable<decimal> ACTUAL_DATA { get; set; }
        public Nullable<decimal> APPLY_DATA { get; set; }
        public string STATUS { get; set; }
    }
}