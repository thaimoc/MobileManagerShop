using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Entities.IRepository
{
    public interface ICustRepository
    {
        Customer GetById(int cusId);
        List<Customer> GetAll();
        List<Customer> Find(Func<Customer, bool> predicate);

        int Add(Customer cus);
        bool Update(Customer cus);
        bool Delete(Customer cus);
        bool Delete(Expression<Func<Customer, bool>> predicate);
        T GetData<T>(string query, bool isStoredProc);
    }
}
