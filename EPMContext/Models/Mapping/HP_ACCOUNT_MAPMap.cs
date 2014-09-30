using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EPMContext
{
    public class HP_ACCOUNT_MAPMap : EntityTypeConfiguration<HP_ACCOUNT_MAP>
    {
        public HP_ACCOUNT_MAPMap()
        {
            // Primary Key
            this.HasKey(t => t.JDE_ACCOUNT_ID);

            // Properties
            this.Property(t => t.SORT_ID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.JDE_ACCOUNT_ID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.JDE_ACCOUNT_DESC)
                .HasMaxLength(200);

            this.Property(t => t.HP_ACCOUNT_ID)
                .HasMaxLength(50);

            this.Property(t => t.HP_ACCOUNT_DESC)
                .HasMaxLength(200);

            this.Property(t => t.HP_MODEL_ID)
                .HasMaxLength(50);

            this.Property(t => t.HP_MODEL_DESC)
                .HasMaxLength(200);

            this.Property(t => t.HP_DETAIL_ID)
                .HasMaxLength(50);

            this.Property(t => t.HP_DETAIL_DESC)
                .HasMaxLength(200);

            this.Property(t => t.SOURCE_ID)
                .HasMaxLength(50);

            this.Property(t => t.SOURCE_DESC)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("HP_ACCOUNT_MAP", "EPM_ODS");
            this.Property(t => t.SORT_ID).HasColumnName("SORT_ID");
            this.Property(t => t.JDE_ACCOUNT_ID).HasColumnName("JDE_ACCOUNT_ID");
            this.Property(t => t.JDE_ACCOUNT_DESC).HasColumnName("JDE_ACCOUNT_DESC");
            this.Property(t => t.HP_ACCOUNT_ID).HasColumnName("HP_ACCOUNT_ID");
            this.Property(t => t.HP_ACCOUNT_DESC).HasColumnName("HP_ACCOUNT_DESC");
            this.Property(t => t.HP_MODEL_ID).HasColumnName("HP_MODEL_ID");
            this.Property(t => t.HP_MODEL_DESC).HasColumnName("HP_MODEL_DESC");
            this.Property(t => t.HP_DETAIL_ID).HasColumnName("HP_DETAIL_ID");
            this.Property(t => t.HP_DETAIL_DESC).HasColumnName("HP_DETAIL_DESC");
            this.Property(t => t.INSERT_DATE).HasColumnName("INSERT_DATE");
            this.Property(t => t.SOURCE_ID).HasColumnName("SOURCE_ID");
            this.Property(t => t.SOURCE_DESC).HasColumnName("SOURCE_DESC");
        }
    }
}
