using Core.DataAccess;
using Entities.Concretes;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstracts
{
    public interface IPersonDal : IEntityRepository<Person>
    {
        List<PersonDetailDto> GetAllDto(Expression<Func<Person, bool>> filter = null);
        PersonDetailDto GetDto(Expression<Func<Person, bool>> filter);
    }
}
