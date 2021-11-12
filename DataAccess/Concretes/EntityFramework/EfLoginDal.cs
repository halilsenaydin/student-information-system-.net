using Core.DataAccess.EntityFramework;
using DataAccess.Abstracts;
using Entities.Abstracts;
using Entities.Concretes;
using Entities.DTOs;
using Entities.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfLoginDal : EfEntityRepositoryBase<Login, MSSQLContext>, ILoginDal
    {
        public List<LoginDetailDto> GetAllDto(Expression<Func<Login, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public LoginDetailDto GetDto(Expression<Func<Login, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
