using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace OAContext
{
    public class V_F0901AMap : EntityTypeConfiguration<V_F0901A>
    {
        public V_F0901AMap()
        {
            // Primary Key
            this.HasKey(t => new { t.GBFY, t.GBCTRY, t.GBLT, t.GBCO, t.GBMCU, t.GBAID });

            // Properties
            this.Property(t => t.GMLDA)
                .HasMaxLength(1);

            this.Property(t => t.GMR023)
                .HasMaxLength(10);

            this.Property(t => t.GBFY)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.GBCTRY)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.GBLT)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.GBCO)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.GBMCU)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.GBAID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.GBOBJ)
                .HasMaxLength(6);

            this.Property(t => t.GBSUB)
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("V_F0901A");
            this.Property(t => t.GMDL01).HasColumnName("GMDL01");
            this.Property(t => t.GMDL02).HasColumnName("GMDL02");
            this.Property(t => t.GMLDA).HasColumnName("GMLDA");
            this.Property(t => t.GMR023).HasColumnName("GMR023");
            this.Property(t => t.GBFY).HasColumnName("GBFY");
            this.Property(t => t.GBCTRY).HasColumnName("GBCTRY");
            this.Property(t => t.GBLT).HasColumnName("GBLT");
            this.Property(t => t.GBQ00).HasColumnName("GBQ00");
            this.Property(t => t.GBQ01).HasColumnName("GBQ01");
            this.Property(t => t.GBQ02).HasColumnName("GBQ02");
            this.Property(t => t.GBQ03).HasColumnName("GBQ03");
            this.Property(t => t.GBQ04).HasColumnName("GBQ04");
            this.Property(t => t.GBQ05).HasColumnName("GBQ05");
            this.Property(t => t.GBAPYN).HasColumnName("GBAPYN");
            this.Property(t => t.GBAWTD).HasColumnName("GBAWTD");
            this.Property(t => t.GBBORG).HasColumnName("GBBORG");
            this.Property(t => t.GBCO).HasColumnName("GBCO");
            this.Property(t => t.GBMCU).HasColumnName("GBMCU");
            this.Property(t => t.GBAID).HasColumnName("GBAID");
            this.Property(t => t.GBOBJ).HasColumnName("GBOBJ");
            this.Property(t => t.GBSUB).HasColumnName("GBSUB");
        }
    }
}
