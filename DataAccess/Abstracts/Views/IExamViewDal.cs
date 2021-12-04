using Core.DataAccess;
using Entities.Concretes;
using Entities.DTOs;
using Entities.Views;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstracts.Views
{
    public interface IExamViewDal : IEntityRepository<ExamView>
    {
    }
}
