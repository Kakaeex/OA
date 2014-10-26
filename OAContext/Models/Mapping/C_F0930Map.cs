using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace OAContext
{
    public class C_F0930Map : EntityTypeConfiguration<C_F0930>
    {
        public C_F0930Map()
        {
            // Primary Key
            this.HasKey(t => new { t.CHKCOO, t.CHDOCO, t.CHDCTO });

            // Properties
            this.Property(t => t.CHKCOO)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.CHDOCO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CHDCTO)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.CHNXTR)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.CHLTTR)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.CHDCT)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.CHDSC1)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.CHDSC2)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.CHMCU)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.CHTORG)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CHVR01)
                .IsRequired();

            this.Property(t => t.CHVR02)
                .IsRequired();

            this.Property(t => t.CHSRP1)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.CHSRP2)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.CHSRP3)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.CHSRP4)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.CHSRP5)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.CHUSER)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.CHPID)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("C_F0930");
            this.Property(t => t.CHKCOO).HasColumnName("CHKCOO");
            this.Property(t => t.CHDOCO).HasColumnName("CHDOCO");
            this.Property(t => t.CHDCTO).HasColumnName("CHDCTO");
            this.Property(t => t.CHNXTR).HasColumnName("CHNXTR");
            this.Property(t => t.CHLTTR).HasColumnName("CHLTTR");
            this.Property(t => t.CHDOC).HasColumnName("CHDOC");
            this.Property(t => t.CHDCT).HasColumnName("CHDCT");
            this.Property(t => t.CHDSC1).HasColumnName("CHDSC1");
            this.Property(t => t.CHDSC2).HasColumnName("CHDSC2");
            this.Property(t => t.CHMCU).HasColumnName("CHMCU");
            this.Property(t => t.CHTRDJ).HasColumnName("CHTRDJ");
            this.Property(t => t.CHDRQJ).HasColumnName("CHDRQJ");
            this.Property(t => t.CHPDDJ).HasColumnName("CHPDDJ");
            this.Property(t => t.CHADDJ).HasColumnName("CHADDJ");
            this.Property(t => t.CHCNDJ).HasColumnName("CHCNDJ");
            this.Property(t => t.CHUPRC).HasColumnName("CHUPRC");
            this.Property(t => t.CHAEXP).HasColumnName("CHAEXP");
            this.Property(t => t.CHUNCS).HasColumnName("CHUNCS");
            this.Property(t => t.CHECST).HasColumnName("CHECST");
            this.Property(t => t.CHSOQS).HasColumnName("CHSOQS");
            this.Property(t => t.CHUORG).HasColumnName("CHUORG");
            this.Property(t => t.CHTORG).HasColumnName("CHTORG");
            this.Property(t => t.CHVR01).HasColumnName("CHVR01");
            this.Property(t => t.CHVR02).HasColumnName("CHVR02");
            this.Property(t => t.CHSRP1).HasColumnName("CHSRP1");
            this.Property(t => t.CHSRP2).HasColumnName("CHSRP2");
            this.Property(t => t.CHSRP3).HasColumnName("CHSRP3");
            this.Property(t => t.CHSRP4).HasColumnName("CHSRP4");
            this.Property(t => t.CHSRP5).HasColumnName("CHSRP5");
            this.Property(t => t.CHPRP1).HasColumnName("CHPRP1");
            this.Property(t => t.CHPRP2).HasColumnName("CHPRP2");
            this.Property(t => t.CHPRP3).HasColumnName("CHPRP3");
            this.Property(t => t.CHPRP4).HasColumnName("CHPRP4");
            this.Property(t => t.CHPRP5).HasColumnName("CHPRP5");
            this.Property(t => t.CHUSER).HasColumnName("CHUSER");
            this.Property(t => t.CHPID).HasColumnName("CHPID");
            this.Property(t => t.CHDATE).HasColumnName("CHDATE");
            this.Property(t => t.CHTIME).HasColumnName("CHTIME");
        }
    }
}
