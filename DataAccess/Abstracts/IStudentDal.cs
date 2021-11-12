using Core.DataAccess;
using Entities.Concretes;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstracts
{
    public interface IStudentDal: IEntityRepository<Student>
    {
        List<StudentDetailDto> GetAllDto(Expression<Func<Student, bool>> filter = null);
        StudentDetailDto GetDto(Expression<Func<Student, bool>> filter);
    }
}
