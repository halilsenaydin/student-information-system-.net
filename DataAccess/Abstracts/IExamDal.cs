using Core.DataAccess;
using Entities.Concretes;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstracts
{
    public interface IExamDal : IEntityRepository<Exam>
    {
        List<ExamDetailDto> GetAllDto(Expression<Func<Exam, bool>> filter = null);
        ExamDetailDto GetDto(Expression<Func<Exam, bool>> filter);
    }
}
