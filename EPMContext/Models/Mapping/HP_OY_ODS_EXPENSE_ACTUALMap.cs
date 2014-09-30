using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EPMContext
{
    public class HP_OY_ODS_EXPENSE_ACTUALMap : EntityTypeConfiguration<HP_OY_ODS_EXPENSE_ACTUAL>
    {
        public HP_OY_ODS_EXPENSE_ACTUALMap()
        {
            // Primary Key
            this.HasKey(t => new { t.EXRPTTYP, t.EXRPTNUM, t.EMPLOYID, t.LIN });

            // Properties
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
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATE_TIME)
                .HasMaxLength(50);

            this.Property(t => t.NXTR)
                .HasMaxLength(20);

            this.Property(t => t.EXRPTDES)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.EXRPTTYP)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.EXRPTNUM)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.EMPLOYID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LIN)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("HP_OY_ODS_EXPENSE_ACTUAL", "EPM_ODS");
            this.Property(t => t.SORTID).HasColumnName("SORTID");
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
        }
    }
}
