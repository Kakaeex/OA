using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace OAContext
{
    public class C_F0010Map : EntityTypeConfiguration<C_F0010>
    {
        public C_F0010Map()
        {
            // Primary Key
            this.HasKey(t => t.CCCO);

            // Properties
            this.Property(t => t.CCCO)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.CCNAME)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.CCDSC1)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.CCDSC2)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.CCCRCD)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.CCADDZ)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.CCCTY1)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.CCCOUN)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.CCADDS)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.CCSRP1)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.CCSRP2)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.CCSRP3)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.CCSRP4)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.CCSRP5)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.CCSRP6)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.CCSRP7)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.CCSRP8)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.CCSRP9)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.CCSRP0)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.CCUSER)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.CCPID)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("C_F0010");
            this.Property(t => t.CCCO).HasColumnName("CCCO");
            this.Property(t => t.CCNAME).HasColumnName("CCNAME");
            this.Property(t => t.CCDSC1).HasColumnName("CCDSC1");
            this.Property(t => t.CCDSC2).HasColumnName("CCDSC2");
            this.Property(t => t.CCCTRY).HasColumnName("CCCTRY");
            this.Property(t => t.CCFY).HasColumnName("CCFY");
            this.Property(t => t.CCCRCD).HasColumnName("CCCRCD");
            this.Property(t => t.CCAN8).HasColumnName("CCAN8");
            this.Property(t => t.CCADDZ).HasColumnName("CCADDZ");
            this.Property(t => t.CCCTY1).HasColumnName("CCCTY1");
            this.Property(t => t.CCCOUN).HasColumnName("CCCOUN");
            this.Property(t => t.CCADDS).HasColumnName("CCADDS");
            this.Property(t => t.CCSRP1).HasColumnName("CCSRP1");
            this.Property(t => t.CCSRP2).HasColumnName("CCSRP2");
            this.Property(t => t.CCSRP3).HasColumnName("CCSRP3");
            this.Property(t => t.CCSRP4).HasColumnName("CCSRP4");
            this.Property(t => t.CCSRP5).HasColumnName("CCSRP5");
            this.Property(t => t.CCSRP6).HasColumnName("CCSRP6");
            this.Property(t => t.CCSRP7).HasColumnName("CCSRP7");
            this.Property(t => t.CCSRP8).HasColumnName("CCSRP8");
            this.Property(t => t.CCSRP9).HasColumnName("CCSRP9");
            this.Property(t => t.CCSRP0).HasColumnName("CCSRP0");
            this.Property(t => t.CCPRP1).HasColumnName("CCPRP1");
            this.Property(t => t.CCPRP2).HasColumnName("CCPRP2");
            this.Property(t => t.CCPRP3).HasColumnName("CCPRP3");
            this.Property(t => t.CCPRP4).HasColumnName("CCPRP4");
            this.Property(t => t.CCPRP5).HasColumnName("CCPRP5");
            this.Property(t => t.CCPRP6).HasColumnName("CCPRP6");
            this.Property(t => t.CCPRP7).HasColumnName("CCPRP7");
            this.Property(t => t.CCPRP8).HasColumnName("CCPRP8");
            this.Property(t => t.CCPRP9).HasColumnName("CCPRP9");
            this.Property(t => t.CCPRP0).HasColumnName("CCPRP0");
            this.Property(t => t.CCUSER).HasColumnName("CCUSER");
            this.Property(t => t.CCPID).HasColumnName("CCPID");
            this.Property(t => t.CCDATE).HasColumnName("CCDATE");
            this.Property(t => t.CCTIME).HasColumnName("CCTIME");
        }
    }
}
