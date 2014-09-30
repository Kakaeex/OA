using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EPMContext
{
    public class HP_PERIOD_MAPMap : EntityTypeConfiguration<HP_PERIOD_MAP>
    {
        public HP_PERIOD_MAPMap()
        {
            // Primary Key
            this.HasKey(t => new { t.SORT_ID, t.JDE_PERIOD_ID, t.HP_PERIOD_ID });

            // Properties
            this.Property(t => t.SORT_ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.JDE_PERIOD_ID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.JDE_PERIOD_DESC)
                .HasMaxLength(50);

            this.Property(t => t.HP_PERIOD_ID)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.HP_PERIOD_DESC)
                .HasMaxLength(50);

            this.Property(t => t.SOURCE_ID)
                .HasMaxLength(20);

            this.Property(t => t.SOURCE_DESC)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("HP_PERIOD_MAP", "EPM_ODS");
            this.Property(t => t.SORT_ID).HasColumnName("SORT_ID");
            this.Property(t => t.JDE_PERIOD_ID).HasColumnName("JDE_PERIOD_ID");
            this.Property(t => t.JDE_PERIOD_DESC).HasColumnName("JDE_PERIOD_DESC");
            this.Property(t => t.HP_PERIOD_ID).HasColumnName("HP_PERIOD_ID");
            this.Property(t => t.HP_PERIOD_DESC).HasColumnName("HP_PERIOD_DESC");
            this.Property(t => t.INSERT_DATE).HasColumnName("INSERT_DATE");
            this.Property(t => t.SOURCE_ID).HasColumnName("SOURCE_ID");
            this.Property(t => t.SOURCE_DESC).HasColumnName("SOURCE_DESC");
        }
    }
}
