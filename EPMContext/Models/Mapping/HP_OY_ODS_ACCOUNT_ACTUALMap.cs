using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EPMContext
{
    public class HP_OY_ODS_ACCOUNT_ACTUALMap : EntityTypeConfiguration<HP_OY_ODS_ACCOUNT_ACTUAL>
    {
        public HP_OY_ODS_ACCOUNT_ACTUALMap()
        {
            // Primary Key
            this.HasKey(t => t.VNAID);

            // Properties
            this.Property(t => t.JDE_ACCOUNT_MCU)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.JDE_ACCOUNT_OBJ)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.JDE_ACCOUNT_SUB)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.JDE_ACCOUNT_DESC)
                .HasMaxLength(200);

            this.Property(t => t.JDE_ACCOUNT_ATTR_ID)
                .HasMaxLength(50);

            this.Property(t => t.JDE_ACCOUNT_ATTR_DESC)
                .HasMaxLength(50);

            this.Property(t => t.JDE_DATE)
                .HasMaxLength(50);

            this.Property(t => t.LAST_UPDATE_TIME)
                .HasMaxLength(50);

            this.Property(t => t.JDE_BS_ID)
                .HasMaxLength(50);

            this.Property(t => t.JDE_BS_DESC)
                .HasMaxLength(200);

            this.Property(t => t.JDE_CF_ID)
                .HasMaxLength(50);

            this.Property(t => t.JDE_CF_DESC)
                .HasMaxLength(200);

            this.Property(t => t.VNAID)
                .IsRequired()
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("HP_OY_ODS_ACCOUNT_ACTUAL", "EPM_ODS");
            this.Property(t => t.SORTID).HasColumnName("SORTID");
            this.Property(t => t.JDE_ACCOUNT_MCU).HasColumnName("JDE_ACCOUNT_MCU");
            this.Property(t => t.JDE_ACCOUNT_OBJ).HasColumnName("JDE_ACCOUNT_OBJ");
            this.Property(t => t.JDE_ACCOUNT_SUB).HasColumnName("JDE_ACCOUNT_SUB");
            this.Property(t => t.JDE_ACCOUNT_DESC).HasColumnName("JDE_ACCOUNT_DESC");
            this.Property(t => t.JDE_ACCOUNT_ATTR_ID).HasColumnName("JDE_ACCOUNT_ATTR_ID");
            this.Property(t => t.JDE_ACCOUNT_ATTR_DESC).HasColumnName("JDE_ACCOUNT_ATTR_DESC");
            this.Property(t => t.JDE_DATE).HasColumnName("JDE_DATE");
            this.Property(t => t.LAST_UPDATE_TIME).HasColumnName("LAST_UPDATE_TIME");
            this.Property(t => t.JDE_BS_ID).HasColumnName("JDE_BS_ID");
            this.Property(t => t.JDE_BS_DESC).HasColumnName("JDE_BS_DESC");
            this.Property(t => t.JDE_CF_ID).HasColumnName("JDE_CF_ID");
            this.Property(t => t.JDE_CF_DESC).HasColumnName("JDE_CF_DESC");
            this.Property(t => t.VNAID).HasColumnName("VNAID");
        }
    }
}
