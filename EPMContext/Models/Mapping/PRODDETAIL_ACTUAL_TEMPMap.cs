using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EPMContext
{
    public class PRODDETAIL_ACTUAL_TEMPMap : EntityTypeConfiguration<PRODDETAIL_ACTUAL_TEMP>
    {
        public PRODDETAIL_ACTUAL_TEMPMap()
        {
            // Primary Key
            this.HasKey(t => t.ILUKID);

            // Properties
            this.Property(t => t.DCT)
                .HasMaxLength(50);

            this.Property(t => t.JDE_BU_ID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.JDE_BU_DESC)
                .HasMaxLength(200);

            this.Property(t => t.JDE_ACCOUNT_OBJ)
                .HasMaxLength(50);

            this.Property(t => t.JDE_ACCOUNT_DESC)
                .HasMaxLength(200);

            this.Property(t => t.LITM)
                .IsRequired()
                .HasMaxLength(100);

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

            this.Property(t => t.ILUKID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.MCU)
                .HasMaxLength(12);

            // Table & Column Mappings
            this.ToTable("PRODDETAIL_ACTUAL_TEMP", "EPM_ODS");
            this.Property(t => t.SORTID).HasColumnName("SORTID");
            this.Property(t => t.DCT).HasColumnName("DCT");
            this.Property(t => t.JDE_BU_ID).HasColumnName("JDE_BU_ID");
            this.Property(t => t.JDE_BU_DESC).HasColumnName("JDE_BU_DESC");
            this.Property(t => t.JDE_ACCOUNT_OBJ).HasColumnName("JDE_ACCOUNT_OBJ");
            this.Property(t => t.JDE_ACCOUNT_DESC).HasColumnName("JDE_ACCOUNT_DESC");
            this.Property(t => t.LITM).HasColumnName("LITM");
            this.Property(t => t.JDE_YEAR).HasColumnName("JDE_YEAR");
            this.Property(t => t.JDE_PERIOD).HasColumnName("JDE_PERIOD");
            this.Property(t => t.JDE_DATE).HasColumnName("JDE_DATE");
            this.Property(t => t.JDE_COST_DATA).HasColumnName("JDE_COST_DATA");
            this.Property(t => t.JDE_QUANTITY_DATA).HasColumnName("JDE_QUANTITY_DATA");
            this.Property(t => t.LAST_UPDATE_TIME).HasColumnName("LAST_UPDATE_TIME");
            this.Property(t => t.ILUKID).HasColumnName("ILUKID");
            this.Property(t => t.MCU).HasColumnName("MCU");
        }
    }
}
