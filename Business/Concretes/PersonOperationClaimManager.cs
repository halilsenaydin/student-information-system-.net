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
    public class PersonOperationClaimManager : IPersonOperationClaimService
    {
        IPersonOperationClaimDal _dal;
        public PersonOperationClaimManager(IPersonOperationClaimDal dal)
        {
            _dal = dal;
        }

        public IResult Add(UserOperationClaim entity)
        {
            _dal.Add(entity);
            return new SuccessResult();
        }

        public IResult Delete(UserOperationClaim entity)
        {
            _dal.Delete(entity);
            return new SuccessResult();
        }

        public IResult Update(UserOperationClaim entity)
        {
            _dal.Update(entity);
            return new SuccessResult();
        }
    }
}
