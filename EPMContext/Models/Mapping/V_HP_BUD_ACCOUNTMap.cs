using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EPMContext
{
    public class V_HP_BUD_ACCOUNTMap : EntityTypeConfiguration<V_HP_BUD_ACCOUNT>
    {
        public V_HP_BUD_ACCOUNTMap()
        {
            // Primary Key
            this.HasKey(t => new { t.OBJECT_ID, t.ACCOUNT_ID, t.PARENT_ID });

            // Properties
            this.Property(t => t.OBJECT_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ACCOUNT_ID)
                .IsRequired()
                .HasMaxLength(80);

            this.Property(t => t.ACCOUNT_NAME)
                .HasMaxLength(80);

            this.Property(t => t.PARENT_ID)
                .IsRequired()
                .HasMaxLength(80);

            this.Property(t => t.ACCOUNT_PARENT)
                .HasMaxLength(1999);

            // Table & Column Mappings
            this.ToTable("V_HP_BUD_ACCOUNT", "EPM_ODS");
            this.Property(t => t.OBJECT_ID).HasColumnName("OBJECT_ID");
            this.Property(t => t.ACCOUNT_ID).HasColumnName("ACCOUNT_ID");
            this.Property(t => t.ACCOUNT_NAME).HasColumnName("ACCOUNT_NAME");
            this.Property(t => t.PARENT_ID).HasColumnName("PARENT_ID");
            this.Property(t => t.HAS_CHILDREN).HasColumnName("HAS_CHILDREN");
            this.Property(t => t.ACCOUNT_PARENT).HasColumnName("ACCOUNT_PARENT");
        }
    }
}
