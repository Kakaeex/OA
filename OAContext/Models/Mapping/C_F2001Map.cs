using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace OAContext
{
    public class C_F2001Map : EntityTypeConfiguration<C_F2001>
    {
        public C_F2001Map()
        {
            // Primary Key
            this.HasKey(t => new { t.WDKCOO, t.WDDOCO, t.WDDCTO, t.WDLIND });

            // Properties
            this.Property(t => t.WDKCOO)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.WDDOCO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.WDDCTO)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.WDLIND)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.WDDSC1)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.WDDSC2)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.WDDCT)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.WDVR01)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.WDVR02)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.WDSRP1)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.WDSRP2)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.WDSRP3)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.WDSRP4)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.WDSRP5)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.WDUSER)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.WDPID)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("C_F2001");
            this.Property(t => t.WDKCOO).HasColumnName("WDKCOO");
            this.Property(t => t.WDDOCO).HasColumnName("WDDOCO");
            this.Property(t => t.WDDCTO).HasColumnName("WDDCTO");
            this.Property(t => t.WDLIND).HasColumnName("WDLIND");
            this.Property(t => t.WDDSC1).HasColumnName("WDDSC1");
            this.Property(t => t.WDDSC2).HasColumnName("WDDSC2");
            this.Property(t => t.WDDCT).HasColumnName("WDDCT");
            this.Property(t => t.WDTRDJ).HasColumnName("WDTRDJ");
            this.Property(t => t.WDDRQJ).HasColumnName("WDDRQJ");
            this.Property(t => t.WDPDDJ).HasColumnName("WDPDDJ");
            this.Property(t => t.WDADDJ).HasColumnName("WDADDJ");
            this.Property(t => t.WDCNDJ).HasColumnName("WDCNDJ");
            this.Property(t => t.WDUPRC).HasColumnName("WDUPRC");
            this.Property(t => t.WDAEXP).HasColumnName("WDAEXP");
            this.Property(t => t.WDUNCS).HasColumnName("WDUNCS");
            this.Property(t => t.WDECST).HasColumnName("WDECST");
            this.Property(t => t.WDSOQS).HasColumnName("WDSOQS");
            this.Property(t => t.WDUORG).HasColumnName("WDUORG");
            this.Property(t => t.WDVR01).HasColumnName("WDVR01");
            this.Property(t => t.WDVR02).HasColumnName("WDVR02");
            this.Property(t => t.WDSRP1).HasColumnName("WDSRP1");
            this.Property(t => t.WDSRP2).HasColumnName("WDSRP2");
            this.Property(t => t.WDSRP3).HasColumnName("WDSRP3");
            this.Property(t => t.WDSRP4).HasColumnName("WDSRP4");
            this.Property(t => t.WDSRP5).HasColumnName("WDSRP5");
            this.Property(t => t.WDPRP1).HasColumnName("WDPRP1");
            this.Property(t => t.WDPRP2).HasColumnName("WDPRP2");
            this.Property(t => t.WDPRP3).HasColumnName("WDPRP3");
            this.Property(t => t.WDPRP4).HasColumnName("WDPRP4");
            this.Property(t => t.WDPRP5).HasColumnName("WDPRP5");
            this.Property(t => t.WDUSER).HasColumnName("WDUSER");
            this.Property(t => t.WDPID).HasColumnName("WDPID");
            this.Property(t => t.WDDATE).HasColumnName("WDDATE");
            this.Property(t => t.WDTIME).HasColumnName("WDTIME");
        }
    }
}
