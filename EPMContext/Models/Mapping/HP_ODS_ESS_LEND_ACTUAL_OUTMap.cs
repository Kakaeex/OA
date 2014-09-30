using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EPMContext
{
    public class HP_ODS_ESS_LEND_ACTUAL_OUTMap : EntityTypeConfiguration<HP_ODS_ESS_LEND_ACTUAL_OUT>
    {
        public HP_ODS_ESS_LEND_ACTUAL_OUTMap()
        {
            // Primary Key
            this.HasKey(t => new { t.EHEXRPTTYP, t.EHEXRPTNUM, t.EHEMPLOYID, t.EHEXRPTSTA, t.LIN, t.RPKCO, t.RPDOC, t.RPDCT, t.RPSFX, t.RPSFXE });

            // Properties
            this.Property(t => t.JDE_BU_ID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.JDE_BU_DESC)
                .HasMaxLength(200);

            this.Property(t => t.JDE_ACCOUNT_ID)
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

            this.Property(t => t.EHEXRPTTYP)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.EHEXRPTNUM)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.EHEMPLOYID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.EHEXRPTSTA)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.LIN)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RPKCO)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.RPDOC)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RPDCT)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.RPSFX)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.RPSFXE)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.EXRPTDES)
                .IsRequired()
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("HP_ODS_ESS_LEND_ACTUAL_OUT", "EPM_ODS");
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
            this.Property(t => t.EHEXRPTTYP).HasColumnName("EHEXRPTTYP");
            this.Property(t => t.EHEXRPTNUM).HasColumnName("EHEXRPTNUM");
            this.Property(t => t.EHEMPLOYID).HasColumnName("EHEMPLOYID");
            this.Property(t => t.EHEXRPTSTA).HasColumnName("EHEXRPTSTA");
            this.Property(t => t.RPAG).HasColumnName("RPAG");
            this.Property(t => t.RPAAP).HasColumnName("RPAAP");
            this.Property(t => t.LIN).HasColumnName("LIN");
            this.Property(t => t.RPKCO).HasColumnName("RPKCO");
            this.Property(t => t.RPDOC).HasColumnName("RPDOC");
            this.Property(t => t.RPDCT).HasColumnName("RPDCT");
            this.Property(t => t.RPSFX).HasColumnName("RPSFX");
            this.Property(t => t.RPSFXE).HasColumnName("RPSFXE");
            this.Property(t => t.EXRPTDES).HasColumnName("EXRPTDES");
            this.Property(t => t.DATA_INSERT_TIME).HasColumnName("DATA_INSERT_TIME");
        }
    }
}
