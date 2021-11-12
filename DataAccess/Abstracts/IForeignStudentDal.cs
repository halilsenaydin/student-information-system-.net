using Core.DataAccess;
using Entities.Concretes;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstracts
{
    public interface IForeignStudentDal : IEntityRepository<ForeignStudent>
    {
        List<ForeignStudentDetailDto> GetAllDto(Expression<Func<ForeignStudent, bool>> filter = null);
        ForeignStudentDetailDto GetDto(Expression<Func<ForeignStudent, bool>> filter);
    }
}
