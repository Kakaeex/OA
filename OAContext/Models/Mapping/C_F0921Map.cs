using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace OAContext
{
    public class C_F0921Map : EntityTypeConfiguration<C_F0921>
    {
        public C_F0921Map()
        {
            // Primary Key
            this.HasKey(t => new { t.FDDOCO, t.FDDCTO, t.FDLNID });

            // Properties
            this.Property(t => t.FDDOCO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FDDCTO)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.FDLNID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FDKCOO)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.FDMCU)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.FDAID)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.FDOBJ)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.FDSUB)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.FDNAME)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.FDDSC1)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.FDDSC2)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.FDLTTR)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.FDNXTR)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.FDSRP1)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.FDSRP2)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.FDSRP3)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.FDSRP4)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.FDSRP5)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.FDTROG)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.FDUSER)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.FDPID)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("C_F0921");
            this.Property(t => t.FDDOCO).HasColumnName("FDDOCO");
            this.Property(t => t.FDDCTO).HasColumnName("FDDCTO");
            this.Property(t => t.FDLNID).HasColumnName("FDLNID");
            this.Property(t => t.FDKCOO).HasColumnName("FDKCOO");
            this.Property(t => t.FDMCU).HasColumnName("FDMCU");
            this.Property(t => t.FDAID).HasColumnName("FDAID");
            this.Property(t => t.FDOBJ).HasColumnName("FDOBJ");
            this.Property(t => t.FDSUB).HasColumnName("FDSUB");
            this.Property(t => t.FDYAER).HasColumnName("FDYAER");
            this.Property(t => t.FDEFTJ).HasColumnName("FDEFTJ");
            this.Property(t => t.FDEDXJ).HasColumnName("FDEDXJ");
            this.Property(t => t.FDNAME).HasColumnName("FDNAME");
            this.Property(t => t.FDDSC1).HasColumnName("FDDSC1");
            this.Property(t => t.FDDSC2).HasColumnName("FDDSC2");
            this.Property(t => t.FDUPRC).HasColumnName("FDUPRC");
            this.Property(t => t.FDAPYN).HasColumnName("FDAPYN");
            this.Property(t => t.FDAWTD).HasColumnName("FDAWTD");
            this.Property(t => t.FDLTTR).HasColumnName("FDLTTR");
            this.Property(t => t.FDNXTR).HasColumnName("FDNXTR");
            this.Property(t => t.FDSRP1).HasColumnName("FDSRP1");
            this.Property(t => t.FDSRP2).HasColumnName("FDSRP2");
            this.Property(t => t.FDSRP3).HasColumnName("FDSRP3");
            this.Property(t => t.FDSRP4).HasColumnName("FDSRP4");
            this.Property(t => t.FDSRP5).HasColumnName("FDSRP5");
            this.Property(t => t.FDPRP1).HasColumnName("FDPRP1");
            this.Property(t => t.FDPRP2).HasColumnName("FDPRP2");
            this.Property(t => t.FDPRP3).HasColumnName("FDPRP3");
            this.Property(t => t.FDPRP4).HasColumnName("FDPRP4");
            this.Property(t => t.FDPRP5).HasColumnName("FDPRP5");
            this.Property(t => t.FDTROG).HasColumnName("FDTROG");
            this.Property(t => t.FDUSER).HasColumnName("FDUSER");
            this.Property(t => t.FDPID).HasColumnName("FDPID");
            this.Property(t => t.FDDATE).HasColumnName("FDDATE");
            this.Property(t => t.FDTIME).HasColumnName("FDTIME");
        }
    }
}
