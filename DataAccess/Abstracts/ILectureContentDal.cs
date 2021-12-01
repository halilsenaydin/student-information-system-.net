using Core.DataAccess;
using Entities.Concretes;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstracts
{
    public interface ILectureContentDal : IEntityRepository<LectureContent>
    {
        List<LectureContentDetailDto> GetAllDto(Expression<Func<LectureContent, bool>> filter = null);
        LectureContentDetailDto GetDto(Expression<Func<LectureContent, bool>> filter);
    }
}
