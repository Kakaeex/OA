using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EPMContext
{
    public class V_HP_BUD_ENTITYMap : EntityTypeConfiguration<V_HP_BUD_ENTITY>
    {
        public V_HP_BUD_ENTITYMap()
        {
            // Primary Key
            this.HasKey(t => new { t.OBJECT_ID, t.ENTITY_CODE, t.PARENT_ID });

            // Properties
            this.Property(t => t.OBJECT_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ENTITY_CODE)
                .IsRequired()
                .HasMaxLength(80);

            this.Property(t => t.ENTITY_NAME)
                .HasMaxLength(80);

            this.Property(t => t.PARENT_ID)
                .IsRequired()
                .HasMaxLength(80);

            this.Property(t => t.ENTITY_PARENT)
                .HasMaxLength(1999);

            // Table & Column Mappings
            this.ToTable("V_HP_BUD_ENTITY", "EPM_ODS");
            this.Property(t => t.OBJECT_ID).HasColumnName("OBJECT_ID");
            this.Property(t => t.ENTITY_CODE).HasColumnName("ENTITY_CODE");
            this.Property(t => t.ENTITY_NAME).HasColumnName("ENTITY_NAME");
            this.Property(t => t.PARENT_ID).HasColumnName("PARENT_ID");
            this.Property(t => t.HAS_CHILDREN).HasColumnName("HAS_CHILDREN");
            this.Property(t => t.ENTITY_PARENT).HasColumnName("ENTITY_PARENT");
        }
    }
}
