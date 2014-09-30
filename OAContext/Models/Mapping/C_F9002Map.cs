using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace OAContext
{
    public class C_F9002Map : EntityTypeConfiguration<C_F9002>
    {
        public C_F9002Map()
        {
            // Primary Key
            this.HasKey(t => new { t.RPKCOO, t.RPRUID, t.RPMENUID });

            // Properties
            this.Property(t => t.RPKCOO)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.RPRUID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.RPMENUID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RPSRP1)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.RPSRP2)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.RPSRP3)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.RPSRP4)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.RPSRP5)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.RPUSER)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.RPPID)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("C_F9002");
            this.Property(t => t.RPKCOO).HasColumnName("RPKCOO");
            this.Property(t => t.RPRUID).HasColumnName("RPRUID");
            this.Property(t => t.RPMENUID).HasColumnName("RPMENUID");
            this.Property(t => t.RPPARENTID).HasColumnName("RPPARENTID");
            this.Property(t => t.RPAPID).HasColumnName("RPAPID");
            this.Property(t => t.RPBARNEW).HasColumnName("RPBARNEW");
            this.Property(t => t.RPBARSAVE).HasColumnName("RPBARSAVE");
            this.Property(t => t.RPBARSELECT).HasColumnName("RPBARSELECT");
            this.Property(t => t.RPBARDELETE).HasColumnName("RPBARDELETE");
            this.Property(t => t.RPBARCLOSE).HasColumnName("RPBARCLOSE");
            this.Property(t => t.RPBARFIND).HasColumnName("RPBARFIND");
            this.Property(t => t.RPBARSAVEAS).HasColumnName("RPBARSAVEAS");
            this.Property(t => t.RPSRP1).HasColumnName("RPSRP1");
            this.Property(t => t.RPSRP2).HasColumnName("RPSRP2");
            this.Property(t => t.RPSRP3).HasColumnName("RPSRP3");
            this.Property(t => t.RPSRP4).HasColumnName("RPSRP4");
            this.Property(t => t.RPSRP5).HasColumnName("RPSRP5");
            this.Property(t => t.RPPRP1).HasColumnName("RPPRP1");
            this.Property(t => t.RPPRP2).HasColumnName("RPPRP2");
            this.Property(t => t.RPPRP3).HasColumnName("RPPRP3");
            this.Property(t => t.RPPRP4).HasColumnName("RPPRP4");
            this.Property(t => t.RPPRP5).HasColumnName("RPPRP5");
            this.Property(t => t.RPUSER).HasColumnName("RPUSER");
            this.Property(t => t.RPPID).HasColumnName("RPPID");
            this.Property(t => t.RPDATE).HasColumnName("RPDATE");
            this.Property(t => t.RPTIME).HasColumnName("RPTIME");
        }
    }
}
