using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BLL.Validator;
using Entities;
using Entities.IRepository;
using System.Linq.Expressions;

namespace BLL
{
    public class ProductManager:IValidator<Product>
    {
        private readonly IGeneralRepository<Product> _repository;

        public ValidationResult Validate(Product obj)
        {
            throw new NotImplementedException();
        }

        public ProductManager(IGeneralRepository<Product> _res)
        {
            _repository = _res;
        }

        public ActionResult InsertOrUpdate(Product pro)
        {
            var aResult = new ActionResult();
            try
            {
                if (pro.ID <= 0)
                {
                    if (!(_repository.Add(pro) > 0))
                        aResult.Exceptions.Add(new Exception("Failse!"));
                }
                else
                {
                    if (!_repository.Update(pro))
                        aResult.Exceptions.Add(new Exception("Failse!"));
                }

            }
            catch (Exception ex)
            {
                aResult.Exceptions.Add(ex);
            }
            return aResult;
        }

        public ActionResultAsList<Product> Find(Expression<Func<Product, bool>> predicate)
        {
            var aResult = new ActionResultAsList<Product>();
            try
            {
                aResult.Result = _repository.Find(predicate).ToList();
                if (aResult.Result.Count == 0)
                    aResult.Exceptions.Add(new Exception("Not found!"));
            }
            catch (Exception ex)
            {
                aResult.Exceptions.Add(ex);
            }
            return aResult;
        }

    }
}
