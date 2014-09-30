using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EPMContext
{
    public class HP_OY_ODS_UNITCOST_ACTUALMap : EntityTypeConfiguration<HP_OY_ODS_UNITCOST_ACTUAL>
    {
        public HP_OY_ODS_UNITCOST_ACTUALMap()
        {
            // Primary Key
            this.HasKey(t => new { t.LEDG, t.JDE_BU_ID, t.COLOCN, t.COLOTN, t.ITM });

            // Properties
            this.Property(t => t.LEDG)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.JDE_BU_ID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.JDE_BU_DESC)
                .HasMaxLength(200);

            this.Property(t => t.JDE_ACCOUNT_OBJ)
                .HasMaxLength(50);

            this.Property(t => t.JDE_ACCOUNT_DESC)
                .HasMaxLength(200);

            this.Property(t => t.LITM)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.LAST_UPDATE_TIME)
                .HasMaxLength(50);

            this.Property(t => t.COCSIN)
                .HasMaxLength(1);

            this.Property(t => t.GMCO)
                .HasMaxLength(5);

            this.Property(t => t.COLOCN)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.COLOTN)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.ITM)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("HP_OY_ODS_UNITCOST_ACTUAL", "EPM_ODS");
            this.Property(t => t.SORTID).HasColumnName("SORTID");
            this.Property(t => t.LEDG).HasColumnName("LEDG");
            this.Property(t => t.JDE_BU_ID).HasColumnName("JDE_BU_ID");
            this.Property(t => t.JDE_BU_DESC).HasColumnName("JDE_BU_DESC");
            this.Property(t => t.JDE_ACCOUNT_OBJ).HasColumnName("JDE_ACCOUNT_OBJ");
            this.Property(t => t.JDE_ACCOUNT_DESC).HasColumnName("JDE_ACCOUNT_DESC");
            this.Property(t => t.LITM).HasColumnName("LITM");
            this.Property(t => t.JDE_COST_DATA).HasColumnName("JDE_COST_DATA");
            this.Property(t => t.LAST_UPDATE_TIME).HasColumnName("LAST_UPDATE_TIME");
            this.Property(t => t.COCSIN).HasColumnName("COCSIN");
            this.Property(t => t.GMCO).HasColumnName("GMCO");
            this.Property(t => t.COLOCN).HasColumnName("COLOCN");
            this.Property(t => t.COLOTN).HasColumnName("COLOTN");
            this.Property(t => t.ITM).HasColumnName("ITM");
        }
    }
}
