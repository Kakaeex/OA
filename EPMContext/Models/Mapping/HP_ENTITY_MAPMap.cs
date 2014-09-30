using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EPMContext
{
    public class HP_ENTITY_MAPMap : EntityTypeConfiguration<HP_ENTITY_MAP>
    {
        public HP_ENTITY_MAPMap()
        {
            // Primary Key
            this.HasKey(t => new { t.HP_ENTITY_ID, t.HP_ENTITY_DESC });

            // Properties
            this.Property(t => t.JDE_BU_ID)
                .HasMaxLength(79);

            this.Property(t => t.JDE_BU_DESC)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.HP_ENTITY_ID)
                .IsRequired()
                .HasMaxLength(80);

            this.Property(t => t.HP_ENTITY_DESC)
                .IsRequired()
                .HasMaxLength(80);

            this.Property(t => t.SOURCE_ID)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.SOURCE_DESC)
                .IsFixedLength()
                .HasMaxLength(3);

            // Table & Column Mappings
            this.ToTable("HP_ENTITY_MAP", "EPM_ODS");
            this.Property(t => t.SORT_ID).HasColumnName("SORT_ID");
            this.Property(t => t.JDE_BU_ID).HasColumnName("JDE_BU_ID");
            this.Property(t => t.JDE_BU_DESC).HasColumnName("JDE_BU_DESC");
            this.Property(t => t.HP_ENTITY_ID).HasColumnName("HP_ENTITY_ID");
            this.Property(t => t.HP_ENTITY_DESC).HasColumnName("HP_ENTITY_DESC");
            this.Property(t => t.INSERT_DATE).HasColumnName("INSERT_DATE");
            this.Property(t => t.SOURCE_ID).HasColumnName("SOURCE_ID");
            this.Property(t => t.SOURCE_DESC).HasColumnName("SOURCE_DESC");
        }
    }
}
