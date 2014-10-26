using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace OAContext
{
    public class C_F0920Map : EntityTypeConfiguration<C_F0920>
    {
        public C_F0920Map()
        {
            // Primary Key
            this.HasKey(t => new { t.FHDOCO, t.FHDCTO });

            // Properties
            this.Property(t => t.FHDOCO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FHDCTO)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.FHKCOO)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.FHMCU)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.FHNAME)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.FHDSC1)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.FHDSC2)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.FHLTTR)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.FHNXTR)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.FHSRP1)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.FHSRP2)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.FHSRP3)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.FHSRP4)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.FHSRP5)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.FHSRP6)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.FHSRP7)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.FHSRP8)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.FHSRP9)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.FHSRP0)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.FHTROG)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.FHUSER)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.FHPID)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("C_F0920");
            this.Property(t => t.FHDOCO).HasColumnName("FHDOCO");
            this.Property(t => t.FHDCTO).HasColumnName("FHDCTO");
            this.Property(t => t.FHKCOO).HasColumnName("FHKCOO");
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
        }
    }
}
