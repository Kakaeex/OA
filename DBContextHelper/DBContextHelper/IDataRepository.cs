using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity.Infrastructure;
using System.Data.Entity;
using System.Linq.Expressions;

namespace DBContextHelper
{
    public interface IDataRepository
    {
        /*
        List<T> Find<T>(IQueryable<T> linq) where T : class,new();
        int Insert<T>(T t) where T : class;
        int Delete<T>(IQueryable<T> linq) where T : class;
        int Update<T>(Action<T> Templated, Func<T, bool> func) where T : class;*/

        int Update<T>(T entity) where T : ModelBase;
        int Insert<T>(T entity) where T : ModelBase;
        int Delete<T>(T entity) where T : ModelBase;
        T FindByKey<T>(params object[] keyValues) where T : ModelBase;
        T Find<T>(Expression<Func<T, bool>> conditions) where T : ModelBase;
        List<T> FindAll<T, S>(Expression<Func<T, bool>> conditions, Expression<Func<T, S>> orderBy) where T : ModelBase;
        PagedList<T> FindAllByPage<T, S>(Expression<Func<T, bool>> conditions, Expression<Func<T, S>> orderBy, int pageSize, int pageIndex) where T : ModelBase;
    }
}
