using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace OAContext
{
    public class C_F0035Map : EntityTypeConfiguration<C_F0035>
    {
        public C_F0035Map()
        {
            // Primary Key
            this.HasKey(t => new { t.MSKCOO, t.MSDCTO, t.MSCODE, t.MSLNGP });

            // Properties
            this.Property(t => t.MSKCOO)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.MSDCTO)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.MSCODE)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.MSLNGP)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.MSDSC1)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.MSDSC2)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.MSSRP1)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.MSSRP2)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.MSSRP3)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.MSSRP4)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.MSSRP5)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.MSPRP1)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.MSPRP2)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.MSPRP3)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.MSPRP4)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.MSPRP5)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.MSUSER)
                .HasMaxLength(20);

            this.Property(t => t.MSPID)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("C_F0035");
            this.Property(t => t.MSKCOO).HasColumnName("MSKCOO");
            this.Property(t => t.MSDCTO).HasColumnName("MSDCTO");
            this.Property(t => t.MSCODE).HasColumnName("MSCODE");
            this.Property(t => t.MSLNGP).HasColumnName("MSLNGP");
            this.Property(t => t.MSDSC1).HasColumnName("MSDSC1");
            this.Property(t => t.MSDSC2).HasColumnName("MSDSC2");
            this.Property(t => t.MSSRP1).HasColumnName("MSSRP1");
            this.Property(t => t.MSSRP2).HasColumnName("MSSRP2");
            this.Property(t => t.MSSRP3).HasColumnName("MSSRP3");
            this.Property(t => t.MSSRP4).HasColumnName("MSSRP4");
            this.Property(t => t.MSSRP5).HasColumnName("MSSRP5");
            this.Property(t => t.MSPRP1).HasColumnName("MSPRP1");
            this.Property(t => t.MSPRP2).HasColumnName("MSPRP2");
            this.Property(t => t.MSPRP3).HasColumnName("MSPRP3");
            this.Property(t => t.MSPRP4).HasColumnName("MSPRP4");
            this.Property(t => t.MSPRP5).HasColumnName("MSPRP5");
            this.Property(t => t.MSUSER).HasColumnName("MSUSER");
            this.Property(t => t.MSPID).HasColumnName("MSPID");
            this.Property(t => t.MSDATE).HasColumnName("MSDATE");
            this.Property(t => t.MSTIME).HasColumnName("MSTIME");
        }
    }
}
