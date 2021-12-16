using Business.Abstracts;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstracts;
using Entities.Abstracts;
using Entities.Concretes;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concretes
{
    public class LoginManager : ILoginService
    {
        ILoginDal _dal;
        public LoginManager(ILoginDal dal)
        {
            _dal = dal;
        }

        public IResult Add(Login entity)
        {
            _dal.Add(entity);
            return new SuccessResult();
        }

        public IResult Delete(Login entity)
        {
            _dal.Delete(entity);
            return new SuccessResult();
        }
        public IResult Update(Login entity)
        {
            _dal.Update(entity);
            return new SuccessResult();
        }

        public Login GetByUserName(string userName)
        {
            return _dal.Get(l=>l.UserName == userName);
        }

        public List<OperationClaim> GetClaimsOfPerson(int personId)
        {
            return _dal.GetClaimsOfPerson(personId);
        }
    }
}
