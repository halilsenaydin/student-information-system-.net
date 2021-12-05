using Core.Utilities.Results;
using Entities.Concretes;
using Entities.DTOs;
using Entities.Views;
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

        IDataResult<List<ExamView>> GetAllViewByStudentIdAndSemesterId(int studentId, int semesterId);
        IDataResult<ExamView> GetViewByStudentIdAndSemesterId(int examId, int studentId, int semesterId);
    }
}
