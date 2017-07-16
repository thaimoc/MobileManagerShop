using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;
using BLL.Validator;
using Entities.IRepository;
using System.Linq.Expressions;

namespace BLL
{
    public class WageMagager : IValidator<Wage>
    {
        private readonly IGeneralRepository<Wage> _repository;
        
        public ValidationResult Validate(Wage obj)
        {
            throw new NotImplementedException();
        }

        public WageMagager(IGeneralRepository<Wage> wageRep)
        {
            _repository = wageRep;
        }

        public ActionResult InsertOrUpdate(Wage wage)
        {
            var aResult = new ActionResult();
            try
            {
                if (wage.ID == 0)
                {
                    if (!(_repository.Add(wage) > 0))
                        aResult.Exceptions.Add(new Exception("Failse!"));
                }
                else
                {
                    if (!_repository.Update(wage))
                        aResult.Exceptions.Add(new Exception("Failse!"));
                }

            }
            catch (Exception ex)
            {
                aResult.Exceptions.Add(ex);
            }
            return aResult;
        }

        public ActionResultAsList<Wage> Find(Expression<Func<Wage, bool>> predicate)
        {
            var aResult = new ActionResultAsList<Wage>();
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
