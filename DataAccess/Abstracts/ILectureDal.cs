using Core.DataAccess;
using Entities.Concretes;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstracts
{
    public interface ILectureDal : IEntityRepository<Lecture>
    {
        List<LectureDetailDto> GetAllDto(Expression<Func<Lecture, bool>> filter = null);
        LectureDetailDto GetDto(Expression<Func<Lecture, bool>> filter);
    }
}
