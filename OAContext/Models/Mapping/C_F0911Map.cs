using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace OAContext
{
    public class C_F0911Map : EntityTypeConfiguration<C_F0911>
    {
        public C_F0911Map()
        {
            // Primary Key
            this.HasKey(t => new { t.GLKCO, t.GLDCT, t.GLDOC, t.GLDGJ, t.GLLIND, t.GLLT });

            // Properties
            this.Property(t => t.GLKCO)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.GLDCT)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.GLDOC)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.GLLIND)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.GLEXTL)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.GLPOST)
                .HasMaxLength(1);

            this.Property(t => t.GLICUT)
                .HasMaxLength(2);

            this.Property(t => t.GLCO)
                .HasMaxLength(5);

            this.Property(t => t.GLANI)
                .HasMaxLength(29);

            this.Property(t => t.GLAM)
                .HasMaxLength(1);

            this.Property(t => t.GLAID)
                .HasMaxLength(8);

            this.Property(t => t.GLMCU)
                .HasMaxLength(12);

            this.Property(t => t.GLOBJ)
                .HasMaxLength(6);

            this.Property(t => t.GLSUB)
                .HasMaxLength(8);

            this.Property(t => t.GLSBL)
                .HasMaxLength(8);

            this.Property(t => t.GLSBLT)
                .HasMaxLength(1);

            this.Property(t => t.GLLT)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.GLFQ)
                .HasMaxLength(4);

            this.Property(t => t.GLCRCD)
                .HasMaxLength(3);

            this.Property(t => t.GLUM)
                .HasMaxLength(2);

            this.Property(t => t.GLRE)
                .HasMaxLength(1);

            this.Property(t => t.GLEXA)
                .HasMaxLength(30);

            this.Property(t => t.GLEXR)
                .HasMaxLength(30);

            this.Property(t => t.GLSRP1)
                .HasMaxLength(10);

            this.Property(t => t.GLSRP2)
                .HasMaxLength(10);

            this.Property(t => t.GLSRP3)
                .HasMaxLength(10);

            this.Property(t => t.GLSRP4)
                .HasMaxLength(10);

            this.Property(t => t.GLSRP5)
                .HasMaxLength(10);

            this.Property(t => t.GLSRP6)
                .HasMaxLength(10);

            this.Property(t => t.GLSRP7)
                .HasMaxLength(10);

            this.Property(t => t.GLSRP8)
                .HasMaxLength(10);

            this.Property(t => t.GLSRP9)
                .HasMaxLength(10);

            this.Property(t => t.GLSRP0)
                .HasMaxLength(10);

            this.Property(t => t.GLUSER)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.GLPID)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("C_F0911");
            this.Property(t => t.GLKCO).HasColumnName("GLKCO");
            this.Property(t => t.GLDCT).HasColumnName("GLDCT");
            this.Property(t => t.GLDOC).HasColumnName("GLDOC");
            this.Property(t => t.GLDGJ).HasColumnName("GLDGJ");
            this.Property(t => t.GLLIND).HasColumnName("GLLIND");
            this.Property(t => t.GLEXTL).HasColumnName("GLEXTL");
            this.Property(t => t.GLPOST).HasColumnName("GLPOST");
            this.Property(t => t.GLICU).HasColumnName("GLICU");
            this.Property(t => t.GLICUT).HasColumnName("GLICUT");
            this.Property(t => t.GLCO).HasColumnName("GLCO");
            this.Property(t => t.GLANI).HasColumnName("GLANI");
            this.Property(t => t.GLAM).HasColumnName("GLAM");
            this.Property(t => t.GLAID).HasColumnName("GLAID");
            this.Property(t => t.GLMCU).HasColumnName("GLMCU");
            this.Property(t => t.GLOBJ).HasColumnName("GLOBJ");
            this.Property(t => t.GLSUB).HasColumnName("GLSUB");
            this.Property(t => t.GLSBL).HasColumnName("GLSBL");
            this.Property(t => t.GLSBLT).HasColumnName("GLSBLT");
            this.Property(t => t.GLLT).HasColumnName("GLLT");
            this.Property(t => t.GLPN).HasColumnName("GLPN");
            this.Property(t => t.GLCTRY).HasColumnName("GLCTRY");
            this.Property(t => t.GLFY).HasColumnName("GLFY");
            this.Property(t => t.GLFQ).HasColumnName("GLFQ");
            this.Property(t => t.GLCRCD).HasColumnName("GLCRCD");
            this.Property(t => t.GLCRR).HasColumnName("GLCRR");
            this.Property(t => t.GLHCRR).HasColumnName("GLHCRR");
            this.Property(t => t.GLHDGJ).HasColumnName("GLHDGJ");
            this.Property(t => t.GLAA).HasColumnName("GLAA");
            this.Property(t => t.GLU).HasColumnName("GLU");
            this.Property(t => t.GLUM).HasColumnName("GLUM");
            this.Property(t => t.GLRE).HasColumnName("GLRE");
            this.Property(t => t.GLEXA).HasColumnName("GLEXA");
            this.Property(t => t.GLEXR).HasColumnName("GLEXR");
            this.Property(t => t.GLAN8).HasColumnName("GLAN8");
            this.Property(t => t.GLIVD).HasColumnName("GLIVD");
            this.Property(t => t.GLSRP1).HasColumnName("GLSRP1");
            this.Property(t => t.GLSRP2).HasColumnName("GLSRP2");
            this.Property(t => t.GLSRP3).HasColumnName("GLSRP3");
            this.Property(t => t.GLSRP4).HasColumnName("GLSRP4");
            this.Property(t => t.GLSRP5).HasColumnName("GLSRP5");
            this.Property(t => t.GLSRP6).HasColumnName("GLSRP6");
            this.Property(t => t.GLSRP7).HasColumnName("GLSRP7");
            this.Property(t => t.GLSRP8).HasColumnName("GLSRP8");
            this.Property(t => t.GLSRP9).HasColumnName("GLSRP9");
            this.Property(t => t.GLSRP0).HasColumnName("GLSRP0");
            this.Property(t => t.GLCLASS01).HasColumnName("GLCLASS01");
            this.Property(t => t.GLCLASS02).HasColumnName("GLCLASS02");
            this.Property(t => t.GLCLASS03).HasColumnName("GLCLASS03");
            this.Property(t => t.GLCLASS04).HasColumnName("GLCLASS04");
            this.Property(t => t.GLCLASS05).HasColumnName("GLCLASS05");
            this.Property(t => t.GLCLASS06).HasColumnName("GLCLASS06");
            this.Property(t => t.GLCLASS07).HasColumnName("GLCLASS07");
            this.Property(t => t.GLCLASS08).HasColumnName("GLCLASS08");
            this.Property(t => t.GLCLASS09).HasColumnName("GLCLASS09");
            this.Property(t => t.GLCLASS10).HasColumnName("GLCLASS10");
            this.Property(t => t.GLUSER).HasColumnName("GLUSER");
            this.Property(t => t.GLPID).HasColumnName("GLPID");
            this.Property(t => t.GLDATE).HasColumnName("GLDATE");
            this.Property(t => t.GLTIME).HasColumnName("GLTIME");
        }
    }
}
