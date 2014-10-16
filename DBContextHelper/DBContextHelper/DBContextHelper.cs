using System;
using System.Linq;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq.Expressions;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;
using System.Data.Entity.Migrations;

namespace DBContextHelper
{
    public class DBContextHelper : DbContext, IDataRepository, IDisposable
    {

        public DBContextHelper(string connecttion)
            : base(connecttion)
        {

            //var objectContext = (this as IObjectContextAdapter).ObjectContext;
            //objectContext.CommandTimeout = 500;

            //this.Configuration.AutoDetectChangesEnabled = false;
            //this.Configuration.ValidateOnSaveEnabled = false;
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
        }

        // public IAuditable AuditLogger { get; set; }

        public int Update<T>(T entity) where T : ModelBase
        {
            var set = this.Set<T>();
            set.Attach(entity);
            this.Entry<T>(entity).State = EntityState.Modified;
            return this.SaveChanges();
        }

        public int Insert<T>(T entity) where T : ModelBase
        {
            this.Set<T>().Add(entity);
            return this.SaveChanges();
        }

        public int AddorUpdate<T>(T entity) where T : ModelBase
        {
            DbSet<T> dbset = this.Set<T>();
            
            //dbset.Attach(entity);
            dbset.AddOrUpdate<T>(entity);
            return this.SaveChanges();
        }

        public int Delete<T>(T entity) where T : ModelBase
        {
            this.Entry<T>(entity).State = EntityState.Deleted;
            return this.SaveChanges();
        }

        public T FindByKey<T>(params object[] keyValues) where T : ModelBase
        {
            return this.Set<T>().Find(keyValues);
        }

        public T Find<T>(Expression<Func<T, bool>> conditions) where T : ModelBase
        {
            return this.Set<T>().Where(conditions).FirstOrDefault();
        }

        public List<T> FindAll<T, S>(Expression<Func<T, bool>> conditions, Expression<Func<T, S>> orderBy) where T : ModelBase
        {
            var queryList = conditions == null ? this.Set<T>() : this.Set<T>().Where(conditions) as IQueryable<T>;

            return queryList.OrderBy(orderBy).ToList(); ;
        }

        public PagedList<T> FindAllByPage<T, S>(Expression<Func<T, bool>> conditions, Expression<Func<T, S>> orderBy, int pageSize = 30, int pageIndex = 1) where T : ModelBase
        {
            var queryList = conditions == null ? this.Set<T>() : this.Set<T>().Where(conditions) as IQueryable<T>;

            return ToPagedList<T>(queryList.OrderBy(orderBy), pageIndex, pageSize);
        }

        public PagedList<T> FindQueryByPage<T, S>(IQueryable<T> conditions, Expression<Func<T, S>> orderBy, int pageSize = 30, int pageIndex = 1) where T : ModelBase
        {
            return ToPagedList<T>(conditions.OrderBy(orderBy), pageIndex, pageSize);
        }

        PagedList<T> ToPagedList<T>(IQueryable<T> allItems, int pageIndex, int pageSize) where T : ModelBase
        {
            if (pageIndex < 1)
                pageIndex = 1;
            var itemIndex = (pageIndex - 1) * pageSize;
            var pageOfItems = allItems.Skip(itemIndex).Take(pageSize).ToList();
            var totalItemCount = allItems.Count();
            return new PagedList<T>(pageOfItems, pageIndex, pageSize, totalItemCount);
        }

        public override int SaveChanges()
        {
            this.WriteAuditLog();

            var result = base.SaveChanges();
            return result;
        }


        public int UpdateList<T>(List<T> entity) where T : ModelBase
        {
            this.Configuration.AutoDetectChangesEnabled = false;
            this.Configuration.ValidateOnSaveEnabled = false;
            var set = this.Set<T>();
            foreach (var t in entity)
            {
                set.Attach(t);
                this.Entry<T>(t).State = EntityState.Modified;
            }
            return this.SaveChanges();
        }
        public int InsertList<T>(List<T> entity) where T : ModelBase
        {
            this.Configuration.AutoDetectChangesEnabled = false;
            this.Configuration.ValidateOnSaveEnabled = false;
            var set = this.Set<T>();
            foreach (var t in entity)
            {
                set.Add(t);
            }
            return this.SaveChanges();

        }
        public int DeleteList<T>(List<T> entity) where T : ModelBase
        {
            this.Configuration.AutoDetectChangesEnabled = false;
            this.Configuration.ValidateOnSaveEnabled = false;
            foreach (var t in entity)
            {
                this.Entry<T>(t).State = EntityState.Deleted;
            }
            return this.SaveChanges();
        }

        public int AddorUpdateList<T>(List<T> entity) where T : ModelBase
        {
            this.Configuration.AutoDetectChangesEnabled = false;
            this.Configuration.ValidateOnSaveEnabled = false;
            DbSet<T> dbset = this.Set<T>();
            foreach (var t in entity)
            {
                dbset.AddOrUpdate<T>(t);
            }
            return this.SaveChanges();
        }

        public IQueryable<T> GetQueryable<T>(Expression<Func<T, bool>> conditions) where T : ModelBase
        {
            var queryList = conditions == null ? this.Set<T>() : this.Set<T>().Where(conditions) as IQueryable<T>;
            return queryList;
        }
        internal void WriteAuditLog()
        {/*
            if (this.AuditLogger == null)
                return;

            foreach (var dbEntry in this.ChangeTracker.Entries<ModelBase>().Where(p => p.State == EntityState.Added || p.State == EntityState.Deleted || p.State == EntityState.Modified))
            {
                var auditableAttr = dbEntry.Entity.GetType().GetCustomAttributes(typeof(AuditableAttribute), false).SingleOrDefault() as AuditableAttribute;
                if (auditableAttr == null)
                    continue;

                var operaterName = WCFContext.Current.Operater.Name;

                Task.Factory.StartNew(() =>
                {
                    var tableAttr = dbEntry.Entity.GetType().GetCustomAttributes(typeof(TableAttribute), false).SingleOrDefault() as TableAttribute;
                    string tableName = tableAttr != null ? tableAttr.Name : dbEntry.Entity.GetType().Name;
                    var moduleName = dbEntry.Entity.GetType().FullName.Split('.').Skip(1).FirstOrDefault();

                    this.AuditLogger.WriteLog(dbEntry.Entity.ID, operaterName, moduleName, tableName, dbEntry.State.ToString(), dbEntry.Entity);
                });
            }*/

        }

    }
}
