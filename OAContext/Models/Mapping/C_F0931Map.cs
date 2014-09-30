using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace OAContext
{
    public class C_F0931Map : EntityTypeConfiguration<C_F0931>
    {
        public C_F0931Map()
        {
            // Primary Key
            this.HasKey(t => new { t.CDKCOO, t.CDDOCO });

            // Properties
            this.Property(t => t.CDKCOO)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.CDDOCO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CDDCTO)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.CDDCT)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.CDDSC1)
                .HasMaxLength(30);

            this.Property(t => t.CDDSC2)
                .HasMaxLength(30);

            this.Property(t => t.CDMAID)
                .HasMaxLength(8);

            this.Property(t => t.CDMMCU)
                .HasMaxLength(12);

            this.Property(t => t.CDMOBJ)
                .HasMaxLength(6);

            this.Property(t => t.CDMSUB)
                .HasMaxLength(8);

            this.Property(t => t.CDDEL1)
                .HasMaxLength(30);

            this.Property(t => t.CDFAID)
                .HasMaxLength(8);

            this.Property(t => t.CDFMCU)
                .HasMaxLength(12);

            this.Property(t => t.CDFOBJ)
                .HasMaxLength(6);

            this.Property(t => t.CDFSUB)
                .HasMaxLength(8);

            this.Property(t => t.CDDEL2)
                .HasMaxLength(30);

            this.Property(t => t.CDVR01)
                .HasMaxLength(30);

            this.Property(t => t.CDVR02)
                .HasMaxLength(30);

            this.Property(t => t.CDSRP1)
                .HasMaxLength(10);

            this.Property(t => t.CDSRP2)
                .HasMaxLength(10);

            this.Property(t => t.CDSRP3)
                .HasMaxLength(10);

            this.Property(t => t.CDSRP4)
                .HasMaxLength(10);

            this.Property(t => t.CDSRP5)
                .HasMaxLength(10);

            this.Property(t => t.CDUSER)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.CDPID)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("C_F0931");
            this.Property(t => t.CDKCOO).HasColumnName("CDKCOO");
            this.Property(t => t.CDDOCO).HasColumnName("CDDOCO");
            this.Property(t => t.CDDCTO).HasColumnName("CDDCTO");
            this.Property(t => t.CDDLNID).HasColumnName("CDDLNID");
            this.Property(t => t.CDDOC).HasColumnName("CDDOC");
            this.Property(t => t.CDDCT).HasColumnName("CDDCT");
            this.Property(t => t.CDDSC1).HasColumnName("CDDSC1");
            this.Property(t => t.CDDSC2).HasColumnName("CDDSC2");
            this.Property(t => t.CDMAID).HasColumnName("CDMAID");
            this.Property(t => t.CDMMCU).HasColumnName("CDMMCU");
            this.Property(t => t.CDMOBJ).HasColumnName("CDMOBJ");
            this.Property(t => t.CDMSUB).HasColumnName("CDMSUB");
            this.Property(t => t.CDDEL1).HasColumnName("CDDEL1");
            this.Property(t => t.CDFAID).HasColumnName("CDFAID");
            this.Property(t => t.CDFMCU).HasColumnName("CDFMCU");
            this.Property(t => t.CDFOBJ).HasColumnName("CDFOBJ");
            this.Property(t => t.CDFSUB).HasColumnName("CDFSUB");
            this.Property(t => t.CDDEL2).HasColumnName("CDDEL2");
            this.Property(t => t.CDTRDJ).HasColumnName("CDTRDJ");
            this.Property(t => t.CDDRQJ).HasColumnName("CDDRQJ");
            this.Property(t => t.CDPDDJ).HasColumnName("CDPDDJ");
            this.Property(t => t.CDADDJ).HasColumnName("CDADDJ");
            this.Property(t => t.CDCNDJ).HasColumnName("CDCNDJ");
            this.Property(t => t.CDUPRC).HasColumnName("CDUPRC");
            this.Property(t => t.CDAEXP).HasColumnName("CDAEXP");
            this.Property(t => t.CDUNCS).HasColumnName("CDUNCS");
            this.Property(t => t.CDECST).HasColumnName("CDECST");
            this.Property(t => t.CDSOQS).HasColumnName("CDSOQS");
            this.Property(t => t.CDUORG).HasColumnName("CDUORG");
            this.Property(t => t.CDVR01).HasColumnName("CDVR01");
            this.Property(t => t.CDVR02).HasColumnName("CDVR02");
            this.Property(t => t.CDSRP1).HasColumnName("CDSRP1");
            this.Property(t => t.CDSRP2).HasColumnName("CDSRP2");
            this.Property(t => t.CDSRP3).HasColumnName("CDSRP3");
            this.Property(t => t.CDSRP4).HasColumnName("CDSRP4");
            this.Property(t => t.CDSRP5).HasColumnName("CDSRP5");
            this.Property(t => t.CDPRP1).HasColumnName("CDPRP1");
            this.Property(t => t.CDPRP2).HasColumnName("CDPRP2");
            this.Property(t => t.CDPRP3).HasColumnName("CDPRP3");
            this.Property(t => t.CDPRP4).HasColumnName("CDPRP4");
            this.Property(t => t.CDPRP5).HasColumnName("CDPRP5");
            this.Property(t => t.CDUSER).HasColumnName("CDUSER");
            this.Property(t => t.CDPID).HasColumnName("CDPID");
            this.Property(t => t.CDDATE).HasColumnName("CDDATE");
            this.Property(t => t.CDTIME).HasColumnName("CDTIME");
        }
    }
}
