using System;
using System.Linq;
using Entities;
using Entities.IRepository;
using BLL.Validator;

namespace BLL
{
    public class MemberManager : IValidator<Member>
    {
        private readonly IMemberRepository _repository;

        public MemberManager(IMemberRepository imb)
        {
            _repository = imb;
        }
        
        public ValidationResult Validate(Member obj)
        {
            var vResult = new ValidationResult();

            if(string.IsNullOrEmpty(obj.UseName.Trim()))
                vResult.Messages.Add("Use name doesn't accept null or empty!");
            else if (obj.UseName.Contains(' '))
                vResult.Messages.Add("Use name doesn't accept to contains space characters!");
            else if(obj.UseName.Length <= 4)
                vResult.Messages.Add("Use name doesn't accept length less than 4 characters!");

            if (string.IsNullOrEmpty(obj.PassWord.Trim()))
                vResult.Messages.Add("Password doesn's accept null or empty");
            else
                if (obj.PassWord.Length <= 3)
                    vResult.Messages.Add("Password doesn's accept length less than 3 characters!");

            if(string.IsNullOrEmpty(obj.LastName.Trim()))
                vResult.Messages.Add("Last name doesn't accept null or empty!");

            if (string.IsNullOrEmpty(obj.FirstName.Trim()))
                vResult.Messages.Add("Last name doesn't accept null or empty!");

            if (string.IsNullOrEmpty(obj.Address.Trim()))
                vResult.Messages.Add("Address doesn't accept null or empty");

            if (obj.CategoryInfo == null)
                vResult.Messages.Add("Please input member's category!");
            return vResult;
        }

        public ActionResult InsertOrUpdate(Member _mem)
        {
            var aResult = new ActionResult();
            try
            {
                if (Exited(_mem.UseName))
                    _repository.Update(_mem);
                else if (_repository.Add(_mem) <= 0)
                        aResult.Exceptions.Add(new Exception("Member's adding had been fail!"));
            }
            catch(Exception ex)
            {
                aResult.Exceptions.Add(ex);
            }
            return aResult;
        }

        public ActionResult Delete(Member _mem)
        {
            var aResult = new ActionResult();
            try
            {
                if (_repository.Delete(_mem))
                    aResult.Exceptions.Add(new Exception("Member's deleting had been fail!"));
            }
            catch (Exception ex)
            {
                aResult.Exceptions.Add(ex);
            }
            return aResult;
        }

        public ActionResult Delete(string _use)
        {
            var aResult = new ActionResult();
            try
            {
                if (_repository.Delete(m => m.UseName == _use))
                    aResult.Exceptions.Add(new Exception("Member's deleting had been fail!"));
            }
            catch (Exception ex)
            {
                aResult.Exceptions.Add(ex);
            }
            return aResult;
        }

        private bool Exited(string _useName)
        {
            if (null != _repository.GetByUseName(_useName))
                return true;
            return false;
        }

        public ActionResultAsList<Member> Find(Func<Member, bool> predicate)
        {
            var aResult = new ActionResultAsList<Member>();
            try
            {
                aResult.Result = _repository.Find(predicate);
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
