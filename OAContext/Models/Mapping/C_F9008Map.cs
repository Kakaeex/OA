using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace OAContext
{
    public class C_F9008Map : EntityTypeConfiguration<C_F9008>
    {
        public C_F9008Map()
        {
            // Primary Key
            this.HasKey(t => new { t.AUKCOO, t.AUMCU, t.AURUID });

            // Properties
            this.Property(t => t.AUKCOO)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.AUMCU)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.AURUID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.AUDEL1)
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

            this.Property(t => t.AUUSER)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.AUPID)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("C_F9008");
            this.Property(t => t.AUKCOO).HasColumnName("AUKCOO");
            this.Property(t => t.AUMCU).HasColumnName("AUMCU");
            this.Property(t => t.AURUID).HasColumnName("AURUID");
            this.Property(t => t.AUDEL1).HasColumnName("AUDEL1");
            this.Property(t => t.AUDEL2).HasColumnName("AUDEL2");
            this.Property(t => t.AUSRP1).HasColumnName("AUSRP1");
            this.Property(t => t.AUSRP2).HasColumnName("AUSRP2");
            this.Property(t => t.AUSRP3).HasColumnName("AUSRP3");
            this.Property(t => t.AUSRP4).HasColumnName("AUSRP4");
            this.Property(t => t.AUSRP5).HasColumnName("AUSRP5");
            this.Property(t => t.AUPRP1).HasColumnName("AUPRP1");
            this.Property(t => t.AUPRP2).HasColumnName("AUPRP2");
            this.Property(t => t.AUPRP3).HasColumnName("AUPRP3");
            this.Property(t => t.AUPRP4).HasColumnName("AUPRP4");
            this.Property(t => t.AUPRP5).HasColumnName("AUPRP5");
            this.Property(t => t.AUUSER).HasColumnName("AUUSER");
            this.Property(t => t.AUPID).HasColumnName("AUPID");
            this.Property(t => t.AUDATE).HasColumnName("AUDATE");
            this.Property(t => t.AUTIME).HasColumnName("AUTIME");
        }
    }
}
