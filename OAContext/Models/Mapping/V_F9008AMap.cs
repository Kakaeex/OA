using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace OAContext
{
    public class V_F9008AMap : EntityTypeConfiguration<V_F9008A>
    {
        public V_F9008AMap()
        {
            // Primary Key
            this.HasKey(t => new { t.AUAN8, t.MCDC, t.AUDEL2, t.AUSRP1, t.AUSRP2, t.AUSRP3, t.AUSRP4, t.AUSRP5, t.AUPRP1, t.AUPRP2, t.AUPRP3, t.AUPRP5, t.AUPRP4, t.MCKCOO, t.MCMCU });

            // Properties
            this.Property(t => t.AUAN8)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.MCDC)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.AUDEL2)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.AUSRP1)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.AUSRP2)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.AUSRP3)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.AUSRP4)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.AUSRP5)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.AUPRP1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AUPRP2)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AUPRP3)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AUPRP5)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AUPRP4)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.MCKCOO)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.MCMCU)
                .IsRequired()
                .HasMaxLength(12);

            // Table & Column Mappings
            this.ToTable("V_F9008A");
            this.Property(t => t.AUAN8).HasColumnName("AUAN8");
            this.Property(t => t.MCDC).HasColumnName("MCDC");
            this.Property(t => t.AUDEL2).HasColumnName("AUDEL2");
            this.Property(t => t.AUSRP1).HasColumnName("AUSRP1");
            this.Property(t => t.AUSRP2).HasColumnName("AUSRP2");
            this.Property(t => t.AUSRP3).HasColumnName("AUSRP3");
            this.Property(t => t.AUSRP4).HasColumnName("AUSRP4");
            this.Property(t => t.AUSRP5).HasColumnName("AUSRP5");
            this.Property(t => t.AUPRP1).HasColumnName("AUPRP1");
            this.Property(t => t.AUPRP2).HasColumnName("AUPRP2");
            this.Property(t => t.AUPRP3).HasColumnName("AUPRP3");
            this.Property(t => t.AUPRP5).HasColumnName("AUPRP5");
            this.Property(t => t.AUPRP4).HasColumnName("AUPRP4");
            this.Property(t => t.MCKCOO).HasColumnName("MCKCOO");
            this.Property(t => t.MCMCU).HasColumnName("MCMCU");
        }
    }
}
