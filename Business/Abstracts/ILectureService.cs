using Core.Utilities.Results;
using Entities.Concretes;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstracts
{
    public interface ILectureService
    {
        IResult Add(Lecture entity);
        IResult Delete(Lecture entity);
        IResult Update(Lecture entity);

        IDataResult<List<Lecture>> GetAll();
        IDataResult<Lecture> Get(int id);

        IDataResult<List<LectureDetailDto>> GetAllDto();
        IDataResult<LectureDetailDto> GetDto(int id);
    }
}
