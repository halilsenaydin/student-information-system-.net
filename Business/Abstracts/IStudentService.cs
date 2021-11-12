using Core.Utilities.Results;
using Entities.Concretes;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstracts
{
    public interface IStudentService
    {
        IResult Add(Student entity);
        IResult Delete(Student entity);
        IResult Update(Student entity);

        IDataResult<List<Student>> GetAll();
        IDataResult<Student> Get(int id);

        IDataResult<List<StudentDetailDto>> GetAllDto();
        IDataResult<StudentDetailDto> GetDto(int id);
    }
}
