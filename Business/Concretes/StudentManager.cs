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
        IPersonService _personService;
        public StudentManager(IStudentDal dal, IPersonService personService)
        {
            _dal = dal;
            _personService = personService;
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

        public IDataResult<StudentDetailDto> GetDtoByUserName(string userName)
        {
            var person = _personService.GetByUserName(userName);
            int personId = person.Data.Id;
            return new SuccessDataResult<StudentDetailDto>(_dal.GetDto(a => a.PersonId == personId));
        }

        public IDataResult<int> GetAllCount()
        {
            var result = _dal.GetAll();
            return new SuccessDataResult<int>(result.Count);
        }
    }
}
