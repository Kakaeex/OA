using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EPMContext
{
    public class HP_SPEC_MAPMap : EntityTypeConfiguration<HP_SPEC_MAP>
    {
        public HP_SPEC_MAPMap()
        {
            // Primary Key
            this.HasKey(t => new { t.SORT_ID, t.JDE_BRAND_ID });

            // Properties
            this.Property(t => t.SORT_ID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.JDE_BRAND_ID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.JDE_BRAND_DESC)
                .HasMaxLength(200);

            this.Property(t => t.JDE_SPEC_ID)
                .HasMaxLength(200);

            this.Property(t => t.HP_SPEC_ID)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("HP_SPEC_MAP", "EPM_ODS");
            this.Property(t => t.SORT_ID).HasColumnName("SORT_ID");
            this.Property(t => t.JDE_BRAND_ID).HasColumnName("JDE_BRAND_ID");
            this.Property(t => t.JDE_BRAND_DESC).HasColumnName("JDE_BRAND_DESC");
            this.Property(t => t.JDE_SPEC_ID).HasColumnName("JDE_SPEC_ID");
            this.Property(t => t.HP_SPEC_ID).HasColumnName("HP_SPEC_ID");
            this.Property(t => t.DATA_INSERT_DATE).HasColumnName("DATA_INSERT_DATE");
        }
    }
}
