using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace OAContext
{
    public class V_F0920Map : EntityTypeConfiguration<V_F0920>
    {
        public V_F0920Map()
        {
            // Primary Key
            this.HasKey(t => new { t.MCKCOO, t.MCMCU, t.MCSTYL, t.FHDOCO, t.FHDCTO, t.MCDC, t.MCLDM, t.MCCO, t.MCAN8 });

            // Properties
            this.Property(t => t.MCKCOO)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.MCMCU)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.MCSTYL)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.FHDOCO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FHDCTO)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.FHMCU)
                .HasMaxLength(12);

            this.Property(t => t.FHNAME)
                .HasMaxLength(30);

            this.Property(t => t.FHDSC1)
                .HasMaxLength(30);

            this.Property(t => t.FHDSC2)
                .HasMaxLength(30);

            this.Property(t => t.FHLTTR)
                .HasMaxLength(3);

            this.Property(t => t.FHNXTR)
                .HasMaxLength(3);

            this.Property(t => t.FHSRP1)
                .HasMaxLength(10);

            this.Property(t => t.FHSRP2)
                .HasMaxLength(10);

            this.Property(t => t.FHSRP3)
                .HasMaxLength(10);

            this.Property(t => t.FHSRP4)
                .HasMaxLength(10);

            this.Property(t => t.FHSRP5)
                .HasMaxLength(10);

            this.Property(t => t.FHSRP6)
                .HasMaxLength(10);

            this.Property(t => t.FHSRP7)
                .HasMaxLength(10);

            this.Property(t => t.FHSRP8)
                .HasMaxLength(10);

            this.Property(t => t.FHSRP9)
                .HasMaxLength(10);

            this.Property(t => t.FHSRP0)
                .HasMaxLength(10);

            this.Property(t => t.FHTROG)
                .HasMaxLength(20);

            this.Property(t => t.FHUSER)
                .HasMaxLength(20);

            this.Property(t => t.FHPID)
                .HasMaxLength(50);

            this.Property(t => t.MCDC)
                .IsRequired();

            this.Property(t => t.MCLDM)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.MCCO)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.MCAN8)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("V_F0920");
            this.Property(t => t.MCKCOO).HasColumnName("MCKCOO");
            this.Property(t => t.MCMCU).HasColumnName("MCMCU");
            this.Property(t => t.MCSTYL).HasColumnName("MCSTYL");
            this.Property(t => t.FHDOCO).HasColumnName("FHDOCO");
            this.Property(t => t.FHDCTO).HasColumnName("FHDCTO");
            this.Property(t => t.FHMCU).HasColumnName("FHMCU");
            this.Property(t => t.FHYAER).HasColumnName("FHYAER");
            this.Property(t => t.FHEFTJ).HasColumnName("FHEFTJ");
            this.Property(t => t.FHEDXJ).HasColumnName("FHEDXJ");
            this.Property(t => t.FHNAME).HasColumnName("FHNAME");
            this.Property(t => t.FHDSC1).HasColumnName("FHDSC1");
            this.Property(t => t.FHDSC2).HasColumnName("FHDSC2");
            this.Property(t => t.FHUPRC).HasColumnName("FHUPRC");
            this.Property(t => t.FHAPYN).HasColumnName("FHAPYN");
            this.Property(t => t.FHAWTD).HasColumnName("FHAWTD");
            this.Property(t => t.FHLTTR).HasColumnName("FHLTTR");
            this.Property(t => t.FHNXTR).HasColumnName("FHNXTR");
            this.Property(t => t.FHSRP1).HasColumnName("FHSRP1");
            this.Property(t => t.FHSRP2).HasColumnName("FHSRP2");
            this.Property(t => t.FHSRP3).HasColumnName("FHSRP3");
            this.Property(t => t.FHSRP4).HasColumnName("FHSRP4");
            this.Property(t => t.FHSRP5).HasColumnName("FHSRP5");
            this.Property(t => t.FHSRP6).HasColumnName("FHSRP6");
            this.Property(t => t.FHSRP7).HasColumnName("FHSRP7");
            this.Property(t => t.FHSRP8).HasColumnName("FHSRP8");
            this.Property(t => t.FHSRP9).HasColumnName("FHSRP9");
            this.Property(t => t.FHSRP0).HasColumnName("FHSRP0");
            this.Property(t => t.FHPRP1).HasColumnName("FHPRP1");
            this.Property(t => t.FHPRP2).HasColumnName("FHPRP2");
            this.Property(t => t.FHPRP3).HasColumnName("FHPRP3");
            this.Property(t => t.FHPRP4).HasColumnName("FHPRP4");
            this.Property(t => t.FHPRP5).HasColumnName("FHPRP5");
            this.Property(t => t.FHPRP6).HasColumnName("FHPRP6");
            this.Property(t => t.FHPRP7).HasColumnName("FHPRP7");
            this.Property(t => t.FHPRP8).HasColumnName("FHPRP8");
            this.Property(t => t.FHPRP9).HasColumnName("FHPRP9");
            this.Property(t => t.FHPRP0).HasColumnName("FHPRP0");
            this.Property(t => t.FHTROG).HasColumnName("FHTROG");
            this.Property(t => t.FHUSER).HasColumnName("FHUSER");
            this.Property(t => t.FHPID).HasColumnName("FHPID");
            this.Property(t => t.FHDATE).HasColumnName("FHDATE");
            this.Property(t => t.FHTIME).HasColumnName("FHTIME");
            this.Property(t => t.MCDC).HasColumnName("MCDC");
            this.Property(t => t.MCLDM).HasColumnName("MCLDM");
            this.Property(t => t.MCCO).HasColumnName("MCCO");
            this.Property(t => t.MCAN8).HasColumnName("MCAN8");
        }
    }
}
