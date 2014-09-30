using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace OAContext
{
    public class C_F9005Map : EntityTypeConfiguration<C_F9005>
    {
        public C_F9005Map()
        {
            // Primary Key
            this.HasKey(t => new { t.APKCOO, t.APID });

            // Properties
            this.Property(t => t.APKCOO)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.APID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.APDEL1)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.APDEL2)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.APURL)
                .IsRequired();

            this.Property(t => t.APSRP1)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.APSRP2)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.APSRP3)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.APSRP4)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.APSRP5)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.APUSER)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.APPID)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("C_F9005");
            this.Property(t => t.APKCOO).HasColumnName("APKCOO");
            this.Property(t => t.APID).HasColumnName("APID");
            this.Property(t => t.APDEL1).HasColumnName("APDEL1");
            this.Property(t => t.APDEL2).HasColumnName("APDEL2");
            this.Property(t => t.APURL).HasColumnName("APURL");
            this.Property(t => t.APSRP1).HasColumnName("APSRP1");
            this.Property(t => t.APSRP2).HasColumnName("APSRP2");
            this.Property(t => t.APSRP3).HasColumnName("APSRP3");
            this.Property(t => t.APSRP4).HasColumnName("APSRP4");
            this.Property(t => t.APSRP5).HasColumnName("APSRP5");
            this.Property(t => t.APPRP1).HasColumnName("APPRP1");
            this.Property(t => t.APPRP2).HasColumnName("APPRP2");
            this.Property(t => t.APPRP3).HasColumnName("APPRP3");
            this.Property(t => t.APPRP4).HasColumnName("APPRP4");
            this.Property(t => t.APPRP5).HasColumnName("APPRP5");
            this.Property(t => t.APUSER).HasColumnName("APUSER");
            this.Property(t => t.APPID).HasColumnName("APPID");
            this.Property(t => t.APDATE).HasColumnName("APDATE");
            this.Property(t => t.APTIME).HasColumnName("APTIME");
        }
    }
}
