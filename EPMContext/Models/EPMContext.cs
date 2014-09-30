using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace EPMContext
{
    public partial class epmContext : DbContext
    {
        static epmContext()
        {
            Database.SetInitializer<epmContext>(null);
        }

        public epmContext()
            : base("EPM")
        {
        }

        public DbSet<ACCOUNT_ACTUAL_TEMP> ACCOUNT_ACTUAL_TEMP { get; set; }
        public DbSet<EXPENSE_ACTUAL_TEMP> EXPENSE_ACTUAL_TEMP { get; set; }
        public DbSet<F0005> F0005 { get; set; }
        public DbSet<F0005_TEMP> F0005_TEMP { get; set; }
        public DbSet<F0911Z1_TEMP> F0911Z1_TEMP { get; set; }
        public DbSet<GLBALANCE_ACTUAL_TEMP> GLBALANCE_ACTUAL_TEMP { get; set; }
        public DbSet<GLBALANCE_JN_TEMP> GLBALANCE_JN_TEMP { get; set; }
        public DbSet<HP_ACCOUNT_MAP> HP_ACCOUNT_MAP { get; set; }
        public DbSet<HP_DIMENSION_NON_MAP> HP_DIMENSION_NON_MAP { get; set; }
        public DbSet<HP_ESS_ODS_BUDEXP_AIDMAP> HP_ESS_ODS_BUDEXP_AIDMAP { get; set; }
        public DbSet<HP_ESS_ODS_BUDEXP_OA> HP_ESS_ODS_BUDEXP_OA { get; set; }
        public DbSet<HP_ESS_ODS_EXPENSE_BUDGET> HP_ESS_ODS_EXPENSE_BUDGET { get; set; }
        public DbSet<HP_ESS_ODS_MODEL_BUDGET> HP_ESS_ODS_MODEL_BUDGET { get; set; }
        public DbSet<HP_MODEL_MAP> HP_MODEL_MAP { get; set; }
        public DbSet<HP_ODS_ESS_COST_ACTUAL> HP_ODS_ESS_COST_ACTUAL { get; set; }
        public DbSet<HP_ODS_ESS_COST_ACTUAL_OUT> HP_ODS_ESS_COST_ACTUAL_OUT { get; set; }
        public DbSet<HP_ODS_ESS_EXPENSE_ACTUAL> HP_ODS_ESS_EXPENSE_ACTUAL { get; set; }
        public DbSet<HP_ODS_ESS_EXPENSE_ACTUAL_OUT> HP_ODS_ESS_EXPENSE_ACTUAL_OUT { get; set; }
        public DbSet<HP_ODS_ESS_GLBALANCE_ACT_OUT> HP_ODS_ESS_GLBALANCE_ACT_OUT { get; set; }
        public DbSet<HP_ODS_ESS_GLBALANCE_ACTUAL> HP_ODS_ESS_GLBALANCE_ACTUAL { get; set; }
        public DbSet<HP_ODS_ESS_LEND_ACTUAL> HP_ODS_ESS_LEND_ACTUAL { get; set; }
        public DbSet<HP_ODS_ESS_LEND_ACTUAL_OUT> HP_ODS_ESS_LEND_ACTUAL_OUT { get; set; }
        public DbSet<HP_ODS_ESS_PROD_ACTUAL> HP_ODS_ESS_PROD_ACTUAL { get; set; }
        public DbSet<HP_ODS_ESS_PROD_ACTUAL_OUT> HP_ODS_ESS_PROD_ACTUAL_OUT { get; set; }
        public DbSet<HP_ODS_ESS_PROD_MODEL> HP_ODS_ESS_PROD_MODEL { get; set; }
        public DbSet<HP_ODS_ESS_SALEVOL_ACTUAL> HP_ODS_ESS_SALEVOL_ACTUAL { get; set; }
        public DbSet<HP_ODS_ESS_SALEVOL_MODEL> HP_ODS_ESS_SALEVOL_MODEL { get; set; }
        public DbSet<HP_OY_ODS_ACCOUNT_ACTUAL> HP_OY_ODS_ACCOUNT_ACTUAL { get; set; }
        public DbSet<HP_OY_ODS_EXPENSE_ACTUAL> HP_OY_ODS_EXPENSE_ACTUAL { get; set; }
        public DbSet<HP_OY_ODS_GLBALANCE_ACTUAL> HP_OY_ODS_GLBALANCE_ACTUAL { get; set; }
        public DbSet<HP_OY_ODS_GLBALANCE_JN> HP_OY_ODS_GLBALANCE_JN { get; set; }
        public DbSet<HP_OY_ODS_LEND_ACTUAL> HP_OY_ODS_LEND_ACTUAL { get; set; }
        public DbSet<HP_OY_ODS_PRODDETAIL_ACTUAL> HP_OY_ODS_PRODDETAIL_ACTUAL { get; set; }
        public DbSet<HP_OY_ODS_PRODUCT_ACTUAL> HP_OY_ODS_PRODUCT_ACTUAL { get; set; }
        public DbSet<HP_OY_ODS_SALEDETAIL_ACTUAL> HP_OY_ODS_SALEDETAIL_ACTUAL { get; set; }
        public DbSet<HP_OY_ODS_UNITCOST_ACTUAL> HP_OY_ODS_UNITCOST_ACTUAL { get; set; }
        public DbSet<HP_PERIOD_MAP> HP_PERIOD_MAP { get; set; }
        public DbSet<HP_PLN_ODS_MODEL_TEXT> HP_PLN_ODS_MODEL_TEXT { get; set; }
        public DbSet<HP_SPEC_MAP> HP_SPEC_MAP { get; set; }
        public DbSet<LEND_ACTUAL_TEMP> LEND_ACTUAL_TEMP { get; set; }
        public DbSet<PRODDETAIL_ACTUAL_TEMP> PRODDETAIL_ACTUAL_TEMP { get; set; }
        public DbSet<PRODUCT_ACTUAL_TEMP> PRODUCT_ACTUAL_TEMP { get; set; }
        public DbSet<SALEDETAIL_ACTUAL_TEMP> SALEDETAIL_ACTUAL_TEMP { get; set; }
        public DbSet<UNITCOST_ACTUAL_TEMP> UNITCOST_ACTUAL_TEMP { get; set; }
        public DbSet<HP_ENTITY_MAP> HP_ENTITY_MAP { get; set; }
        public DbSet<V_BUDEXP_AID_NONMAP> V_BUDEXP_AID_NONMAP { get; set; }
        public DbSet<V_F0911Z1_TEMP> V_F0911Z1_TEMP { get; set; }
        public DbSet<V_HP_BUD_ACCOUNT> V_HP_BUD_ACCOUNT { get; set; }
        public DbSet<V_HP_BUD_ENTITY> V_HP_BUD_ENTITY { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ACCOUNT_ACTUAL_TEMPMap());
            modelBuilder.Configurations.Add(new EXPENSE_ACTUAL_TEMPMap());
            modelBuilder.Configurations.Add(new F0005Map());
            modelBuilder.Configurations.Add(new F0005_TEMPMap());
            modelBuilder.Configurations.Add(new F0911Z1_TEMPMap());
            modelBuilder.Configurations.Add(new GLBALANCE_ACTUAL_TEMPMap());
            modelBuilder.Configurations.Add(new GLBALANCE_JN_TEMPMap());
            modelBuilder.Configurations.Add(new HP_ACCOUNT_MAPMap());
            modelBuilder.Configurations.Add(new HP_DIMENSION_NON_MAPMap());
            modelBuilder.Configurations.Add(new HP_ESS_ODS_BUDEXP_AIDMAPMap());
            modelBuilder.Configurations.Add(new HP_ESS_ODS_BUDEXP_OAMap());
            modelBuilder.Configurations.Add(new HP_ESS_ODS_EXPENSE_BUDGETMap());
            modelBuilder.Configurations.Add(new HP_ESS_ODS_MODEL_BUDGETMap());
            modelBuilder.Configurations.Add(new HP_MODEL_MAPMap());
            modelBuilder.Configurations.Add(new HP_ODS_ESS_COST_ACTUALMap());
            modelBuilder.Configurations.Add(new HP_ODS_ESS_COST_ACTUAL_OUTMap());
            modelBuilder.Configurations.Add(new HP_ODS_ESS_EXPENSE_ACTUALMap());
            modelBuilder.Configurations.Add(new HP_ODS_ESS_EXPENSE_ACTUAL_OUTMap());
            modelBuilder.Configurations.Add(new HP_ODS_ESS_GLBALANCE_ACT_OUTMap());
            modelBuilder.Configurations.Add(new HP_ODS_ESS_GLBALANCE_ACTUALMap());
            modelBuilder.Configurations.Add(new HP_ODS_ESS_LEND_ACTUALMap());
            modelBuilder.Configurations.Add(new HP_ODS_ESS_LEND_ACTUAL_OUTMap());
            modelBuilder.Configurations.Add(new HP_ODS_ESS_PROD_ACTUALMap());
            modelBuilder.Configurations.Add(new HP_ODS_ESS_PROD_ACTUAL_OUTMap());
            modelBuilder.Configurations.Add(new HP_ODS_ESS_PROD_MODELMap());
            modelBuilder.Configurations.Add(new HP_ODS_ESS_SALEVOL_ACTUALMap());
            modelBuilder.Configurations.Add(new HP_ODS_ESS_SALEVOL_MODELMap());
            modelBuilder.Configurations.Add(new HP_OY_ODS_ACCOUNT_ACTUALMap());
            modelBuilder.Configurations.Add(new HP_OY_ODS_EXPENSE_ACTUALMap());
            modelBuilder.Configurations.Add(new HP_OY_ODS_GLBALANCE_ACTUALMap());
            modelBuilder.Configurations.Add(new HP_OY_ODS_GLBALANCE_JNMap());
            modelBuilder.Configurations.Add(new HP_OY_ODS_LEND_ACTUALMap());
            modelBuilder.Configurations.Add(new HP_OY_ODS_PRODDETAIL_ACTUALMap());
            modelBuilder.Configurations.Add(new HP_OY_ODS_PRODUCT_ACTUALMap());
            modelBuilder.Configurations.Add(new HP_OY_ODS_SALEDETAIL_ACTUALMap());
            modelBuilder.Configurations.Add(new HP_OY_ODS_UNITCOST_ACTUALMap());
            modelBuilder.Configurations.Add(new HP_PERIOD_MAPMap());
            modelBuilder.Configurations.Add(new HP_PLN_ODS_MODEL_TEXTMap());
            modelBuilder.Configurations.Add(new HP_SPEC_MAPMap());
            modelBuilder.Configurations.Add(new LEND_ACTUAL_TEMPMap());
            modelBuilder.Configurations.Add(new PRODDETAIL_ACTUAL_TEMPMap());
            modelBuilder.Configurations.Add(new PRODUCT_ACTUAL_TEMPMap());
            modelBuilder.Configurations.Add(new SALEDETAIL_ACTUAL_TEMPMap());
            modelBuilder.Configurations.Add(new UNITCOST_ACTUAL_TEMPMap());
            modelBuilder.Configurations.Add(new HP_ENTITY_MAPMap());
            modelBuilder.Configurations.Add(new V_BUDEXP_AID_NONMAPMap());
            modelBuilder.Configurations.Add(new V_F0911Z1_TEMPMap());
            modelBuilder.Configurations.Add(new V_HP_BUD_ACCOUNTMap());
            modelBuilder.Configurations.Add(new V_HP_BUD_ENTITYMap());
        }
    }
}
