using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Entities.IRepository
{
    public interface ICategoryMember
    {
        CategoryMember GetById(int id);
        CategoryMember GetDetailById(int id);
        CategoryMember GetByLocation(string location);
        List<CategoryMember> GetAll();
        List<CategoryMember> Find(Func<CategoryMember, bool> predicate);
        void InsertBatch(List<CategoryMember> member);
        int Add(CategoryMember member);
        bool Update(CategoryMember member);
        bool Delete(CategoryMember member);
        bool Delete(Expression<Func<CategoryMember, bool>> predicate);
        T GetData<T>(string query, bool isStoredProc);
    }
}
