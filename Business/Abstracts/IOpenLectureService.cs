using Core.Utilities.Results;
using Entities.Concretes;
using Entities.DTOs;
using Entities.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstracts
{
    public interface IOpenLectureService
    {
        IResult Add(OpenLecture entity);
        IResult Delete(OpenLecture entity);
        IResult Update(OpenLecture entity);

        IDataResult<List<OpenLecture>> GetAll();
        IDataResult<OpenLecture> Get(int id);

        IDataResult<List<OpenLectureDetailDto>> GetAllDto();
        IDataResult<OpenLectureDetailDto> GetDto(int id);

        IDataResult<List<OpenLectureView>> GetAllViewByTeacherIdAndSemesterId(int teacherId, int semesterId);
        IDataResult<OpenLectureView> GetViewByTeacherIdAndSemesterId(int teacherId, int semesterId);
    }
}
