using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EPMContext
{
    public class HP_DIMENSION_NON_MAPMap : EntityTypeConfiguration<HP_DIMENSION_NON_MAP>
    {
        public HP_DIMENSION_NON_MAPMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CATEGORY_ID, t.SOURCE_ID, t.JDE_DIMENSION_ID, t.JDE_YEAR, t.JDE_PERIOD });

            // Properties
            this.Property(t => t.CATEGORY_ID)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.CATEGORY_DESC)
                .HasMaxLength(200);

            this.Property(t => t.SOURCE_ID)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.SOURCE_DESC)
                .HasMaxLength(200);

            this.Property(t => t.JDE_DIMENSION_ID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.JDE_DIMENSION_DESC)
                .HasMaxLength(200);

            this.Property(t => t.JDE_YEAR)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.JDE_PERIOD)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("HP_DIMENSION_NON_MAP", "EPM_ODS");
            this.Property(t => t.CATEGORY_ID).HasColumnName("CATEGORY_ID");
            this.Property(t => t.CATEGORY_DESC).HasColumnName("CATEGORY_DESC");
            this.Property(t => t.SOURCE_ID).HasColumnName("SOURCE_ID");
            this.Property(t => t.SOURCE_DESC).HasColumnName("SOURCE_DESC");
            this.Property(t => t.JDE_DIMENSION_ID).HasColumnName("JDE_DIMENSION_ID");
            this.Property(t => t.JDE_DIMENSION_DESC).HasColumnName("JDE_DIMENSION_DESC");
            this.Property(t => t.JDE_YEAR).HasColumnName("JDE_YEAR");
            this.Property(t => t.JDE_PERIOD).HasColumnName("JDE_PERIOD");
            this.Property(t => t.INSERT_DATE).HasColumnName("INSERT_DATE");
        }
    }
}
