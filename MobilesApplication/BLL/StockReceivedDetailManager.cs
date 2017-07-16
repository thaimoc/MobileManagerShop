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
    public class StockReceivedDetailManager: IValidator<StockReceivedDetail>
    {
        private readonly IGeneralRepository<StockReceivedDetail> _repository;
        public ValidationResult Validate(StockReceivedDetail obj)
        {
            throw new NotImplementedException();
        }

        public StockReceivedDetailManager(IGeneralRepository<StockReceivedDetail> res)
        {
            _repository = res;
        }

        public ActionResult Delete(int stockReceivedID)
        {
            var aResult = new ActionResult();
            try
            {
                if (!_repository.Delete(de => de.StockRecievedID == stockReceivedID))
                    aResult.Exceptions.Add(new Exception(String.Format("Delete all stock received details of stock received, whitch id {0} had been fails!", stockReceivedID)));
            }
            catch (Exception ex)
            {
                aResult.Exceptions.Add(ex);
            }
            return aResult;
        }

        public ActionResult Insert(StockReceivedDetail stockDetails)
        {
            var aResult = new ActionResult();
            try
            {
                if (!(_repository.Add(stockDetails) > 0))
                    aResult.Exceptions.Add(new Exception(String.Format("Insert stock details (stock id = {0}, product name = {1}) had been fail", stockDetails.StockRecievedID, stockDetails.ProductInfo.Name)));

            }
            catch (Exception ex)
            {
                aResult.Exceptions.Add(ex);
            }
            return aResult;
        }

        public ActionResultAsList<StockReceivedDetail> Find(Expression<Func<StockReceivedDetail, bool>> predicate)
        {
            var aResult = new ActionResultAsList<StockReceivedDetail>();
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
