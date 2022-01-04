using Business.Abstracts;
using Core.Utilities.Results;
using DataAccess.Abstracts;
using Entities.Concretes;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concretes
{
    public class DenotationManager : IDenotationService
    {
        IDenotationDal _dal;
        public DenotationManager(IDenotationDal dal)
        {
            _dal = dal;
        }

        public IResult Add(Denotation entity)
        {
            _dal.Add(entity);
            return new SuccessResult();
        }

        public IResult Delete(Denotation entity)
        {
            _dal.Delete(entity);
            return new SuccessResult();
        }

        public IResult Update(Denotation entity)
        {
            _dal.Update(entity);
            return new SuccessResult();
        }
        public IDataResult<Denotation> Get(int id)
        {
            return new SuccessDataResult<Denotation>(_dal.Get(a => a.Id == id));
        }

        public IDataResult<List<Denotation>> GetAll()
        {
            return new SuccessDataResult<List<Denotation>>(_dal.GetAll());
        }
    }
}
