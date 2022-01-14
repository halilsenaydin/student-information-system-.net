using Core.DataAccess.EntityFramework;
using DataAccess.Abstracts;
using Entities.Abstracts;
using Entities.Concretes;
using Entities.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfSystemAdministratorDal : EfEntityRepositoryBase<SystemAdministrator, MSSQLContext>, ISystemAdministratorDal
    {
    }
}
