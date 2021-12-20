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
    public class SemesterManager : ISemesterService
    {
        ISemesterDal _dal;
        public SemesterManager(ISemesterDal dal)
        {
            _dal = dal;
        }

        public IResult Add(Semester entity)
        {
            _dal.Add(entity);
            return new SuccessResult();
        }

        public IResult Delete(Semester entity)
        {
            _dal.Delete(entity);
            return new SuccessResult();
        }

        public IResult Update(Semester entity)
        {
            _dal.Update(entity);
            return new SuccessResult();
        }
        public IDataResult<Semester> Get(int id)
        {
            return new SuccessDataResult<Semester>(_dal.Get(a => a.Id == id));
        }

        public IDataResult<List<Semester>> GetAll()
        {
            return new SuccessDataResult<List<Semester>>(_dal.GetAll());
        }
    }
}
