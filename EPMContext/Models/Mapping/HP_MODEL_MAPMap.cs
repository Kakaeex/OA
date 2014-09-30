using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EPMContext
{
    public class HP_MODEL_MAPMap : EntityTypeConfiguration<HP_MODEL_MAP>
    {
        public HP_MODEL_MAPMap()
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

            this.Property(t => t.HP_MODEL_ID)
                .HasMaxLength(50);

            this.Property(t => t.JDE_MODEL_DESC)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("HP_MODEL_MAP", "EPM_ODS");
            this.Property(t => t.SORT_ID).HasColumnName("SORT_ID");
            this.Property(t => t.JDE_BRAND_ID).HasColumnName("JDE_BRAND_ID");
            this.Property(t => t.JDE_BRAND_DESC).HasColumnName("JDE_BRAND_DESC");
            this.Property(t => t.JDE_MODEL_RANK).HasColumnName("JDE_MODEL_RANK");
            this.Property(t => t.HP_MODEL_ID).HasColumnName("HP_MODEL_ID");
            this.Property(t => t.JDE_MODEL_DESC).HasColumnName("JDE_MODEL_DESC");
            this.Property(t => t.INSERT_DATE).HasColumnName("INSERT_DATE");
        }
    }
}
