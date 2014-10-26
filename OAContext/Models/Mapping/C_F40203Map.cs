using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace OAContext
{
    public class C_F40203Map : EntityTypeConfiguration<C_F40203>
    {
        public C_F40203Map()
        {
            // Primary Key
            this.HasKey(t => new { t.FSDCTO, t.FSTRTY, t.FSLNTY });

            // Properties
            this.Property(t => t.FSDCTO)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.FSTRTY)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.FSDEL1)
                .IsRequired()
                .HasMaxLength(300);

            this.Property(t => t.FSDEL2)
                .IsRequired()
                .HasMaxLength(300);

            this.Property(t => t.FSLNTY)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.FSLNDS)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.FSLND2)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.FSNXTR)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.FSA1TR)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.FSA2TR)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.FSA3TR)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.FSA4TR)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.FSA5TR)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.FSWRTH)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.FSUSER)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.FSPID)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("C_F40203");
            this.Property(t => t.FSDCTO).HasColumnName("FSDCTO");
            this.Property(t => t.FSTRTY).HasColumnName("FSTRTY");
            this.Property(t => t.FSDEL1).HasColumnName("FSDEL1");
            this.Property(t => t.FSDEL2).HasColumnName("FSDEL2");
            this.Property(t => t.FSLNTY).HasColumnName("FSLNTY");
            this.Property(t => t.FSLNDS).HasColumnName("FSLNDS");
            this.Property(t => t.FSLND2).HasColumnName("FSLND2");
            this.Property(t => t.FSNXTR).HasColumnName("FSNXTR");
            this.Property(t => t.FSA1TR).HasColumnName("FSA1TR");
            this.Property(t => t.FSA2TR).HasColumnName("FSA2TR");
            this.Property(t => t.FSA3TR).HasColumnName("FSA3TR");
            this.Property(t => t.FSA4TR).HasColumnName("FSA4TR");
            this.Property(t => t.FSA5TR).HasColumnName("FSA5TR");
            this.Property(t => t.FSWRTH).HasColumnName("FSWRTH");
            this.Property(t => t.FSORNN).HasColumnName("FSORNN");
            this.Property(t => t.FSUSER).HasColumnName("FSUSER");
            this.Property(t => t.FSPID).HasColumnName("FSPID");
            this.Property(t => t.FSDATE).HasColumnName("FSDATE");
            this.Property(t => t.FSTIME).HasColumnName("FSTIME");
        }
    }
}
