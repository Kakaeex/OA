using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EPMContext
{
    public class GLBALANCE_JN_TEMPMap : EntityTypeConfiguration<GLBALANCE_JN_TEMP>
    {
        public GLBALANCE_JN_TEMPMap()
        {
            // Primary Key
            this.HasKey(t => new { t.JDE_SCENARIO, t.JDE_YEAR, t.JDE_PERIOD, t.JDE_DATE, t.GLDCT, t.GLKCO, t.GLDOC, t.GLJELN, t.GLEXTL });

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

            this.Property(t => t.JDE_SCENARIO)
                .IsRequired()
                .HasMaxLength(20);

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

            this.Property(t => t.GMAID)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.SBL)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.SBLT)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.GLDCT)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.GLKCO)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.GLDOC)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.GLJELN)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.GLEXTL)
                .IsRequired()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("GLBALANCE_JN_TEMP", "EPM_ODS");
            this.Property(t => t.SORTID).HasColumnName("SORTID");
            this.Property(t => t.JDE_BU_ID).HasColumnName("JDE_BU_ID");
            this.Property(t => t.JDE_BU_DESC).HasColumnName("JDE_BU_DESC");
            this.Property(t => t.JDE_ACCOUNT_OBJ).HasColumnName("JDE_ACCOUNT_OBJ");
            this.Property(t => t.JDE_ACCOUNT_SUB).HasColumnName("JDE_ACCOUNT_SUB");
            this.Property(t => t.JDE_ACCOUNT_DESC).HasColumnName("JDE_ACCOUNT_DESC");
            this.Property(t => t.JDE_SCENARIO).HasColumnName("JDE_SCENARIO");
            this.Property(t => t.JDE_YEAR).HasColumnName("JDE_YEAR");
            this.Property(t => t.JDE_PERIOD).HasColumnName("JDE_PERIOD");
            this.Property(t => t.JDE_DATE).HasColumnName("JDE_DATE");
            this.Property(t => t.LAST_UPDATE_TIME).HasColumnName("LAST_UPDATE_TIME");
            this.Property(t => t.JDE_DATA).HasColumnName("JDE_DATA");
            this.Property(t => t.GMAID).HasColumnName("GMAID");
            this.Property(t => t.SBL).HasColumnName("SBL");
            this.Property(t => t.SBLT).HasColumnName("SBLT");
            this.Property(t => t.GLDCT).HasColumnName("GLDCT");
            this.Property(t => t.GLKCO).HasColumnName("GLKCO");
            this.Property(t => t.GLDOC).HasColumnName("GLDOC");
            this.Property(t => t.GLDGJ).HasColumnName("GLDGJ");
            this.Property(t => t.GLJELN).HasColumnName("GLJELN");
            this.Property(t => t.GLEXTL).HasColumnName("GLEXTL");
        }
    }
}
