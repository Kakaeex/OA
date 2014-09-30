using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EPMContext
{
    public class HP_PLN_ODS_MODEL_TEXTMap : EntityTypeConfiguration<HP_PLN_ODS_MODEL_TEXT>
    {
        public HP_PLN_ODS_MODEL_TEXTMap()
        {
            // Primary Key
            this.HasKey(t => new { t.TEXT_ID, t.TEXT_VALUE });

            // Properties
            this.Property(t => t.TEXT_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.TEXT_VALUE)
                .IsRequired()
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("HP_PLN_ODS_MODEL_TEXT", "EPM_ODS");
            this.Property(t => t.TEXT_ID).HasColumnName("TEXT_ID");
            this.Property(t => t.TEXT_VALUE).HasColumnName("TEXT_VALUE");
            this.Property(t => t.DATA_INSERT_TIME).HasColumnName("DATA_INSERT_TIME");
        }
    }
}
