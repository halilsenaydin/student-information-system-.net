using Business.Abstracts;
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
    public class TeacherManager : ITeacherService
    {
        ITeacherDal _dal;
        public TeacherManager(ITeacherDal dal)
        {
            _dal = dal;
        }

        public IResult Add(Teacher entity)
        {
            _dal.Add(entity);
            return new SuccessResult();
        }

        public IResult Delete(Teacher entity)
        {
            _dal.Delete(entity);
            return new SuccessResult();
        }

        public IResult Update(Teacher entity)
        {
            _dal.Update(entity);
            return new SuccessResult();
        }
        public IDataResult<Teacher> Get(int id)
        {
            return new SuccessDataResult<Teacher>(_dal.Get(a => a.Id == id));
        }

        public IDataResult<List<Teacher>> GetAll()
        {
            return new SuccessDataResult<List<Teacher>>(_dal.GetAll());
        }

        public IDataResult<List<TeacherDetailDto>> GetAllDto()
        {
            return new SuccessDataResult<List<TeacherDetailDto>>(_dal.GetAllDto());
        }

        public IDataResult<TeacherDetailDto> GetDto(int id)
        {
            return new SuccessDataResult<TeacherDetailDto>(_dal.GetDto(a => a.Id == id));
        }
    }
}
