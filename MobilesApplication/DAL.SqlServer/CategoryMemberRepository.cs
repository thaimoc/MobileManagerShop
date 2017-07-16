using System;
using System.Collections.Generic;
using System.Linq;
using BLToolkit.Data;
using Entities.IRepository;
using Entities;

namespace DAL.SqlServer
{
    public class CategoryMemberRepository:ICategoryMember
    {
        private readonly DbManager _dataContext;

        public CategoryMemberRepository()
        {
            _dataContext = new DbManager();
        }


        public Entities.CategoryMember GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Entities.CategoryMember GetDetailById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Entities.CategoryMember> GetAll()
        {
            return _dataContext.GetTable<CategoryMember>()
                .Select(d => new CategoryMember()
                {
                    ID = d.ID,
                    Location = d.Location,
                    Description = d.Description
                }
                ).ToList();
        }
        
        public List<Entities.CategoryMember> Find(Func<Entities.CategoryMember, bool> predicate)
        {
            return _dataContext.GetTable<CategoryMember>()
                .Where(predicate)
                .Select(c => new CategoryMember() { 
                    ID = c.ID, Location = c.Location, Description = c.Description
                }).ToList();
        }

        public void InsertBatch(List<Entities.CategoryMember> member)
        {
            throw new NotImplementedException();
        }

        public int Add(Entities.CategoryMember member)
        {
            throw new NotImplementedException();
        }

        public bool Update(Entities.CategoryMember member)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Entities.CategoryMember member)
        {
            throw new NotImplementedException();
        }

        public bool Delete(System.Linq.Expressions.Expression<Func<Entities.CategoryMember, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public T GetData<T>(string query, bool isStoredProc)
        {
            throw new NotImplementedException();
        }


        public Entities.CategoryMember GetByLocation(string location)
        {
            return Find(cate => cate.Location.CompareTo(location) == 0).FirstOrDefault();
        }
    }
}
