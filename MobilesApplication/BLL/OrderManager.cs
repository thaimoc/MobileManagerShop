using System;
using System.Linq;
using Entities;
using Entities.IRepository;
using BLL.Validator;
using System.Linq.Expressions;

namespace BLL
{
    public class OrderManager:IValidator<Order>
    {
        private readonly IGeneralRepository<Order> _repository;

        public ValidationResult Validate(Order obj)
        {
            throw new NotImplementedException();
        }

        public OrderManager(IGeneralRepository<Order> rep)
        {
            _repository = rep;
        }

        public ActionResult InsertOrUpdate(Order order)
        {
            var aResult = new ActionResult();
            try
            {
                if (order.ID <= 0)
                {
                    if (!(_repository.Add(order) > 0))
                        aResult.Exceptions.Add(new Exception("Failse!"));
                }
                else
                {
                    if (!_repository.Update(order))
                        aResult.Exceptions.Add(new Exception("Failse!"));
                }

            }
            catch (Exception ex)
            {
                aResult.Exceptions.Add(ex);
            }
            return aResult;
        }

        public ActionResultAsList<Order> Find(Expression<Func<Order, bool>> predicate)
        {
            var aResult = new ActionResultAsList<Order>();
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
