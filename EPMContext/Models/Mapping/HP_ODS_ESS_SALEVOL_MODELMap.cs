using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EPMContext
{
    public class HP_ODS_ESS_SALEVOL_MODELMap : EntityTypeConfiguration<HP_ODS_ESS_SALEVOL_MODEL>
    {
        public HP_ODS_ESS_SALEVOL_MODELMap()
        {
            // Primary Key
            this.HasKey(t => new { t.JDE_SORTID, t.HP_ENTITY, t.HP_ACCOUNT, t.HP_YEAR, t.HP_PERIOD, t.HP_CURRENCY, t.HP_DETAIL, t.HP_MODEL, t.HP_PROJECT, t.HP_SCENARIO, t.HP_VERSION });

            // Properties
            this.Property(t => t.JDE_SORTID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.HP_ENTITY)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.HP_ACCOUNT)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.HP_YEAR)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.HP_PERIOD)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.HP_CURRENCY)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.HP_DETAIL)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.HP_MODEL)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.HP_PROJECT)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.HP_SCENARIO)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.HP_VERSION)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.JDE_UPDATE_TIME)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("HP_ODS_ESS_SALEVOL_MODEL", "EPM_ODS");
            this.Property(t => t.JDE_SORTID).HasColumnName("JDE_SORTID");
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
            this.Property(t => t.HP_DATA).HasColumnName("HP_DATA");
            this.Property(t => t.JDE_UPDATE_TIME).HasColumnName("JDE_UPDATE_TIME");
            this.Property(t => t.DATA_INSERT_TIME).HasColumnName("DATA_INSERT_TIME");
        }
    }
}
