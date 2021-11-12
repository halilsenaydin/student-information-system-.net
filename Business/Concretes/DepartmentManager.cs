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
    public class DepartmentManager : IDepartmentService
    {
        IDepartmentDal _dal;
        public DepartmentManager(IDepartmentDal dal)
        {
            _dal = dal;
        }

        public IResult Add(Department entity)
        {
            _dal.Add(entity);
            return new SuccessResult();
        }

        public IResult Delete(Department entity)
        {
            _dal.Delete(entity);
            return new SuccessResult();
        }

        public IResult Update(Department entity)
        {
            _dal.Update(entity);
            return new SuccessResult();
        }
        public IDataResult<Department> Get(int id)
        {
            return new SuccessDataResult<Department>(_dal.Get(a => a.Id == id));
        }

        public IDataResult<List<Department>> GetAll()
        {
            return new SuccessDataResult<List<Department>>(_dal.GetAll());
        }

        public IDataResult<List<DepartmentDetailDto>> GetAllDto()
        {
            return new SuccessDataResult<List<DepartmentDetailDto>>(_dal.GetAllDto());
        }

        public IDataResult<DepartmentDetailDto> GetDto(int id)
        {
            return new SuccessDataResult<DepartmentDetailDto>(_dal.GetDto(a => a.Id == id));
        }
    }
}
