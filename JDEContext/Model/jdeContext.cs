using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DBContextHelper;

namespace JDEContext
{
    public class jdeContext : DBContextHelper.DBContextHelper
    {
        static jdeContext()
        {
            Database.SetInitializer<jdeContext>(null);
        }

        public jdeContext()
            : base("JDE")
        {
        }

        //public jdeContext(string connectString)
        //    : base(connectString)
        //{
        //}
        public DbSet<F0911Z1> F0911Z1 { get; set; }




        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new F0911Z1Map());
        }
    }
}
