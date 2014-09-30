using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EPMContext
{
    public class HP_ODS_ESS_COST_ACTUAL_OUTMap : EntityTypeConfiguration<HP_ODS_ESS_COST_ACTUAL_OUT>
    {
        public HP_ODS_ESS_COST_ACTUAL_OUTMap()
        {
            // Primary Key
            this.HasKey(t => new { t.SORTID, t.JDE_BU_ID, t.JDE_ACCOUNT_OBJ, t.JDE_ACCOUNT_SUB, t.JDE_SCENARIO, t.JDE_YEAR, t.JDE_PERIOD, t.JDE_DATE, t.GMAID, t.GLDCT });

            // Properties
            this.Property(t => t.SORTID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.JDE_BU_ID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.JDE_ACCOUNT_OBJ)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.JDE_ACCOUNT_SUB)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.JDE_SCENARIO)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.JDE_YEAR)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.JDE_PERIOD)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.JDE_DATE)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATE_TIME)
                .HasMaxLength(50);

            this.Property(t => t.GMAID)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.GLDCT)
                .IsRequired()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("HP_ODS_ESS_COST_ACTUAL_OUT", "EPM_ODS");
            this.Property(t => t.SORTID).HasColumnName("SORTID");
            this.Property(t => t.JDE_BU_ID).HasColumnName("JDE_BU_ID");
            this.Property(t => t.JDE_ACCOUNT_OBJ).HasColumnName("JDE_ACCOUNT_OBJ");
            this.Property(t => t.JDE_ACCOUNT_SUB).HasColumnName("JDE_ACCOUNT_SUB");
            this.Property(t => t.JDE_SCENARIO).HasColumnName("JDE_SCENARIO");
            this.Property(t => t.JDE_YEAR).HasColumnName("JDE_YEAR");
            this.Property(t => t.JDE_PERIOD).HasColumnName("JDE_PERIOD");
            this.Property(t => t.JDE_DATE).HasColumnName("JDE_DATE");
            this.Property(t => t.LAST_UPDATE_TIME).HasColumnName("LAST_UPDATE_TIME");
            this.Property(t => t.JDE_DATA).HasColumnName("JDE_DATA");
            this.Property(t => t.GMAID).HasColumnName("GMAID");
            this.Property(t => t.GLDCT).HasColumnName("GLDCT");
            this.Property(t => t.DATA_INSERT_TIME).HasColumnName("DATA_INSERT_TIME");
        }
    }
}
