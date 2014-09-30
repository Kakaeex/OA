using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EPMContext
{
    public class F0911Z1_TEMPMap : EntityTypeConfiguration<F0911Z1_TEMP>
    {
        public F0911Z1_TEMPMap()
        {
            // Primary Key
            this.HasKey(t => new { t.VNDGJ, t.VNMCU, t.VNOBJ, t.VNSUB, t.VNFY });

            // Properties
            this.Property(t => t.VNKCO)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.VNDGJ)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

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

            this.Property(t => t.VNFY)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.VNCRCD)
                .IsFixedLength()
                .HasMaxLength(3);

            // Table & Column Mappings
            this.ToTable("F0911Z1_TEMP", "EPM_ODS");
            this.Property(t => t.SORTID).HasColumnName("SORTID");
            this.Property(t => t.VNKCO).HasColumnName("VNKCO");
            this.Property(t => t.VNDGJ).HasColumnName("VNDGJ");
            this.Property(t => t.VNAID).HasColumnName("VNAID");
            this.Property(t => t.VNMCU).HasColumnName("VNMCU");
            this.Property(t => t.VNOBJ).HasColumnName("VNOBJ");
            this.Property(t => t.VNSUB).HasColumnName("VNSUB");
            this.Property(t => t.VNPN).HasColumnName("VNPN");
            this.Property(t => t.VNCTRY).HasColumnName("VNCTRY");
            this.Property(t => t.VNFY).HasColumnName("VNFY");
            this.Property(t => t.VNCRCD).HasColumnName("VNCRCD");
            this.Property(t => t.VNAG_OLD).HasColumnName("VNAG_OLD");
            this.Property(t => t.VNAG_NEW).HasColumnName("VNAG_NEW");
            this.Property(t => t.DATA_INSERT_TIME).HasColumnName("DATA_INSERT_TIME");
        }
    }
}
