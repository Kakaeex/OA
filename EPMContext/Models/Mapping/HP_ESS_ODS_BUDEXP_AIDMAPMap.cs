using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EPMContext
{
    public class HP_ESS_ODS_BUDEXP_AIDMAPMap : EntityTypeConfiguration<HP_ESS_ODS_BUDEXP_AIDMAP>
    {
        public HP_ESS_ODS_BUDEXP_AIDMAPMap()
        {
            // Primary Key
            this.HasKey(t => new { t.VNMCU, t.VNOBJ, t.VNSUB });

            // Properties
            this.Property(t => t.VNKCO)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.VNAID)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.VNMCU)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.VNOBJ)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(6);

            this.Property(t => t.VNSUB)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.SOURCE)
                .HasMaxLength(5);

            // Table & Column Mappings
            this.ToTable("HP_ESS_ODS_BUDEXP_AIDMAP", "EPM_ODS");
            this.Property(t => t.VNKCO).HasColumnName("VNKCO");
            this.Property(t => t.VNAID).HasColumnName("VNAID");
            this.Property(t => t.VNMCU).HasColumnName("VNMCU");
            this.Property(t => t.VNOBJ).HasColumnName("VNOBJ");
            this.Property(t => t.VNSUB).HasColumnName("VNSUB");
            this.Property(t => t.DATA_INSERT_TIME).HasColumnName("DATA_INSERT_TIME");
            this.Property(t => t.SOURCE).HasColumnName("SOURCE");
        }
    }
}
