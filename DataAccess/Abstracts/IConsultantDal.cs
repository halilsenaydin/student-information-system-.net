﻿using Core.DataAccess;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstracts
{
    public interface IConsultantDal : IEntityRepository<Consultant>
    {
    }
}
