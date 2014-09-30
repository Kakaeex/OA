using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EPMContext
{
    public class HP_ESS_ODS_BUDEXP_OAMap : EntityTypeConfiguration<HP_ESS_ODS_BUDEXP_OA>
    {
        public HP_ESS_ODS_BUDEXP_OAMap()
        {
            // Primary Key
            this.HasKey(t => new { t.SORTID, t.HP_ENTITY, t.HP_ACCOUNT, t.HP_YEAR, t.HP_PERIOD, t.HP_CURRENCY, t.HP_DETAIL, t.HP_MODEL, t.HP_PROJECT, t.HP_SCENARIO, t.HP_VERSION, t.HSP_RATES });

            // Properties
            this.Property(t => t.SORTID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.HP_ENTITY)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.HP_ACCOUNT)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.HP_YEAR)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.HP_PERIOD)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.HP_CURRENCY)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.HP_DETAIL)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.HP_MODEL)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.HP_PROJECT)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.HP_SCENARIO)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.HP_VERSION)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.HSP_RATES)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("HP_ESS_ODS_BUDEXP_OA", "EPM_ODS");
            this.Property(t => t.SORTID).HasColumnName("SORTID");
            this.Property(t => t.HP_ENTITY).HasColumnName("HP_ENTITY");
            this.Property(t => t.HP_ACCOUNT).HasColumnName("HP_ACCOUNT");
            this.Property(t => t.HP_YEAR).HasColumnName("HP_YEAR");
            this.Property(t => t.HP_PERIOD).HasColumnName("HP_PERIOD");
            this.Property(t => t.HP_CURRENCY).HasColumnName("HP_CURRENCY");
            this.Property(t => t.HP_DETAIL).HasColumnName("HP_DETAIL");
            this.Property(t => t.HP_MODEL).HasColumnName("HP_MODEL");
            this.Property(t => t.HP_PROJECT).HasColumnName("HP_PROJECT");
            this.Property(t => t.HP_SCENARIO).HasColumnName("HP_SCENARIO");
            this.Property(t => t.HP_VERSION).HasColumnName("HP_VERSION");
            this.Property(t => t.HSP_RATES).HasColumnName("HSP_RATES");
            this.Property(t => t.HP_DATA).HasColumnName("HP_DATA");
            this.Property(t => t.DATA_INSERT_TIME).HasColumnName("DATA_INSERT_TIME");
        }
    }
}
