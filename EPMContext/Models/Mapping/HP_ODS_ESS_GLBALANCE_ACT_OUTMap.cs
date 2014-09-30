using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EPMContext
{
    public class HP_ODS_ESS_GLBALANCE_ACT_OUTMap : EntityTypeConfiguration<HP_ODS_ESS_GLBALANCE_ACT_OUT>
    {
        public HP_ODS_ESS_GLBALANCE_ACT_OUTMap()
        {
            // Primary Key
            this.HasKey(t => new { t.JDE_SORTID, t.JDE_BU_ID, t.JDE_ACCOUNT_OBJ, t.JDE_ACCOUNT_SUB, t.JDE_YEAR, t.JDE_PERIOD });

            // Properties
            this.Property(t => t.JDE_SORTID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.JDE_BU_ID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.JDE_BU_DESC)
                .HasMaxLength(200);

            this.Property(t => t.JDE_ACCOUNT_OBJ)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.JDE_ACCOUNT_SUB)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.JDE_ACCOUNT_DESC)
                .HasMaxLength(200);

            this.Property(t => t.JDE_ACCOUNT_ATTR_ID)
                .HasMaxLength(50);

            this.Property(t => t.JDE_ACCOUNT_ATTR_DEC)
                .HasMaxLength(50);

            this.Property(t => t.JDE_SCENARIO)
                .HasMaxLength(20);

            this.Property(t => t.JDE_YEAR)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.JDE_PERIOD)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.JDE_DATE)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATE_TIME)
                .HasMaxLength(50);

            this.Property(t => t.JDE_BS_ID)
                .HasMaxLength(50);

            this.Property(t => t.JDE_BS_DESC)
                .HasMaxLength(200);

            this.Property(t => t.JDE_CF_ID)
                .HasMaxLength(50);

            this.Property(t => t.JDE_CF_DESC)
                .HasMaxLength(200);

            this.Property(t => t.AN8)
                .HasMaxLength(50);

            this.Property(t => t.AN8_DESC)
                .HasMaxLength(200);

            this.Property(t => t.GMAID)
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("HP_ODS_ESS_GLBALANCE_ACT_OUT", "EPM_ODS");
            this.Property(t => t.JDE_SORTID).HasColumnName("JDE_SORTID");
            this.Property(t => t.JDE_BU_ID).HasColumnName("JDE_BU_ID");
            this.Property(t => t.JDE_BU_DESC).HasColumnName("JDE_BU_DESC");
            this.Property(t => t.JDE_ACCOUNT_OBJ).HasColumnName("JDE_ACCOUNT_OBJ");
            this.Property(t => t.JDE_ACCOUNT_SUB).HasColumnName("JDE_ACCOUNT_SUB");
            this.Property(t => t.JDE_ACCOUNT_DESC).HasColumnName("JDE_ACCOUNT_DESC");
            this.Property(t => t.JDE_ACCOUNT_ATTR_ID).HasColumnName("JDE_ACCOUNT_ATTR_ID");
            this.Property(t => t.JDE_ACCOUNT_ATTR_DEC).HasColumnName("JDE_ACCOUNT_ATTR_DEC");
            this.Property(t => t.JDE_SCENARIO).HasColumnName("JDE_SCENARIO");
            this.Property(t => t.JDE_YEAR).HasColumnName("JDE_YEAR");
            this.Property(t => t.JDE_PERIOD).HasColumnName("JDE_PERIOD");
            this.Property(t => t.JDE_DATE).HasColumnName("JDE_DATE");
            this.Property(t => t.LAST_UPDATE_TIME).HasColumnName("LAST_UPDATE_TIME");
            this.Property(t => t.JDE_DATA).HasColumnName("JDE_DATA");
            this.Property(t => t.JDE_BS_ID).HasColumnName("JDE_BS_ID");
            this.Property(t => t.JDE_BS_DESC).HasColumnName("JDE_BS_DESC");
            this.Property(t => t.JDE_CF_ID).HasColumnName("JDE_CF_ID");
            this.Property(t => t.JDE_CF_DESC).HasColumnName("JDE_CF_DESC");
            this.Property(t => t.AN8).HasColumnName("AN8");
            this.Property(t => t.AN8_DESC).HasColumnName("AN8_DESC");
            this.Property(t => t.GMAID).HasColumnName("GMAID");
            this.Property(t => t.DATA_INSERT_TIME).HasColumnName("DATA_INSERT_TIME");
        }
    }
}
