﻿using Core.DataAccess;
using Core.Entities.Concrete;
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
        List<OperationClaim> GetClaimsOfPerson(int personId);
    }
}
