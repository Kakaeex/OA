using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EPMContext
{
    public class HP_ODS_ESS_EXPENSE_ACTUAL_OUTMap : EntityTypeConfiguration<HP_ODS_ESS_EXPENSE_ACTUAL_OUT>
    {
        public HP_ODS_ESS_EXPENSE_ACTUAL_OUTMap()
        {
            // Primary Key
            this.HasKey(t => new { t.JDE_SORTID, t.JDE_BU_ID, t.JDE_ACCOUNT_ID, t.JDE_YEAR, t.JDE_PERIOD, t.JDE_DATE });

            // Properties
            this.Property(t => t.JDE_SORTID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.JDE_BU_ID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.JDE_BU_DESC)
                .HasMaxLength(200);

            this.Property(t => t.JDE_ACCOUNT_ID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.JDE_ACCOUNT_DESC)
                .HasMaxLength(200);

            this.Property(t => t.JDE_YEAR)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.JDE_PERIOD)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.JDE_DATE)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATE_TIME)
                .HasMaxLength(50);

            this.Property(t => t.NXTR)
                .HasMaxLength(20);

            this.Property(t => t.EXRPTDES)
                .HasMaxLength(40);

            this.Property(t => t.EXRPTTYP)
                .HasMaxLength(1);

            this.Property(t => t.EXRPTNUM)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("HP_ODS_ESS_EXPENSE_ACTUAL_OUT", "EPM_ODS");
            this.Property(t => t.JDE_SORTID).HasColumnName("JDE_SORTID");
            this.Property(t => t.JDE_BU_ID).HasColumnName("JDE_BU_ID");
            this.Property(t => t.JDE_BU_DESC).HasColumnName("JDE_BU_DESC");
            this.Property(t => t.JDE_ACCOUNT_ID).HasColumnName("JDE_ACCOUNT_ID");
            this.Property(t => t.JDE_ACCOUNT_DESC).HasColumnName("JDE_ACCOUNT_DESC");
            this.Property(t => t.JDE_YEAR).HasColumnName("JDE_YEAR");
            this.Property(t => t.JDE_PERIOD).HasColumnName("JDE_PERIOD");
            this.Property(t => t.JDE_DATE).HasColumnName("JDE_DATE");
            this.Property(t => t.JDE_DATA).HasColumnName("JDE_DATA");
            this.Property(t => t.LAST_UPDATE_TIME).HasColumnName("LAST_UPDATE_TIME");
            this.Property(t => t.NXTR).HasColumnName("NXTR");
            this.Property(t => t.EXRPTDES).HasColumnName("EXRPTDES");
            this.Property(t => t.EXRPTTYP).HasColumnName("EXRPTTYP");
            this.Property(t => t.EXRPTNUM).HasColumnName("EXRPTNUM");
            this.Property(t => t.EMPLOYID).HasColumnName("EMPLOYID");
            this.Property(t => t.LIN).HasColumnName("LIN");
            this.Property(t => t.DATA_INSERT_TIME).HasColumnName("DATA_INSERT_TIME");
        }
    }
}
