using Core.Utilities.Results;
using Entities.Concretes;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstracts
{
    public interface IExamService
    {
        IResult Add(Exam entity);
        IResult Delete(Exam entity);
        IResult Update(Exam entity);

        IDataResult<List<Exam>> GetAll();
        IDataResult<Exam> Get(int id);

        IDataResult<List<ExamDetailDto>> GetAllDto();
        IDataResult<ExamDetailDto> GetDto(int id);

        IDataResult<List<ExamDetailDto>> GetAllDtoByStudentId(int id);
        IDataResult<ExamDetailDto> GetDtoByStudentId(int id);
    }
}
