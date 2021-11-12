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
    public class ForeignStudentManager : IForeignStudentService
    {
        IForeignStudentDal _dal;
        public ForeignStudentManager(IForeignStudentDal dal)
        {
            _dal = dal;
        }

        public IResult Add(ForeignStudent entity)
        {
            _dal.Add(entity);
            return new SuccessResult();
        }

        public IResult Delete(ForeignStudent entity)
        {
            _dal.Delete(entity);
            return new SuccessResult();
        }

        public IResult Update(ForeignStudent entity)
        {
            _dal.Update(entity);
            return new SuccessResult();
        }
        public IDataResult<ForeignStudent> Get(int id)
        {
            return new SuccessDataResult<ForeignStudent>(_dal.Get(a => a.Id == id));
        }

        public IDataResult<List<ForeignStudent>> GetAll()
        {
            return new SuccessDataResult<List<ForeignStudent>>(_dal.GetAll());
        }

        public IDataResult<List<ForeignStudentDetailDto>> GetAllDto()
        {
            return new SuccessDataResult<List<ForeignStudentDetailDto>>(_dal.GetAllDto());
        }

        public IDataResult<ForeignStudentDetailDto> GetDto(int id)
        {
            return new SuccessDataResult<ForeignStudentDetailDto>(_dal.GetDto(a => a.Id == id));
        }
    }
}
