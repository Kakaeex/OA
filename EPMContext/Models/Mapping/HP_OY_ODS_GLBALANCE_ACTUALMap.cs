using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EPMContext
{
    public class HP_OY_ODS_GLBALANCE_ACTUALMap : EntityTypeConfiguration<HP_OY_ODS_GLBALANCE_ACTUAL>
    {
        public HP_OY_ODS_GLBALANCE_ACTUALMap()
        {
            // Primary Key
            this.HasKey(t => new { t.JDE_SCENARIO, t.JDE_YEAR, t.GMAID, t.SBL, t.SBLT });

            // Properties
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
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.JDE_YEAR)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.JDE_PERIOD)
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
                .HasMaxLength(200);

            this.Property(t => t.AN8_DESC)
                .HasMaxLength(200);

            this.Property(t => t.GMAID)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.SBL)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.SBLT)
                .IsRequired()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("HP_OY_ODS_GLBALANCE_ACTUAL", "EPM_ODS");
            this.Property(t => t.SORTID).HasColumnName("SORTID");
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
            this.Property(t => t.JDE_DATA1).HasColumnName("JDE_DATA1");
            this.Property(t => t.JDE_DATA2).HasColumnName("JDE_DATA2");
            this.Property(t => t.JDE_DATA3).HasColumnName("JDE_DATA3");
            this.Property(t => t.JDE_DATA4).HasColumnName("JDE_DATA4");
            this.Property(t => t.JDE_DATA5).HasColumnName("JDE_DATA5");
            this.Property(t => t.JDE_DATA6).HasColumnName("JDE_DATA6");
            this.Property(t => t.JDE_DATA7).HasColumnName("JDE_DATA7");
            this.Property(t => t.JDE_DATA8).HasColumnName("JDE_DATA8");
            this.Property(t => t.JDE_DATA9).HasColumnName("JDE_DATA9");
            this.Property(t => t.JDE_DATA10).HasColumnName("JDE_DATA10");
            this.Property(t => t.JDE_DATA11).HasColumnName("JDE_DATA11");
            this.Property(t => t.JDE_DATA12).HasColumnName("JDE_DATA12");
            this.Property(t => t.JDE_BS_ID).HasColumnName("JDE_BS_ID");
            this.Property(t => t.JDE_BS_DESC).HasColumnName("JDE_BS_DESC");
            this.Property(t => t.JDE_CF_ID).HasColumnName("JDE_CF_ID");
            this.Property(t => t.JDE_CF_DESC).HasColumnName("JDE_CF_DESC");
            this.Property(t => t.AN8).HasColumnName("AN8");
            this.Property(t => t.AN8_DESC).HasColumnName("AN8_DESC");
            this.Property(t => t.GMAID).HasColumnName("GMAID");
            this.Property(t => t.SBL).HasColumnName("SBL");
            this.Property(t => t.SBLT).HasColumnName("SBLT");
        }
    }
}
