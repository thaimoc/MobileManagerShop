using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;

namespace Entities.IRepository
{
    public interface IGeneralRepository<T> where T:class
    {
        T GetById(params object[] keys);
        IQueryable<T> GetAll();
        IQueryable<T> Find(Expression<Func<T, bool>> predicate);
        int Add(T entity);
        bool InsertOrUpdate(T entity);
        bool Update(T entity);
        bool Delete(T entity);
        bool Delete(Expression<Func<T, bool>> predicate);
        object GetData(string query, bool isStoredProc);

    }
}
