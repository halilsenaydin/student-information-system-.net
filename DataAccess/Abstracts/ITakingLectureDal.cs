using Core.DataAccess;
using Entities.Concretes;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstracts
{
    public interface ITakingLectureDal : IEntityRepository<TakingLecture>
    {
        List<TakingLectureDetailDto> GetAllDto(Expression<Func<TakingLecture, bool>> filter = null);
        TakingLectureDetailDto GetDto(Expression<Func<TakingLecture, bool>> filter);
    }
}
