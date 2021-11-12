using Core.DataAccess;
using Entities.Concretes;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstracts
{
    public interface IAcademicUnitDal : IEntityRepository<AcademicUnit>
    {
        List<AcademicUnitDetailDto> GetAllDto(Expression<Func<AcademicUnit, bool>> filter = null);
        AcademicUnitDetailDto GetDto(Expression<Func<AcademicUnit, bool>> filter);
    }
}
