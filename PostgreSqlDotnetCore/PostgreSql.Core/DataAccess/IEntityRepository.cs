using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace PostgreSql.Core.DataAccess
{
    public interface IEntityRepository<T> where T : class
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        T Get(Expression<Func<T, bool>> filter = null);
        List<T> GetList(Expression<Func<T, bool>> filter = null);
    }
}
