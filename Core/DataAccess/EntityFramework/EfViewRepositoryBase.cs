using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess.EntityFramework
{
    public class EfViewRepositoryBase<TEntity,TContext>: IViewRepository<TEntity>
        where TEntity: class, IView, new()
        where TContext : DbContext, new()
    {
        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null
                    ? context.Set<TEntity>().ToList()
                    : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public List<TEntity> GetAll(int startIndex, int pageSize, Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null
                    ? context.Set<TEntity>().Skip(startIndex).Take(pageSize).ToList()
                    : context.Set<TEntity>().Where(filter).Skip(startIndex).Take(pageSize).ToList();
            }
        }

        [Obsolete]
        public List<TEntity> GetAll(RawSqlString sql)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().FromSql(sql).ToList();
            }
        }
    }
}
