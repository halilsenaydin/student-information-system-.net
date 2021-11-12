using Core.DataAccess;
using Entities.Concretes;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstracts
{
    public interface IDepartmentDal : IEntityRepository<Department>
    {
        List<DepartmentDetailDto> GetAllDto(Expression<Func<Department, bool>> filter = null);
        DepartmentDetailDto GetDto(Expression<Func<Department, bool>> filter);
    }
}
