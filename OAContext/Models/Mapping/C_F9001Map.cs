using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace OAContext
{
    public class C_F9001Map : EntityTypeConfiguration<C_F9001>
    {
        public C_F9001Map()
        {
            // Primary Key
            this.HasKey(t => new { t.RUKCOO, t.RUID });

            // Properties
            this.Property(t => t.RUKCOO)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.RUID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.RUDEL1)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.RUDEL2)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.RUSRP1)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.RUSRP2)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.RUSRP3)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.RUSRP4)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.RUSRP5)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.RUUSER)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.RUPID)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("C_F9001");
            this.Property(t => t.RUKCOO).HasColumnName("RUKCOO");
            this.Property(t => t.RUID).HasColumnName("RUID");
            this.Property(t => t.RUDEL1).HasColumnName("RUDEL1");
            this.Property(t => t.RUDEL2).HasColumnName("RUDEL2");
            this.Property(t => t.RUSRP1).HasColumnName("RUSRP1");
            this.Property(t => t.RUSRP2).HasColumnName("RUSRP2");
            this.Property(t => t.RUSRP3).HasColumnName("RUSRP3");
            this.Property(t => t.RUSRP4).HasColumnName("RUSRP4");
            this.Property(t => t.RUSRP5).HasColumnName("RUSRP5");
            this.Property(t => t.RUPRP1).HasColumnName("RUPRP1");
            this.Property(t => t.RUPRP2).HasColumnName("RUPRP2");
            this.Property(t => t.RUPRP3).HasColumnName("RUPRP3");
            this.Property(t => t.RUPRP4).HasColumnName("RUPRP4");
            this.Property(t => t.RUPRP5).HasColumnName("RUPRP5");
            this.Property(t => t.RUUSER).HasColumnName("RUUSER");
            this.Property(t => t.RUPID).HasColumnName("RUPID");
            this.Property(t => t.RUDATE).HasColumnName("RUDATE");
            this.Property(t => t.RUTIME).HasColumnName("RUTIME");
        }
    }
}
