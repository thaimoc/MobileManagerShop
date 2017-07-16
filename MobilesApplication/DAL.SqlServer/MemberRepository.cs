using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using BLToolkit.Data;
using BLToolkit.Data.Linq;
using Entities.IRepository;
using Entities;

namespace DAL.SqlServer
{
    public class MemberRepository:IMemberRepository
    {
        private readonly DbManager _dataContext;

        public MemberRepository()
        {
            _dataContext = new DbManager();
        }

        public Entities.Member GetByUseName(string useName)
        {
            return _dataContext.GetTable<Member>()
                .SingleOrDefault(m => m.UseName.ToLower() == useName.ToLower());
        }

        public Entities.Member GetDetailByUseName(string useName)
        {
            return Find(m => m.UseName.ToLower() == useName.ToLower()).FirstOrDefault();
        }

        public List<Entities.Member> GetAll()
        {
            return _dataContext.GetTable<Member>()
                .Select(d => new Member()
                {
                    UseName = d.UseName,
                    PassWord = d.PassWord,
                    FirstName = d.FirstName,
                    LastName = d.LastName,
                    BirthDate = d.BirthDate,
                    Gender = d.Gender,
                    NumHouse = d.NumHouse,
                    Street = d.Street,
                    Urban = d.Urban,
                    Town = d.Town,
                    City = d.City,
                    CategoryInfo = d.CategoryInfo,
                    CategoryMemberID = d.CategoryMemberID
                }
                ).ToList();
        }

        public List<Entities.Member> FindByCategory(int cateId)
        {
            throw new NotImplementedException();
        }

        public List<Entities.Member> Find(Func<Entities.Member, bool> predicate)
        {
            return _dataContext.GetTable<Member>()
                .Where(predicate)
                .Select(m => new Member()
                {
                    UseName = m.UseName, PassWord = m.PassWord,
                    FirstName = m.FirstName, LastName = m.LastName,
                    BirthDate = m.BirthDate, Gender = m.Gender,
                    NumHouse = m.NumHouse, Street = m.Street,
                    Urban = m.Urban, Town = m.Town,
                    City = m.City, CategoryMemberID = m.CategoryMemberID,
                    CategoryInfo = m.CategoryInfo
                }).ToList();
        }

        public void InsertBatch(List<Entities.Member> members)
        {
            _dataContext.InsertBatch(members);
        }

        public int Add(Entities.Member member)
        {
            return (int)_dataContext.Insert(member);
        }

        public bool Update(Entities.Member member)
        {
            return _dataContext.Update(member) > 0;
        }

        public bool Delete(Entities.Member member)
        {
            return _dataContext.Delete(member) > 0;
        }

        public bool Delete(Expression<Func<Entities.Member, bool>> predicate)
        {
            return _dataContext.GetTable<Member>().Delete(predicate) > 0;
        }

        public T GetData<T>(string query, bool isStoredProc)
        {
            if (isStoredProc)
                return _dataContext
                    .SetSpCommand(query)
                    .ExecuteObject<T>();
            else
                return _dataContext.SetSpCommand(query)
                    .ExecuteObject<T>();
        }
    }
}
