using Core.DataAccess;
using Entities.Concretes;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstracts
{
    public interface IContactDal : IEntityRepository<Contact>
    {
        List<ContactDetaiDto> GetAllDto(Expression<Func<Contact, bool>> filter = null);
        ContactDetaiDto GetDto(Expression<Func<Contact, bool>> filter);
    }
}
