using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace OAContext
{
    public class C_F0901Map : EntityTypeConfiguration<C_F0901>
    {
        public C_F0901Map()
        {
            // Primary Key
            this.HasKey(t => t.GMAID);

            // Properties
            this.Property(t => t.GMCO)
                .HasMaxLength(5);

            this.Property(t => t.GMAID)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.GMMCU)
                .HasMaxLength(12);

            this.Property(t => t.GMOBJ)
                .HasMaxLength(6);

            this.Property(t => t.GMSUB)
                .HasMaxLength(8);

            this.Property(t => t.GMANS)
                .HasMaxLength(25);

            this.Property(t => t.GMDL01)
                .HasMaxLength(30);

            this.Property(t => t.GMLDA)
                .HasMaxLength(1);

            this.Property(t => t.GMBPC)
                .HasMaxLength(3);

            this.Property(t => t.GMPEC)
                .HasMaxLength(1);

            this.Property(t => t.GMBILL)
                .HasMaxLength(1);

            this.Property(t => t.GMCRCD)
                .HasMaxLength(3);

            this.Property(t => t.GMUM)
                .HasMaxLength(2);

            this.Property(t => t.GMR001)
                .HasMaxLength(3);

            this.Property(t => t.GMR002)
                .HasMaxLength(3);

            this.Property(t => t.GMR003)
                .HasMaxLength(3);

            this.Property(t => t.GMR004)
                .HasMaxLength(3);

            this.Property(t => t.GMR005)
                .HasMaxLength(3);

            this.Property(t => t.GMR006)
                .HasMaxLength(3);

            this.Property(t => t.GMR007)
                .HasMaxLength(3);

            this.Property(t => t.GMR008)
                .HasMaxLength(3);

            this.Property(t => t.GMR009)
                .HasMaxLength(3);

            this.Property(t => t.GMR010)
                .HasMaxLength(3);

            this.Property(t => t.GMR011)
                .HasMaxLength(3);

            this.Property(t => t.GMR012)
                .HasMaxLength(3);

            this.Property(t => t.GMR013)
                .HasMaxLength(3);

            this.Property(t => t.GMR014)
                .HasMaxLength(3);

            this.Property(t => t.GMR015)
                .HasMaxLength(3);

            this.Property(t => t.GMR016)
                .HasMaxLength(3);

            this.Property(t => t.GMR017)
                .HasMaxLength(3);

            this.Property(t => t.GMR018)
                .HasMaxLength(3);

            this.Property(t => t.GMR019)
                .HasMaxLength(3);

            this.Property(t => t.GMR020)
                .HasMaxLength(3);

            this.Property(t => t.GMR021)
                .HasMaxLength(10);

            this.Property(t => t.GMR022)
                .HasMaxLength(10);

            this.Property(t => t.GMR023)
                .HasMaxLength(10);

            this.Property(t => t.GMOBJA)
                .HasMaxLength(6);

            this.Property(t => t.GMSUBA)
                .HasMaxLength(8);

            this.Property(t => t.GMWCMP)
                .HasMaxLength(4);

            this.Property(t => t.GMCCT)
                .HasMaxLength(1);

            this.Property(t => t.GMERC)
                .HasMaxLength(2);

            this.Property(t => t.GMHTC)
                .HasMaxLength(1);

            this.Property(t => t.GMQLDA)
                .HasMaxLength(1);

            this.Property(t => t.GMCCC)
                .HasMaxLength(1);

            this.Property(t => t.GMFMOD)
                .HasMaxLength(1);

            this.Property(t => t.GMUSER)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.GMPID)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("C_F0901");
            this.Property(t => t.GMCO).HasColumnName("GMCO");
            this.Property(t => t.GMAID).HasColumnName("GMAID");
            this.Property(t => t.GMMCU).HasColumnName("GMMCU");
            this.Property(t => t.GMOBJ).HasColumnName("GMOBJ");
            this.Property(t => t.GMSUB).HasColumnName("GMSUB");
            this.Property(t => t.GMANS).HasColumnName("GMANS");
            this.Property(t => t.GMDL01).HasColumnName("GMDL01");
            this.Property(t => t.GMLDA).HasColumnName("GMLDA");
            this.Property(t => t.GMBPC).HasColumnName("GMBPC");
            this.Property(t => t.GMPEC).HasColumnName("GMPEC");
            this.Property(t => t.GMBILL).HasColumnName("GMBILL");
            this.Property(t => t.GMCRCD).HasColumnName("GMCRCD");
            this.Property(t => t.GMUM).HasColumnName("GMUM");
            this.Property(t => t.GMR001).HasColumnName("GMR001");
            this.Property(t => t.GMR002).HasColumnName("GMR002");
            this.Property(t => t.GMR003).HasColumnName("GMR003");
            this.Property(t => t.GMR004).HasColumnName("GMR004");
            this.Property(t => t.GMR005).HasColumnName("GMR005");
            this.Property(t => t.GMR006).HasColumnName("GMR006");
            this.Property(t => t.GMR007).HasColumnName("GMR007");
            this.Property(t => t.GMR008).HasColumnName("GMR008");
            this.Property(t => t.GMR009).HasColumnName("GMR009");
            this.Property(t => t.GMR010).HasColumnName("GMR010");
            this.Property(t => t.GMR011).HasColumnName("GMR011");
            this.Property(t => t.GMR012).HasColumnName("GMR012");
            this.Property(t => t.GMR013).HasColumnName("GMR013");
            this.Property(t => t.GMR014).HasColumnName("GMR014");
            this.Property(t => t.GMR015).HasColumnName("GMR015");
            this.Property(t => t.GMR016).HasColumnName("GMR016");
            this.Property(t => t.GMR017).HasColumnName("GMR017");
            this.Property(t => t.GMR018).HasColumnName("GMR018");
            this.Property(t => t.GMR019).HasColumnName("GMR019");
            this.Property(t => t.GMR020).HasColumnName("GMR020");
            this.Property(t => t.GMR021).HasColumnName("GMR021");
            this.Property(t => t.GMR022).HasColumnName("GMR022");
            this.Property(t => t.GMR023).HasColumnName("GMR023");
            this.Property(t => t.GMOBJA).HasColumnName("GMOBJA");
            this.Property(t => t.GMSUBA).HasColumnName("GMSUBA");
            this.Property(t => t.GMWCMP).HasColumnName("GMWCMP");
            this.Property(t => t.GMCCT).HasColumnName("GMCCT");
            this.Property(t => t.GMERC).HasColumnName("GMERC");
            this.Property(t => t.GMHTC).HasColumnName("GMHTC");
            this.Property(t => t.GMQLDA).HasColumnName("GMQLDA");
            this.Property(t => t.GMCCC).HasColumnName("GMCCC");
            this.Property(t => t.GMFMOD).HasColumnName("GMFMOD");
            this.Property(t => t.GMUSER).HasColumnName("GMUSER");
            this.Property(t => t.GMPID).HasColumnName("GMPID");
            this.Property(t => t.GMDATE).HasColumnName("GMDATE");
            this.Property(t => t.GMTIME).HasColumnName("GMTIME");
        }
    }
}
