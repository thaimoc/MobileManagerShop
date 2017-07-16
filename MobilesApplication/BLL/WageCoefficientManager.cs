using System;
using System.Collections.Generic;
using System.Linq;
using Entities;
using Entities.IRepository;
using BLL.Validator;
using System.Linq.Expressions;

namespace BLL
{
    public class WageCoefficientManager: IValidator<WageCoefficient>
    {
        private readonly IGeneralRepository<WageCoefficient> _repository;

        public WageCoefficientManager(IGeneralRepository<WageCoefficient> wcf)
        {
            _repository = wcf;
        }

        public ValidationResult Validate(WageCoefficient obj)
        {
            var vResult = new ValidationResult();
            if (obj.Point == null || 0.5f <= obj.Point && obj.Point <= 4.0f)
                vResult.Messages.Add("Point field is not equal null or it is less than 4.0 and greater than 0.5");

            if (string.IsNullOrEmpty(obj.AdminID))
                vResult.Messages.Add("Admin use has not been exited");

            if (string.IsNullOrEmpty(obj.DateEstablished.ToShortDateString()))
                vResult.Messages.Add("Established date has not been exited!");

            return vResult;
        }

        public ActionResult InsertOrUpdate(WageCoefficient wageCoeff)
        {
            var aResult = new ActionResult();
            try
            {
                if (wageCoeff.ID == 0)
                {
                    if (!(_repository.Add(wageCoeff) > 0))
                        aResult.Exceptions.Add(new Exception("Failse!"));                    
                }
                else
                {
                    if (!_repository.Update(wageCoeff))
                        aResult.Exceptions.Add(new Exception("Failse!"));
                }

            }
            catch (Exception ex)
            {
                aResult.Exceptions.Add(ex);
            }
            return aResult;
        }

        public ActionResult Delete(WageCoefficient wageCoeff)
        {
            var aResult = new ActionResult();
            try
            {
                if (!_repository.Delete(wageCoeff))
                    aResult.Exceptions.Add(new Exception("Deleting had been fail!"));
            }
            catch (Exception ex)
            {
                aResult.Exceptions.Add(ex);
            }
            return aResult;
        }

        public ActionResult Delete(int wageCoeffId)
        {
            var aResult = new ActionResult();
            try
            {
                if (!_repository.Delete(w => w.ID == wageCoeffId))
                    aResult.Exceptions.Add(new Exception("Deleting had been fail!"));
            }
            catch (Exception ex)
            {
                aResult.Exceptions.Add(ex);
            }
            return aResult;
        }

        public ActionResultAsList<WageCoefficient> Find(Expression<Func<WageCoefficient, bool>> predicate)
        {
            var aResult = new ActionResultAsList<WageCoefficient>();
            try
            {
                aResult.Result = _repository.Find(predicate).ToList();
                if (aResult.Result.Count == 0)
                    aResult.Exceptions.Add(new Exception("Not found!"));
            }
            catch(Exception ex)
            {
                aResult.Exceptions.Add(ex);
            }
            return aResult;
        }

    }


}
