using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace OAContext
{
    public class Z_ODS_F0902Map : EntityTypeConfiguration<Z_ODS_F0902>
    {
        public Z_ODS_F0902Map()
        {
            // Primary Key
            this.HasKey(t => new { t.DOCO, t.OU_ID, t.BU_ID, t.ACCOUNT_OBJ, t.ACCOUNT_SUB, t.YEAR_ID, t.PERIOD, t.LT });

            // Properties
            this.Property(t => t.DOCO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.OU_ID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.BU_ID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ACCOUNT_OBJ)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ACCOUNT_SUB)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.YEAR_ID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PERIOD)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.LT)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.STATUS)
                .HasMaxLength(5);

            // Table & Column Mappings
            this.ToTable("Z_ODS_F0902");
            this.Property(t => t.DOCO).HasColumnName("DOCO");
            this.Property(t => t.OU_ID).HasColumnName("OU_ID");
            this.Property(t => t.BU_ID).HasColumnName("BU_ID");
            this.Property(t => t.ACCOUNT_OBJ).HasColumnName("ACCOUNT_OBJ");
            this.Property(t => t.ACCOUNT_SUB).HasColumnName("ACCOUNT_SUB");
            this.Property(t => t.YEAR_ID).HasColumnName("YEAR_ID");
            this.Property(t => t.PERIOD).HasColumnName("PERIOD");
            this.Property(t => t.LT).HasColumnName("LT");
            this.Property(t => t.FY).HasColumnName("FY");
            this.Property(t => t.YEAR).HasColumnName("YEAR");
            this.Property(t => t.BUDGET_DATA).HasColumnName("BUDGET_DATA");
            this.Property(t => t.ACTUAL_DATA).HasColumnName("ACTUAL_DATA");
            this.Property(t => t.APPLY_DATA).HasColumnName("APPLY_DATA");
            this.Property(t => t.STATUS).HasColumnName("STATUS");
        }
    }
}
