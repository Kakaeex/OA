using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace OAContext
{
    public class C_F2012Map : EntityTypeConfiguration<C_F2012>
    {
        public C_F2012Map()
        {
            // Primary Key
            this.HasKey(t => new { t.WFDOCO, t.WFDCTO, t.WFLNID });

            // Properties
            this.Property(t => t.WFDOCO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.WFDCTO)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.WFLNID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.WFCDCT)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.WFDEL1)
                .IsRequired()
                .HasMaxLength(300);

            this.Property(t => t.WFDEL2)
                .IsRequired()
                .HasMaxLength(300);

            this.Property(t => t.WFFDCT)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.WFDSC1)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.WFDSC2)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.WFVR01)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.WFVR02)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.WFSRP1)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.WFSRP2)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.WFSRP3)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.WFSRP4)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.WFSRP5)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.WFUSER)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.WFPID)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("C_F2012");
            this.Property(t => t.WFDOCO).HasColumnName("WFDOCO");
            this.Property(t => t.WFDCTO).HasColumnName("WFDCTO");
            this.Property(t => t.WFLNID).HasColumnName("WFLNID");
            this.Property(t => t.WFCDOC).HasColumnName("WFCDOC");
            this.Property(t => t.WFCDCT).HasColumnName("WFCDCT");
            this.Property(t => t.WFDEL1).HasColumnName("WFDEL1");
            this.Property(t => t.WFDEL2).HasColumnName("WFDEL2");
            this.Property(t => t.WFFDOC).HasColumnName("WFFDOC");
            this.Property(t => t.WFFDCT).HasColumnName("WFFDCT");
            this.Property(t => t.WFDSC1).HasColumnName("WFDSC1");
            this.Property(t => t.WFDSC2).HasColumnName("WFDSC2");
            this.Property(t => t.WFVR01).HasColumnName("WFVR01");
            this.Property(t => t.WFVR02).HasColumnName("WFVR02");
            this.Property(t => t.WFSRP1).HasColumnName("WFSRP1");
            this.Property(t => t.WFSRP2).HasColumnName("WFSRP2");
            this.Property(t => t.WFSRP3).HasColumnName("WFSRP3");
            this.Property(t => t.WFSRP4).HasColumnName("WFSRP4");
            this.Property(t => t.WFSRP5).HasColumnName("WFSRP5");
            this.Property(t => t.WFPRP1).HasColumnName("WFPRP1");
            this.Property(t => t.WFPRP2).HasColumnName("WFPRP2");
            this.Property(t => t.WFPRP3).HasColumnName("WFPRP3");
            this.Property(t => t.WFPRP4).HasColumnName("WFPRP4");
            this.Property(t => t.WFPRP5).HasColumnName("WFPRP5");
            this.Property(t => t.WFUSER).HasColumnName("WFUSER");
            this.Property(t => t.WFPID).HasColumnName("WFPID");
            this.Property(t => t.WFDATE).HasColumnName("WFDATE");
            this.Property(t => t.WFTIME).HasColumnName("WFTIME");
        }
    }
}
