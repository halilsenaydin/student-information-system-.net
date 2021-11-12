using Core.DataAccess;
using Entities.Concretes;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstracts
{
    public interface ILoginDal : IEntityRepository<Login>
    {
        List<LoginDetailDto> GetAllDto(Expression<Func<Login, bool>> filter = null);
        LoginDetailDto GetDto(Expression<Func<Login, bool>> filter);
    }
}
