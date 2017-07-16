using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using BLToolkit.Data;
using BLToolkit.Data.Linq;
using BLToolkit.DataAccess;
using BLToolkit.Mapping;
using Entities.IRepository;
using DynamicExpression = System.Linq.Dynamic.DynamicExpression;
using Entities;

namespace DAL.SqlServer
{
    public class GeneralRepository<T> : IGeneralRepository<T> where T:class
    {
        private readonly DbManager _dataContext;

        public GeneralRepository()
        {
            _dataContext = new DbManager();
        }

        public T GetById(params object[] keys)
        {
            return _dataContext.GetTable<T>()
                .SingleOrDefault<T>(GenerateExpression(keys));
        }

        public IQueryable<T> GetAll()
        {
            return _dataContext.GetTable<T>();
        }

        public IQueryable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return _dataContext.GetTable<T>().Where(predicate);
        }

        public void InsertBatch(IEnumerable<T> entities)
        {
            _dataContext.InsertBatch(entities);
        }

        public int Add(T entity)
        {
            object rs = _dataContext.InsertWithIdentity(entity);
            try
            {
                return Convert.ToInt32(rs.ToString());
            }
            catch
            {
                return 0;
            }
        }

        public bool InsertOrUpdate(T entity)
        {
            return _dataContext.InsertOrUpdate(entity) > 0;
        }

        public bool Update(T entity)
        {
            return _dataContext.Update(entity) > 0;
        }

        public bool Delete(T entity)
        {
            return _dataContext.Delete(entity) > 0;
        }

        public bool Delete(Expression<Func<T, bool>> predicate)
        {
            return _dataContext.GetTable<T>().Delete(predicate) > 0;
        }

        public object GetData(string query, bool isStoredProc)
        {
            if (isStoredProc)
                return _dataContext
                    .SetSpCommand(query)
                    .ExecuteScalar();
            else
                return _dataContext.SetCommand(query)
                    .ExecuteScalar();
        }

        protected static Expression<Func<T, bool>> GenerateExpression(params object[] keys)
        {
            MemberMapper[] keyList = typeof(T).GetKeyFieldList<T>();
            if (keyList.Length == 0)
            {
                throw new DataAccessException(string.Format("No primary key field(s) in the type '{0}'.", typeof(T).FullName));
            }
            int n = keys.Length;
            string[] expressions = new string[n];
            object[] convertKeys = new object[n];
            for (int i = 0; i < n; i++)
            {
                MemberMapper mm = keyList[i];
                expressions[i] = string.Format("{0}=@{1}", mm.Name, i);
                convertKeys[i] = keys[i].ChangeTypeTo(mm.Type);
            }
            return DynamicExpression.ParseLambda<T, bool>(string.Join(" and ", expressions), convertKeys);
        }
    }
}
