using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Entities.IRepository
{
    public interface IMemberRepository
    {
        Member GetByUseName(string useName);
        Member GetDetailByUseName(string useName);
        List<Member> GetAll();
        List<Member> FindByCategory(int cateId);
        List<Member> Find(Func<Member, bool> predicate);
        void InsertBatch(List<Member> members);
        int Add(Member member);
        bool Update(Member member);
        bool Delete(Member member);
        bool Delete(Expression<Func<Member, bool>> predicate);
        T GetData<T>(string query, bool isStoredProc);
    }
}
