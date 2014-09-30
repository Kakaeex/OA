using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace OAContext
{
    public class C_F9006Map : EntityTypeConfiguration<C_F9006>
    {
        public C_F9006Map()
        {
            // Primary Key
            this.HasKey(t => new { t.RAKCOO, t.RAAN8, t.RAID });

            // Properties
            this.Property(t => t.RAKCOO)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.RAAN8)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RAID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.RADEL1)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.RADEL2)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.RASRP1)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.RASRP2)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.RASRP3)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.RASRP4)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.RASRP5)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.RAUSER)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.RAPID)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("C_F9006");
            this.Property(t => t.RAKCOO).HasColumnName("RAKCOO");
            this.Property(t => t.RAAN8).HasColumnName("RAAN8");
            this.Property(t => t.RAID).HasColumnName("RAID");
            this.Property(t => t.RADEL1).HasColumnName("RADEL1");
            this.Property(t => t.RADEL2).HasColumnName("RADEL2");
            this.Property(t => t.RASRP1).HasColumnName("RASRP1");
            this.Property(t => t.RASRP2).HasColumnName("RASRP2");
            this.Property(t => t.RASRP3).HasColumnName("RASRP3");
            this.Property(t => t.RASRP4).HasColumnName("RASRP4");
            this.Property(t => t.RASRP5).HasColumnName("RASRP5");
            this.Property(t => t.RAPRP1).HasColumnName("RAPRP1");
            this.Property(t => t.RAPRP2).HasColumnName("RAPRP2");
            this.Property(t => t.RAPRP3).HasColumnName("RAPRP3");
            this.Property(t => t.RAPRP4).HasColumnName("RAPRP4");
            this.Property(t => t.RAPRP5).HasColumnName("RAPRP5");
            this.Property(t => t.RAUSER).HasColumnName("RAUSER");
            this.Property(t => t.RAPID).HasColumnName("RAPID");
            this.Property(t => t.RADATE).HasColumnName("RADATE");
            this.Property(t => t.RATIME).HasColumnName("RATIME");
        }
    }
}
