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
    public class StockReceivedManager:IValidator<StockReceived>
    {

        private readonly IGeneralRepository<StockReceived> _repository;

        public ValidationResult Validate(StockReceived obj)
        {
            throw new NotImplementedException();
        }

        public StockReceivedManager(IGeneralRepository<StockReceived> rep)
        {
            _repository = rep;
        }

        public ActionResult InsertOrUpdate(StockReceived stock)
        {
            var aResult = new ActionResult();
            try
            {
                if (stock.ID <= 0)
                {
                    if (!(_repository.Add(stock) > 0))
                        aResult.Exceptions.Add(new Exception("Failse!"));
                }
                else
                {
                    if (!_repository.Update(stock))
                        aResult.Exceptions.Add(new Exception("Failse!"));
                }

            }
            catch (Exception ex)
            {
                aResult.Exceptions.Add(ex);
            }
            return aResult;
        }

        public ActionResultAsList<StockReceived> Find(Expression<Func<StockReceived, bool>> predicate)
        {
            var aResult = new ActionResultAsList<StockReceived>();
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
