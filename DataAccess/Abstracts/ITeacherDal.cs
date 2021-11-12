using Core.DataAccess;
using Entities.Concretes;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstracts
{
    public interface ITeacherDal : IEntityRepository<Teacher>
    {
        List<TeacherDetailDto> GetAllDto(Expression<Func<Teacher, bool>> filter = null);
        TeacherDetailDto GetDto(Expression<Func<Teacher, bool>> filter);
    }
}
