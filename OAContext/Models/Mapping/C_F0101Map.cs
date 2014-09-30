using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace OAContext
{
    public class C_F0101Map : EntityTypeConfiguration<C_F0101>
    {
        public C_F0101Map()
        {
            // Primary Key
            this.HasKey(t => new { t.ABKCOO, t.ABAN8 });

            // Properties
            this.Property(t => t.ABKCOO)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ABAN8)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ABALKY)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.ABTAX)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.ABALPH)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.ABDC)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.ABMCU)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.ABSIC)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ABLNGP)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.ABAT1)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.ABCM)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.ABCLASS01)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.ABCLASS02)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.ABCLASS03)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.ABCLASS04)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.ABCLASS05)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.ABCLASS06)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.ABCLASS07)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.ABCLASS08)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.ABCLASS09)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.ABCLASS10)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.ABUSER)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.ABPID)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("C_F0101");
            this.Property(t => t.ABKCOO).HasColumnName("ABKCOO");
            this.Property(t => t.ABAN8).HasColumnName("ABAN8");
            this.Property(t => t.ABALKY).HasColumnName("ABALKY");
            this.Property(t => t.ABTAX).HasColumnName("ABTAX");
            this.Property(t => t.ABALPH).HasColumnName("ABALPH");
            this.Property(t => t.ABDC).HasColumnName("ABDC");
            this.Property(t => t.ABMCU).HasColumnName("ABMCU");
            this.Property(t => t.ABSIC).HasColumnName("ABSIC");
            this.Property(t => t.ABLNGP).HasColumnName("ABLNGP");
            this.Property(t => t.ABAT1).HasColumnName("ABAT1");
            this.Property(t => t.ABCM).HasColumnName("ABCM");
            this.Property(t => t.ABCLASS01).HasColumnName("ABCLASS01");
            this.Property(t => t.ABCLASS02).HasColumnName("ABCLASS02");
            this.Property(t => t.ABCLASS03).HasColumnName("ABCLASS03");
            this.Property(t => t.ABCLASS04).HasColumnName("ABCLASS04");
            this.Property(t => t.ABCLASS05).HasColumnName("ABCLASS05");
            this.Property(t => t.ABCLASS06).HasColumnName("ABCLASS06");
            this.Property(t => t.ABCLASS07).HasColumnName("ABCLASS07");
            this.Property(t => t.ABCLASS08).HasColumnName("ABCLASS08");
            this.Property(t => t.ABCLASS09).HasColumnName("ABCLASS09");
            this.Property(t => t.ABCLASS10).HasColumnName("ABCLASS10");
            this.Property(t => t.ABPRP1).HasColumnName("ABPRP1");
            this.Property(t => t.ABPRP2).HasColumnName("ABPRP2");
            this.Property(t => t.ABPRP3).HasColumnName("ABPRP3");
            this.Property(t => t.ABPRP4).HasColumnName("ABPRP4");
            this.Property(t => t.ABPRP5).HasColumnName("ABPRP5");
            this.Property(t => t.ABPRP6).HasColumnName("ABPRP6");
            this.Property(t => t.ABPRP7).HasColumnName("ABPRP7");
            this.Property(t => t.ABPRP8).HasColumnName("ABPRP8");
            this.Property(t => t.ABPRP9).HasColumnName("ABPRP9");
            this.Property(t => t.ABPRP0).HasColumnName("ABPRP0");
            this.Property(t => t.ABUSER).HasColumnName("ABUSER");
            this.Property(t => t.ABPID).HasColumnName("ABPID");
            this.Property(t => t.ABDATE).HasColumnName("ABDATE");
            this.Property(t => t.ABTIME).HasColumnName("ABTIME");
        }
    }
}
