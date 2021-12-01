using Core.DataAccess;
using Entities.Concretes;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstracts
{
    public interface IOpenLectureDal : IEntityRepository<OpenLecture>
    {
        List<OpenLectureDetailDto> GetAllDto(Expression<Func<OpenLecture, bool>> filter = null);
        OpenLectureDetailDto GetDto(Expression<Func<OpenLecture, bool>> filter);
    }
}
