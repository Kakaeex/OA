using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using DBContextHelper;

namespace OAContext
{
    public partial class OAContext : DBContextHelper.DBContextHelper
    {
        static OAContext()
        {
            Database.SetInitializer<OAContext>(null);
        }

        public OAContext()
            : base("Name=OAContext")
        {
        }
        public DbSet<C_F00022> C_F00022 { get; set; }
        public DbSet<C_F0005> C_F0005 { get; set; }
        public DbSet<C_F0006> C_F0006 { get; set; }
        public DbSet<C_F0010> C_F0010 { get; set; }
        public DbSet<C_F0035> C_F0035 { get; set; }
        public DbSet<C_F0101> C_F0101 { get; set; }
        public DbSet<C_F0901> C_F0901 { get; set; }
        public DbSet<C_F0902> C_F0902 { get; set; }
        public DbSet<C_F0903> C_F0903 { get; set; }
        public DbSet<C_F0911> C_F0911 { get; set; }
        public DbSet<C_F0920> C_F0920 { get; set; }
        public DbSet<C_F0921> C_F0921 { get; set; }
        public DbSet<C_F0930> C_F0930 { get; set; }
        public DbSet<C_F0931> C_F0931 { get; set; }
        public DbSet<C_F2000> C_F2000 { get; set; }
        public DbSet<C_F2001> C_F2001 { get; set; }
        public DbSet<C_F2012> C_F2012 { get; set; }
        public DbSet<C_F40203> C_F40203 { get; set; }
        public DbSet<C_F40205> C_F40205 { get; set; }
        public DbSet<C_F9001> C_F9001 { get; set; }
        public DbSet<C_F9002> C_F9002 { get; set; }
        public DbSet<C_F9005> C_F9005 { get; set; }
        public DbSet<C_F9006> C_F9006 { get; set; }
        public DbSet<C_F9008> C_F9008 { get; set; }
        public DbSet<Z_ODS_F0902> Z_ODS_F0902 { get; set; }
        public DbSet<V_F0101A> V_F0101A { get; set; }
        public DbSet<V_F0901A> V_F0901A { get; set; }
        public DbSet<V_F0901B> V_F0901B { get; set; }
        public DbSet<V_F0920> V_F0920 { get; set; }
        public DbSet<V_F9008A> V_F9008A { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new C_F00022Map());
            modelBuilder.Configurations.Add(new C_F0005Map());
            modelBuilder.Configurations.Add(new C_F0006Map());
            modelBuilder.Configurations.Add(new C_F0010Map());
            modelBuilder.Configurations.Add(new C_F0035Map());
            modelBuilder.Configurations.Add(new C_F0101Map());
            modelBuilder.Configurations.Add(new C_F0901Map());
            modelBuilder.Configurations.Add(new C_F0902Map());
            modelBuilder.Configurations.Add(new C_F0903Map());
            modelBuilder.Configurations.Add(new C_F0911Map());
            modelBuilder.Configurations.Add(new C_F0920Map());
            modelBuilder.Configurations.Add(new C_F0921Map());
            modelBuilder.Configurations.Add(new C_F0930Map());
            modelBuilder.Configurations.Add(new C_F0931Map());
            modelBuilder.Configurations.Add(new C_F2000Map());
            modelBuilder.Configurations.Add(new C_F2001Map());
            modelBuilder.Configurations.Add(new C_F2012Map());
            modelBuilder.Configurations.Add(new C_F40203Map());
            modelBuilder.Configurations.Add(new C_F40205Map());
            modelBuilder.Configurations.Add(new C_F9001Map());
            modelBuilder.Configurations.Add(new C_F9002Map());
            modelBuilder.Configurations.Add(new C_F9005Map());
            modelBuilder.Configurations.Add(new C_F9006Map());
            modelBuilder.Configurations.Add(new C_F9008Map());
            modelBuilder.Configurations.Add(new Z_ODS_F0902Map());
            modelBuilder.Configurations.Add(new V_F0101AMap());
            modelBuilder.Configurations.Add(new V_F0901AMap());
            modelBuilder.Configurations.Add(new V_F0901BMap());
            modelBuilder.Configurations.Add(new V_F0920Map());
            modelBuilder.Configurations.Add(new V_F9008AMap());
        }
    }
}
