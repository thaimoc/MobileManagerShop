using System;
using System.Linq;
using Entities;
using Entities.IRepository;
using BLL.Validator;

namespace BLL
{
    public class OrderDetialManager:IValidator<OrderDetail>
    {

        public ValidationResult Validate(OrderDetail obj)
        {
            throw new NotImplementedException();
        }

        private readonly IGeneralRepository<OrderDetail> _repository;

        public OrderDetialManager(IGeneralRepository<OrderDetail> rep)
        {
            _repository = rep;
        }

        public ActionResult Delete(int orderID)
        {
            var aResult = new ActionResult();
            try
            {
                if (!_repository.Delete(de=>de.OrderID == orderID))
                    aResult.Exceptions.Add(new Exception(String.Format("Delete all order details of order, whitch id {0} had been fails!", orderID)));
            }
            catch (Exception ex)
            {
                aResult.Exceptions.Add(ex);
            }
            return aResult;
        }

        public ActionResult Insert(OrderDetail orderDetail)
        {
            var aResult = new ActionResult();
            try
            {
                if (!(_repository.Add(orderDetail) > 0))
                    aResult.Exceptions.Add(new Exception(String.Format("Insert order details (order id = {0}, product name = {1}) had been fail", orderDetail.OrderID, orderDetail.ProductInfo.Name)));

            }
            catch (Exception ex)
            {
                aResult.Exceptions.Add(ex);
            }
            return aResult;
        }




    }
}
