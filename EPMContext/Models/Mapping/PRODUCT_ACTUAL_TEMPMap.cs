using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EPMContext
{
    public class PRODUCT_ACTUAL_TEMPMap : EntityTypeConfiguration<PRODUCT_ACTUAL_TEMP>
    {
        public PRODUCT_ACTUAL_TEMPMap()
        {
            // Primary Key
            this.HasKey(t => t.IMITM);

            // Properties
            this.Property(t => t.LITM)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.JDE_BRAND_ID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.JDE_BRAND_DESC)
                .HasMaxLength(200);

            this.Property(t => t.JDE_MODEL_ID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.JDE_MODEL_DESC)
                .HasMaxLength(200);

            this.Property(t => t.JDE_SPEC_ID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.JDE_SPEC_DESC)
                .HasMaxLength(200);

            this.Property(t => t.LAST_UPDATE_TIME)
                .HasMaxLength(50);

            this.Property(t => t.IMITM)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.IMDSC1)
                .HasMaxLength(30);

            this.Property(t => t.IMDSC2)
                .HasMaxLength(30);

            this.Property(t => t.IMSRTX)
                .HasMaxLength(30);

            this.Property(t => t.IMSRP1)
                .HasMaxLength(3);

            this.Property(t => t.IMSRP2)
                .HasMaxLength(3);

            this.Property(t => t.IMSRP3)
                .HasMaxLength(3);

            this.Property(t => t.IMSRP4)
                .HasMaxLength(3);

            this.Property(t => t.IMSRP5)
                .HasMaxLength(3);

            this.Property(t => t.IMPRP1)
                .HasMaxLength(3);

            this.Property(t => t.IMPRP2)
                .HasMaxLength(3);

            this.Property(t => t.IMPRP3)
                .HasMaxLength(3);

            this.Property(t => t.IMPRP4)
                .HasMaxLength(3);

            this.Property(t => t.IMPRP5)
                .HasMaxLength(3);

            // Table & Column Mappings
            this.ToTable("PRODUCT_ACTUAL_TEMP", "EPM_ODS");
            this.Property(t => t.SORTID).HasColumnName("SORTID");
            this.Property(t => t.LITM).HasColumnName("LITM");
            this.Property(t => t.JDE_BRAND_ID).HasColumnName("JDE_BRAND_ID");
            this.Property(t => t.JDE_BRAND_DESC).HasColumnName("JDE_BRAND_DESC");
            this.Property(t => t.JDE_MODEL_ID).HasColumnName("JDE_MODEL_ID");
            this.Property(t => t.JDE_MODEL_DESC).HasColumnName("JDE_MODEL_DESC");
            this.Property(t => t.JDE_SPEC_ID).HasColumnName("JDE_SPEC_ID");
            this.Property(t => t.JDE_SPEC_DESC).HasColumnName("JDE_SPEC_DESC");
            this.Property(t => t.LAST_UPDATE_TIME).HasColumnName("LAST_UPDATE_TIME");
            this.Property(t => t.IMITM).HasColumnName("IMITM");
            this.Property(t => t.IMDSC1).HasColumnName("IMDSC1");
            this.Property(t => t.IMDSC2).HasColumnName("IMDSC2");
            this.Property(t => t.IMSRTX).HasColumnName("IMSRTX");
            this.Property(t => t.IMSRP1).HasColumnName("IMSRP1");
            this.Property(t => t.IMSRP2).HasColumnName("IMSRP2");
            this.Property(t => t.IMSRP3).HasColumnName("IMSRP3");
            this.Property(t => t.IMSRP4).HasColumnName("IMSRP4");
            this.Property(t => t.IMSRP5).HasColumnName("IMSRP5");
            this.Property(t => t.IMPRP1).HasColumnName("IMPRP1");
            this.Property(t => t.IMPRP2).HasColumnName("IMPRP2");
            this.Property(t => t.IMPRP3).HasColumnName("IMPRP3");
            this.Property(t => t.IMPRP4).HasColumnName("IMPRP4");
            this.Property(t => t.IMPRP5).HasColumnName("IMPRP5");
        }
    }
}
