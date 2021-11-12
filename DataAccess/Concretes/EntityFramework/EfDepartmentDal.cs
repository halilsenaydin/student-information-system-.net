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
    public class EfDepartmentDal : EfEntityRepositoryBase<Department, MSSQLContext>, IDepartmentDal
    {
        public List<DepartmentDetailDto> GetAllDto(Expression<Func<Department, bool>> filter = null)
        {
            using (MSSQLContext context = new MSSQLContext())
            {
                var result = from department in filter == null ? context.Departments : context.Departments.Where(filter)
                             join academicUnit in context.AcademicUnits
                             on department.AcademicUnitId equals academicUnit.Id

                             join academicUnitType in context.AcademicUnitTypes
                             on academicUnit.AcademicUnitTypeId equals academicUnitType.Id

                             select new DepartmentDetailDto
                             {
                                 Id = department.Id,
                                 DepartmentName = department.DepartmentName,
                                 AcademicUnitDetail = new AcademicUnitDetailDto
                                 {
                                     Id = academicUnit.Id,
                                     AcademicUnitName = academicUnit.AcademicUnitName,
                                     AcademicUnitType = academicUnitType
                                 }
                             };

                return result.ToList();
            }
        }

        public DepartmentDetailDto GetDto(Expression<Func<Department, bool>> filter)
        {
            using (MSSQLContext context = new MSSQLContext())
            {
                var result = from department in context.Departments.Where(filter)
                             join academicUnit in context.AcademicUnits
                             on department.AcademicUnitId equals academicUnit.Id

                             join academicUnitType in context.AcademicUnitTypes
                             on academicUnit.AcademicUnitTypeId equals academicUnitType.Id

                             select new DepartmentDetailDto
                             {
                                 Id = department.Id,
                                 DepartmentName = department.DepartmentName,
                                 AcademicUnitDetail = new AcademicUnitDetailDto
                                 {
                                     Id = academicUnit.Id,
                                     AcademicUnitName = academicUnit.AcademicUnitName,
                                     AcademicUnitType = academicUnitType
                                 }
                             };

                return result.SingleOrDefault();
            }
        }
    }
}
