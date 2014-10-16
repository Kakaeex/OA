using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace OAContext
{
    public class C_F0902Map : EntityTypeConfiguration<C_F0902>
    {
        public C_F0902Map()
        {
            // Primary Key
            this.HasKey(t => new { t.GBCO, t.GBMCU, t.GBAID, t.GBCTRY, t.GBFY, t.GBLT });

            // Properties
            this.Property(t => t.GBCO)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.GBMCU)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.GBAID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.GBCTRY)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.GBFY)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.GBLT)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.GBOBJ)
                .HasMaxLength(6);

            this.Property(t => t.GBSUB)
                .HasMaxLength(8);

            this.Property(t => t.GBUSER)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.GBPID)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("C_F0902");
            this.Property(t => t.GBCO).HasColumnName("GBCO");
            this.Property(t => t.GBMCU).HasColumnName("GBMCU");
            this.Property(t => t.GBAID).HasColumnName("GBAID");
            this.Property(t => t.GBCTRY).HasColumnName("GBCTRY");
            this.Property(t => t.GBFY).HasColumnName("GBFY");
            this.Property(t => t.GBLT).HasColumnName("GBLT");
            this.Property(t => t.GBOBJ).HasColumnName("GBOBJ");
            this.Property(t => t.GBSUB).HasColumnName("GBSUB");
            this.Property(t => t.GBAPYC).HasColumnName("GBAPYC");
            this.Property(t => t.GBAN01).HasColumnName("GBAN01");
            this.Property(t => t.GBAN02).HasColumnName("GBAN02");
            this.Property(t => t.GBAN03).HasColumnName("GBAN03");
            this.Property(t => t.GBAN04).HasColumnName("GBAN04");
            this.Property(t => t.GBAN05).HasColumnName("GBAN05");
            this.Property(t => t.GBAN06).HasColumnName("GBAN06");
            this.Property(t => t.GBAN07).HasColumnName("GBAN07");
            this.Property(t => t.GBAN08).HasColumnName("GBAN08");
            this.Property(t => t.GBAN09).HasColumnName("GBAN09");
            this.Property(t => t.GBAN10).HasColumnName("GBAN10");
            this.Property(t => t.GBAN11).HasColumnName("GBAN11");
            this.Property(t => t.GBAN12).HasColumnName("GBAN12");
            this.Property(t => t.GBAN13).HasColumnName("GBAN13");
            this.Property(t => t.GBAN14).HasColumnName("GBAN14");
            this.Property(t => t.GBQ00).HasColumnName("GBQ00");
            this.Property(t => t.GBQ01).HasColumnName("GBQ01");
            this.Property(t => t.GBQ02).HasColumnName("GBQ02");
            this.Property(t => t.GBQ03).HasColumnName("GBQ03");
            this.Property(t => t.GBQ04).HasColumnName("GBQ04");
            this.Property(t => t.GBQ05).HasColumnName("GBQ05");
            this.Property(t => t.GBAPYN).HasColumnName("GBAPYN");
            this.Property(t => t.GBAWTD).HasColumnName("GBAWTD");
            this.Property(t => t.GBBORG).HasColumnName("GBBORG");
            this.Property(t => t.GBPOU).HasColumnName("GBPOU");
            this.Property(t => t.GBPC).HasColumnName("GBPC");
            this.Property(t => t.GBTKER).HasColumnName("GBTKER");
            this.Property(t => t.GBBREQ).HasColumnName("GBBREQ");
            this.Property(t => t.GBBAPR).HasColumnName("GBBAPR");
            this.Property(t => t.GBUSER).HasColumnName("GBUSER");
            this.Property(t => t.GBPID).HasColumnName("GBPID");
            this.Property(t => t.GBDATE).HasColumnName("GBDATE");
            this.Property(t => t.GBTIME).HasColumnName("GBTIME");
        }
    }
}
