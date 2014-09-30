using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EPMContext
{
    public class F0005_TEMPMap : EntityTypeConfiguration<F0005_TEMP>
    {
        public F0005_TEMPMap()
        {
            // Primary Key
            this.HasKey(t => new { t.DRSY, t.DRRT, t.DRKY });

            // Properties
            this.Property(t => t.DRSY)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.DRRT)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.DRKY)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.DRDL01)
                .IsFixedLength()
                .HasMaxLength(30);

            this.Property(t => t.DRDL02)
                .IsFixedLength()
                .HasMaxLength(30);

            this.Property(t => t.DRSPHD)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.DRUDCO)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.DRHRDC)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.DRUSER)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.DRPID)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.DRJOBN)
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("F0005_TEMP", "EPM_ODS");
            this.Property(t => t.DRSY).HasColumnName("DRSY");
            this.Property(t => t.DRRT).HasColumnName("DRRT");
            this.Property(t => t.DRKY).HasColumnName("DRKY");
            this.Property(t => t.DRDL01).HasColumnName("DRDL01");
            this.Property(t => t.DRDL02).HasColumnName("DRDL02");
            this.Property(t => t.DRSPHD).HasColumnName("DRSPHD");
            this.Property(t => t.DRUDCO).HasColumnName("DRUDCO");
            this.Property(t => t.DRHRDC).HasColumnName("DRHRDC");
            this.Property(t => t.DRUSER).HasColumnName("DRUSER");
            this.Property(t => t.DRPID).HasColumnName("DRPID");
            this.Property(t => t.DRUPMJ).HasColumnName("DRUPMJ");
            this.Property(t => t.DRJOBN).HasColumnName("DRJOBN");
            this.Property(t => t.DRUPMT).HasColumnName("DRUPMT");
        }
    }
}
