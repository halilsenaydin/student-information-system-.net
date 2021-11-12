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
    public class AcademicUnitManager:IAcademicUnitService
    {
        IAcademicUnitDal _dal;
        public AcademicUnitManager(IAcademicUnitDal dal)
        {
            _dal = dal;
        }

        public IResult Add(AcademicUnit entity)
        {
            _dal.Add(entity);
            return new SuccessResult();
        }

        public IResult Delete(AcademicUnit entity)
        {
            _dal.Delete(entity);
            return new SuccessResult();
        }

        public IResult Update(AcademicUnit entity)
        {
            _dal.Update(entity);
            return new SuccessResult();
        }
        public IDataResult<AcademicUnit> Get(int id)
        {
            return new SuccessDataResult<AcademicUnit>(_dal.Get(a => a.Id == id));
        }

        public IDataResult<List<AcademicUnit>> GetAll()
        {
            return new SuccessDataResult<List<AcademicUnit>>(_dal.GetAll());
        }

        public IDataResult<List<AcademicUnitDetailDto>> GetAllDto()
        {
            return new SuccessDataResult<List<AcademicUnitDetailDto>>(_dal.GetAllDto());
        }

        public IDataResult<AcademicUnitDetailDto> GetDto(int id)
        {
            return new SuccessDataResult<AcademicUnitDetailDto>(_dal.GetDto(a => a.Id == id));
        }
    }
}
