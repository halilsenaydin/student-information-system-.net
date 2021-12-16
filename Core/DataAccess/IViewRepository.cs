using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    public interface IViewRepository<T> where T:class, IView, new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        List<T> GetAll(int startIndex, int pageSize, Expression<Func<T, bool>> filter = null);

        [Obsolete]
        List<T> GetAll(RawSqlString sql);

        T Get(Expression<Func<T, bool>> filter);
    }
}
