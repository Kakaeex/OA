using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace OAContext
{
    public class V_F0901BMap : EntityTypeConfiguration<V_F0901B>
    {
        public V_F0901BMap()
        {
            // Primary Key
            this.HasKey(t => t.GBAID);

            // Properties
            this.Property(t => t.GMCO)
                .HasMaxLength(5);

            this.Property(t => t.GBAID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.GMPAID)
                .HasMaxLength(20);

            this.Property(t => t.GMMCU)
                .HasMaxLength(12);

            this.Property(t => t.GMOBJ)
                .HasMaxLength(6);

            this.Property(t => t.GMSUB)
                .HasMaxLength(8);

            this.Property(t => t.GMANS)
                .HasMaxLength(25);

            this.Property(t => t.GMLDA)
                .HasMaxLength(1);

            this.Property(t => t.GMR023)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("V_F0901B");
            this.Property(t => t.GMCO).HasColumnName("GMCO");
            this.Property(t => t.GBAID).HasColumnName("GBAID");
            this.Property(t => t.GMPAID).HasColumnName("GMPAID");
            this.Property(t => t.GMMCU).HasColumnName("GMMCU");
            this.Property(t => t.GMOBJ).HasColumnName("GMOBJ");
            this.Property(t => t.GMSUB).HasColumnName("GMSUB");
            this.Property(t => t.GMANS).HasColumnName("GMANS");
            this.Property(t => t.GMDL01).HasColumnName("GMDL01");
            this.Property(t => t.GMDL02).HasColumnName("GMDL02");
            this.Property(t => t.GMLDA).HasColumnName("GMLDA");
            this.Property(t => t.GMR023).HasColumnName("GMR023");
        }
    }
}
