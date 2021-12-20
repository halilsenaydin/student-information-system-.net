using Core.Utilities.Results;
using Entities.Concretes;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstracts
{
    public interface ITeacherService
    {
        IResult Add(Teacher entity);
        IResult Delete(Teacher entity);
        IResult Update(Teacher entity);

        IDataResult<List<Teacher>> GetAll();
        IDataResult<Teacher> Get(int id);

        IDataResult<List<TeacherDetailDto>> GetAllDto();
        IDataResult<TeacherDetailDto> GetDto(int id);
        IDataResult<TeacherDetailDto> GetDtoByPersonId(int personId);
        IDataResult<TeacherDetailDto> GetDtoByUserName(string userName);

        IDataResult<int> GetAllCount();
    }
}
