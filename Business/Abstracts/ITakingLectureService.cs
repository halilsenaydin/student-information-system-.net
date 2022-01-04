using Core.Utilities.Results;
using Entities.Concretes;
using Entities.DTOs;
using Entities.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstracts
{
    public interface ITakingLectureService
    {
        IResult Add(TakingLecture entity);
        IResult Delete(TakingLecture entity);
        IResult Update(TakingLecture entity);

        IDataResult<List<TakingLecture>> GetAll();
        IDataResult<TakingLecture> Get(int id);

        IDataResult<List<TakingLectureDetailDto>> GetAllDto();
        IDataResult<TakingLectureDetailDto> GetDto(int id);
    }
}
