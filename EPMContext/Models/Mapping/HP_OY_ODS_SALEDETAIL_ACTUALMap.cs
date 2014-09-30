using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EPMContext
{
    public class HP_OY_ODS_SALEDETAIL_ACTUALMap : EntityTypeConfiguration<HP_OY_ODS_SALEDETAIL_ACTUAL>
    {
        public HP_OY_ODS_SALEDETAIL_ACTUALMap()
        {
            // Primary Key
            this.HasKey(t => new { t.KCOO, t.DOCO, t.LNID, t.DCTO });

            // Properties
            this.Property(t => t.JDE_BU_ID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.JDE_BU_DESC)
                .HasMaxLength(200);

            this.Property(t => t.JDE_ACCOUNT_OBJ)
                .HasMaxLength(50);

            this.Property(t => t.JDE_ACCOUNT_DESC)
                .HasMaxLength(200);

            this.Property(t => t.JDE_BRAND_ID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.JDE_MODEL_ID)
                .HasMaxLength(50);

            this.Property(t => t.JDE_SPEC_ID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.JDE_SPEC_DESC)
                .HasMaxLength(50);

            this.Property(t => t.JDE_YEAR)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.JDE_PERIOD)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.JDE_DATE)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATE_TIME)
                .HasMaxLength(50);

            this.Property(t => t.KCOO)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.DOCO)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.LNID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.DCTO)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.LITM)
                .HasMaxLength(100);

            this.Property(t => t.AN8)
                .HasMaxLength(50);

            this.Property(t => t.AN8_DESC)
                .HasMaxLength(200);

            this.Property(t => t.NXTR)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("HP_OY_ODS_SALEDETAIL_ACTUAL", "EPM_ODS");
            this.Property(t => t.SORTID).HasColumnName("SORTID");
            this.Property(t => t.JDE_BU_ID).HasColumnName("JDE_BU_ID");
            this.Property(t => t.JDE_BU_DESC).HasColumnName("JDE_BU_DESC");
            this.Property(t => t.JDE_ACCOUNT_OBJ).HasColumnName("JDE_ACCOUNT_OBJ");
            this.Property(t => t.JDE_ACCOUNT_DESC).HasColumnName("JDE_ACCOUNT_DESC");
            this.Property(t => t.JDE_BRAND_ID).HasColumnName("JDE_BRAND_ID");
            this.Property(t => t.JDE_MODEL_ID).HasColumnName("JDE_MODEL_ID");
            this.Property(t => t.JDE_SPEC_ID).HasColumnName("JDE_SPEC_ID");
            this.Property(t => t.JDE_SPEC_DESC).HasColumnName("JDE_SPEC_DESC");
            this.Property(t => t.JDE_YEAR).HasColumnName("JDE_YEAR");
            this.Property(t => t.JDE_PERIOD).HasColumnName("JDE_PERIOD");
            this.Property(t => t.JDE_DATE).HasColumnName("JDE_DATE");
            this.Property(t => t.JDE_REVENUE_DATA).HasColumnName("JDE_REVENUE_DATA");
            this.Property(t => t.JDE_COST_DATA).HasColumnName("JDE_COST_DATA");
            this.Property(t => t.JDE_QUANTITY_DATA).HasColumnName("JDE_QUANTITY_DATA");
            this.Property(t => t.LAST_UPDATE_TIME).HasColumnName("LAST_UPDATE_TIME");
            this.Property(t => t.KCOO).HasColumnName("KCOO");
            this.Property(t => t.DOCO).HasColumnName("DOCO");
            this.Property(t => t.LNID).HasColumnName("LNID");
            this.Property(t => t.DCTO).HasColumnName("DCTO");
            this.Property(t => t.LITM).HasColumnName("LITM");
            this.Property(t => t.AN8).HasColumnName("AN8");
            this.Property(t => t.AN8_DESC).HasColumnName("AN8_DESC");
            this.Property(t => t.NXTR).HasColumnName("NXTR");
        }
    }
}
