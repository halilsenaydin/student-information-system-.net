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
    public class StudentManager : IStudentService
    {
        IStudentDal _dal;
        public StudentManager(IStudentDal dal)
        {
            _dal = dal;
        }

        public IResult Add(Student entity)
        {
            _dal.Add(entity);
            return new SuccessResult();
        }

        public IResult Delete(Student entity)
        {
            _dal.Delete(entity);
            return new SuccessResult();
        }

        public IResult Update(Student entity)
        {
            _dal.Update(entity);
            return new SuccessResult();
        }
        public IDataResult<Student> Get(int id)
        {
            return new SuccessDataResult<Student>(_dal.Get(a => a.Id == id));
        }

        public IDataResult<List<Student>> GetAll()
        {
            return new SuccessDataResult<List<Student>>(_dal.GetAll());
        }

        public IDataResult<List<StudentDetailDto>> GetAllDto()
        {
            return new SuccessDataResult<List<StudentDetailDto>>(_dal.GetAllDto());
        }

        public IDataResult<StudentDetailDto> GetDto(int id)
        {
            return new SuccessDataResult<StudentDetailDto>(_dal.GetDto(a => a.Id == id));
        }
    }
}
