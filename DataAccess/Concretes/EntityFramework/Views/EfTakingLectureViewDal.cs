using Core.DataAccess.EntityFramework;
using DataAccess.Abstracts;
using DataAccess.Abstracts.Views;
using Entities.Abstracts;
using Entities.Concretes;
using Entities.DTOs;
using Entities.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concretes.EntityFramework.Views
{
    public class EfTakingLectureViewDal : EfEntityRepositoryBase<TakingLectureView, MSSQLContext>, ITakingLectureViewDal
    {
    }
}
