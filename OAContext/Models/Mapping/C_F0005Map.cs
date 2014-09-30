using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace OAContext
{
    public class C_F0005Map : EntityTypeConfiguration<C_F0005>
    {
        public C_F0005Map()
        {
            // Primary Key
            this.HasKey(t => new { t.DRKCOO, t.DRLNGP, t.DRSY, t.DRRT, t.DRKY });

            // Properties
            this.Property(t => t.DRKCOO)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.DRLNGP)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.DRSY)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.DRRT)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.DRKY)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.DRDEL1)
                .IsRequired();

            this.Property(t => t.DRDEL2)
                .IsRequired();

            this.Property(t => t.DRSRP1)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.DRSRP2)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.DRSRP3)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.DRSRP4)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.DRSRP5)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.DRUSER)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.DRPID)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("C_F0005");
            this.Property(t => t.DRKCOO).HasColumnName("DRKCOO");
            this.Property(t => t.DRLNGP).HasColumnName("DRLNGP");
            this.Property(t => t.DRSY).HasColumnName("DRSY");
            this.Property(t => t.DRRT).HasColumnName("DRRT");
            this.Property(t => t.DRKY).HasColumnName("DRKY");
            this.Property(t => t.DRDEL1).HasColumnName("DRDEL1");
            this.Property(t => t.DRDEL2).HasColumnName("DRDEL2");
            this.Property(t => t.DRSRP1).HasColumnName("DRSRP1");
            this.Property(t => t.DRSRP2).HasColumnName("DRSRP2");
            this.Property(t => t.DRSRP3).HasColumnName("DRSRP3");
            this.Property(t => t.DRSRP4).HasColumnName("DRSRP4");
            this.Property(t => t.DRSRP5).HasColumnName("DRSRP5");
            this.Property(t => t.DRPRP1).HasColumnName("DRPRP1");
            this.Property(t => t.DRPRP2).HasColumnName("DRPRP2");
            this.Property(t => t.DRPRP3).HasColumnName("DRPRP3");
            this.Property(t => t.DRPRP4).HasColumnName("DRPRP4");
            this.Property(t => t.DRPRP5).HasColumnName("DRPRP5");
            this.Property(t => t.DRUSER).HasColumnName("DRUSER");
            this.Property(t => t.DRPID).HasColumnName("DRPID");
            this.Property(t => t.DRDATE).HasColumnName("DRDATE");
            this.Property(t => t.DRTIME).HasColumnName("DRTIME");
        }
    }
}
