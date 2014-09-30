using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace OAContext
{
    public class C_F2000Map : EntityTypeConfiguration<C_F2000>
    {
        public C_F2000Map()
        {
            // Primary Key
            this.HasKey(t => new { t.WHKCOO, t.WHDOCO, t.WHDCTO });

            // Properties
            this.Property(t => t.WHKCOO)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.WHDOCO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.WHDCTO)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.WHDSC1)
                .HasMaxLength(30);

            this.Property(t => t.WHDSC2)
                .HasMaxLength(30);

            this.Property(t => t.WHDCT)
                .HasMaxLength(10);

            this.Property(t => t.WHVR01)
                .HasMaxLength(30);

            this.Property(t => t.WHVR02)
                .HasMaxLength(30);

            this.Property(t => t.WHSRP1)
                .HasMaxLength(10);

            this.Property(t => t.WHSRP2)
                .HasMaxLength(10);

            this.Property(t => t.WHSRP3)
                .HasMaxLength(10);

            this.Property(t => t.WHSRP4)
                .HasMaxLength(10);

            this.Property(t => t.WHSRP5)
                .HasMaxLength(10);

            this.Property(t => t.WHUSER)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.WHPID)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("C_F2000");
            this.Property(t => t.WHKCOO).HasColumnName("WHKCOO");
            this.Property(t => t.WHDOCO).HasColumnName("WHDOCO");
            this.Property(t => t.WHDCTO).HasColumnName("WHDCTO");
            this.Property(t => t.WHDSC1).HasColumnName("WHDSC1");
            this.Property(t => t.WHDSC2).HasColumnName("WHDSC2");
            this.Property(t => t.WHDCT).HasColumnName("WHDCT");
            this.Property(t => t.WHTRDJ).HasColumnName("WHTRDJ");
            this.Property(t => t.WHDRQJ).HasColumnName("WHDRQJ");
            this.Property(t => t.WHPDDJ).HasColumnName("WHPDDJ");
            this.Property(t => t.WHADDJ).HasColumnName("WHADDJ");
            this.Property(t => t.WHCNDJ).HasColumnName("WHCNDJ");
            this.Property(t => t.WHUPRC).HasColumnName("WHUPRC");
            this.Property(t => t.WHAEXP).HasColumnName("WHAEXP");
            this.Property(t => t.WHUNCS).HasColumnName("WHUNCS");
            this.Property(t => t.WHECST).HasColumnName("WHECST");
            this.Property(t => t.WHSOQS).HasColumnName("WHSOQS");
            this.Property(t => t.WHUORG).HasColumnName("WHUORG");
            this.Property(t => t.WHVR01).HasColumnName("WHVR01");
            this.Property(t => t.WHVR02).HasColumnName("WHVR02");
            this.Property(t => t.WHSRP1).HasColumnName("WHSRP1");
            this.Property(t => t.WHSRP2).HasColumnName("WHSRP2");
            this.Property(t => t.WHSRP3).HasColumnName("WHSRP3");
            this.Property(t => t.WHSRP4).HasColumnName("WHSRP4");
            this.Property(t => t.WHSRP5).HasColumnName("WHSRP5");
            this.Property(t => t.WHPRP1).HasColumnName("WHPRP1");
            this.Property(t => t.WHPRP2).HasColumnName("WHPRP2");
            this.Property(t => t.WHPRP3).HasColumnName("WHPRP3");
            this.Property(t => t.WHPRP4).HasColumnName("WHPRP4");
            this.Property(t => t.WHPRP5).HasColumnName("WHPRP5");
            this.Property(t => t.WHUSER).HasColumnName("WHUSER");
            this.Property(t => t.WHPID).HasColumnName("WHPID");
            this.Property(t => t.WHDATE).HasColumnName("WHDATE");
            this.Property(t => t.WHTIME).HasColumnName("WHTIME");
        }
    }
}
