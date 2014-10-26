using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace OAContext
{
    public class C_F0903Map : EntityTypeConfiguration<C_F0903>
    {
        public C_F0903Map()
        {
            // Primary Key
            this.HasKey(t => new { t.GDMAID, t.GDFAID });

            // Properties
            this.Property(t => t.GDMAID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.GDMMCU)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.GDMOBJ)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.GDMSUB)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.GDMDL01)
                .IsRequired();

            this.Property(t => t.GDMDL02)
                .IsRequired();

            this.Property(t => t.GDFAID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.GDFMCU)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.GDFOBJ)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.GDFSUB)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.GDFDL01)
                .IsRequired();

            this.Property(t => t.GDFDL02)
                .IsRequired();

            this.Property(t => t.GDSRP1)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.GDSRP2)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.GDSRP3)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.GDSRP4)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.GDSRP5)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.GDUSER)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.GDPID)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("C_F0903");
            this.Property(t => t.GDMAID).HasColumnName("GDMAID");
            this.Property(t => t.GDMMCU).HasColumnName("GDMMCU");
            this.Property(t => t.GDMOBJ).HasColumnName("GDMOBJ");
            this.Property(t => t.GDMSUB).HasColumnName("GDMSUB");
            this.Property(t => t.GDMDL01).HasColumnName("GDMDL01");
            this.Property(t => t.GDMDL02).HasColumnName("GDMDL02");
            this.Property(t => t.GDFAID).HasColumnName("GDFAID");
            this.Property(t => t.GDFMCU).HasColumnName("GDFMCU");
            this.Property(t => t.GDFOBJ).HasColumnName("GDFOBJ");
            this.Property(t => t.GDFSUB).HasColumnName("GDFSUB");
            this.Property(t => t.GDFDL01).HasColumnName("GDFDL01");
            this.Property(t => t.GDFDL02).HasColumnName("GDFDL02");
            this.Property(t => t.GDSRP1).HasColumnName("GDSRP1");
            this.Property(t => t.GDSRP2).HasColumnName("GDSRP2");
            this.Property(t => t.GDSRP3).HasColumnName("GDSRP3");
            this.Property(t => t.GDSRP4).HasColumnName("GDSRP4");
            this.Property(t => t.GDSRP5).HasColumnName("GDSRP5");
            this.Property(t => t.GDPRP1).HasColumnName("GDPRP1");
            this.Property(t => t.GDPRP2).HasColumnName("GDPRP2");
            this.Property(t => t.GDPRP3).HasColumnName("GDPRP3");
            this.Property(t => t.GDPRP4).HasColumnName("GDPRP4");
            this.Property(t => t.GDPRP5).HasColumnName("GDPRP5");
            this.Property(t => t.GDUSER).HasColumnName("GDUSER");
            this.Property(t => t.GDPID).HasColumnName("GDPID");
            this.Property(t => t.GDDATE).HasColumnName("GDDATE");
            this.Property(t => t.GDTIME).HasColumnName("GDTIME");
        }
    }
}
