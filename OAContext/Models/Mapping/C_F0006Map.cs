using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace OAContext
{
    public class C_F0006Map : EntityTypeConfiguration<C_F0006>
    {
        public C_F0006Map()
        {
            // Primary Key
            this.HasKey(t => new { t.MCKCOO, t.MCMCU });

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

            this.Property(t => t.MCDC)
                .IsRequired();

            this.Property(t => t.MCCO)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.MCPMCU)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.MCCNTY)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.MCADDS)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.MCFMOD)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.MCDL01)
                .IsRequired();

            this.Property(t => t.MCDL02)
                .IsRequired();

            this.Property(t => t.MCDL03)
                .IsRequired();

            this.Property(t => t.MCDL04)
                .IsRequired();

            this.Property(t => t.MCSRP1)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.MCSRP2)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.MCSRP3)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.MCSRP4)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.MCSRP5)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.MCUSER)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.MCPID)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("C_F0006");
            this.Property(t => t.MCKCOO).HasColumnName("MCKCOO");
            this.Property(t => t.MCMCU).HasColumnName("MCMCU");
            this.Property(t => t.MCSTYL).HasColumnName("MCSTYL");
            this.Property(t => t.MCDC).HasColumnName("MCDC");
            this.Property(t => t.MCLDM).HasColumnName("MCLDM");
            this.Property(t => t.MCCO).HasColumnName("MCCO");
            this.Property(t => t.MCPMCU).HasColumnName("MCPMCU");
            this.Property(t => t.MCAN8).HasColumnName("MCAN8");
            this.Property(t => t.MCAN8O).HasColumnName("MCAN8O");
            this.Property(t => t.MCCNTY).HasColumnName("MCCNTY");
            this.Property(t => t.MCADDS).HasColumnName("MCADDS");
            this.Property(t => t.MCFMOD).HasColumnName("MCFMOD");
            this.Property(t => t.MCDL01).HasColumnName("MCDL01");
            this.Property(t => t.MCDL02).HasColumnName("MCDL02");
            this.Property(t => t.MCDL03).HasColumnName("MCDL03");
            this.Property(t => t.MCDL04).HasColumnName("MCDL04");
            this.Property(t => t.MCSRP1).HasColumnName("MCSRP1");
            this.Property(t => t.MCSRP2).HasColumnName("MCSRP2");
            this.Property(t => t.MCSRP3).HasColumnName("MCSRP3");
            this.Property(t => t.MCSRP4).HasColumnName("MCSRP4");
            this.Property(t => t.MCSRP5).HasColumnName("MCSRP5");
            this.Property(t => t.MCPRP1).HasColumnName("MCPRP1");
            this.Property(t => t.MCPRP2).HasColumnName("MCPRP2");
            this.Property(t => t.MCPRP3).HasColumnName("MCPRP3");
            this.Property(t => t.MCPRP4).HasColumnName("MCPRP4");
            this.Property(t => t.MCPRP5).HasColumnName("MCPRP5");
            this.Property(t => t.MCUSER).HasColumnName("MCUSER");
            this.Property(t => t.MCPID).HasColumnName("MCPID");
            this.Property(t => t.MCDATE).HasColumnName("MCDATE");
            this.Property(t => t.MCTIME).HasColumnName("MCTIME");
        }
    }
}
