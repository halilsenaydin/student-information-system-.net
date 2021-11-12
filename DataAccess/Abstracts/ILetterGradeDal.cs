using Core.DataAccess;
using Entities.Concretes;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstracts
{
    public interface ILetterGradeDal : IEntityRepository<LetterGrade>
    {
        List<LetterGradeDetailDto> GetAllDto(Expression<Func<LetterGrade, bool>> filter = null);
        LetterGradeDetailDto GetDto(Expression<Func<LetterGrade, bool>> filter);
    }
}
