using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace OAContext
{
    public class C_F00022Map : EntityTypeConfiguration<C_F00022>
    {
        public C_F00022Map()
        {
            // Primary Key
            this.HasKey(t => new { t.UKKCOO, t.UKDCTO, t.UKNAME });

            // Properties
            this.Property(t => t.UKKCOO)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.UKDCTO)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.UKNAME)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("C_F00022");
            this.Property(t => t.UKKCOO).HasColumnName("UKKCOO");
            this.Property(t => t.UKDOCO).HasColumnName("UKDOCO");
            this.Property(t => t.UKDCTO).HasColumnName("UKDCTO");
            this.Property(t => t.UKNAME).HasColumnName("UKNAME");
            this.Property(t => t.UKFROM).HasColumnName("UKFROM");
            this.Property(t => t.UKADD).HasColumnName("UKADD");
        }
    }
}
