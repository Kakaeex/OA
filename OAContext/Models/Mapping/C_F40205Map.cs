using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace OAContext
{
    public class C_F40205Map : EntityTypeConfiguration<C_F40205>
    {
        public C_F40205Map()
        {
            // Primary Key
            this.HasKey(t => t.LFLNTY);

            // Properties
            this.Property(t => t.LFLNTY)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.LFLNDS)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.LFLND2)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.LFSRP1)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.LFSRP2)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.LFSRP3)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.LFSRP4)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.LFSRP5)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.LFSRP6)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.LFSRP7)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.LFSRP8)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.LFSRP9)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.LFSRP0)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.LFCLASS01)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.LFCLASS02)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.LFCLASS03)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.LFCLASS04)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.LFCLASS05)
                .IsRequired()
                .HasMaxLength(7);

            this.Property(t => t.LFCLASS06)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.LFCLASS07)
                .IsRequired()
                .HasMaxLength(9);

            this.Property(t => t.LFCLASS08)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.LFCLASS09)
                .IsRequired()
                .HasMaxLength(11);

            this.Property(t => t.LFCLASS10)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.LFUSER)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.LFPID)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("C_F40205");
            this.Property(t => t.LFLNTY).HasColumnName("LFLNTY");
            this.Property(t => t.LFLNDS).HasColumnName("LFLNDS");
            this.Property(t => t.LFLND2).HasColumnName("LFLND2");
            this.Property(t => t.LFSRP1).HasColumnName("LFSRP1");
            this.Property(t => t.LFSRP2).HasColumnName("LFSRP2");
            this.Property(t => t.LFSRP3).HasColumnName("LFSRP3");
            this.Property(t => t.LFSRP4).HasColumnName("LFSRP4");
            this.Property(t => t.LFSRP5).HasColumnName("LFSRP5");
            this.Property(t => t.LFSRP6).HasColumnName("LFSRP6");
            this.Property(t => t.LFSRP7).HasColumnName("LFSRP7");
            this.Property(t => t.LFSRP8).HasColumnName("LFSRP8");
            this.Property(t => t.LFSRP9).HasColumnName("LFSRP9");
            this.Property(t => t.LFSRP0).HasColumnName("LFSRP0");
            this.Property(t => t.LFCLASS01).HasColumnName("LFCLASS01");
            this.Property(t => t.LFCLASS02).HasColumnName("LFCLASS02");
            this.Property(t => t.LFCLASS03).HasColumnName("LFCLASS03");
            this.Property(t => t.LFCLASS04).HasColumnName("LFCLASS04");
            this.Property(t => t.LFCLASS05).HasColumnName("LFCLASS05");
            this.Property(t => t.LFCLASS06).HasColumnName("LFCLASS06");
            this.Property(t => t.LFCLASS07).HasColumnName("LFCLASS07");
            this.Property(t => t.LFCLASS08).HasColumnName("LFCLASS08");
            this.Property(t => t.LFCLASS09).HasColumnName("LFCLASS09");
            this.Property(t => t.LFCLASS10).HasColumnName("LFCLASS10");
            this.Property(t => t.LFPRP1).HasColumnName("LFPRP1");
            this.Property(t => t.LFPRP2).HasColumnName("LFPRP2");
            this.Property(t => t.LFPRP3).HasColumnName("LFPRP3");
            this.Property(t => t.LFPRP4).HasColumnName("LFPRP4");
            this.Property(t => t.LFPRP5).HasColumnName("LFPRP5");
            this.Property(t => t.LFPRP6).HasColumnName("LFPRP6");
            this.Property(t => t.LFPRP7).HasColumnName("LFPRP7");
            this.Property(t => t.LFPRP8).HasColumnName("LFPRP8");
            this.Property(t => t.LFPRP9).HasColumnName("LFPRP9");
            this.Property(t => t.LFPRP0).HasColumnName("LFPRP0");
            this.Property(t => t.LFUSER).HasColumnName("LFUSER");
            this.Property(t => t.LFPID).HasColumnName("LFPID");
            this.Property(t => t.LFDATE).HasColumnName("LFDATE");
            this.Property(t => t.LFTIME).HasColumnName("LFTIME");
        }
    }
}
