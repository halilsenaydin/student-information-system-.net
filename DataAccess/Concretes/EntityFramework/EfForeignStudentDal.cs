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
    public class EfForeignStudentDal : EfEntityRepositoryBase<ForeignStudent, MSSQLContext>, IForeignStudentDal
    {
        public List<ForeignStudentDetailDto> GetAllDto(Expression<Func<ForeignStudent, bool>> filter = null)
        {
            using (MSSQLContext context = new MSSQLContext())
            {
                var result = from foreignStudent in filter == null ? context.ForeignStudents : context.ForeignStudents.Where(filter)
                             join person in context.Persons
                             on foreignStudent.PersonId equals person.Id

                             join country in context.Countries
                             on foreignStudent.CountryId equals country.Id

                             join department in context.Departments
                             on person.DepartmentId equals department.Id

                             join academicUnit in context.AcademicUnits
                             on department.AcademicUnitId equals academicUnit.Id

                             join academicUnitType in context.AcademicUnitTypes
                             on academicUnit.AcademicUnitTypeId equals academicUnitType.Id

                             select new ForeignStudentDetailDto
                             {
                                 Id = foreignStudent.Id,
                                 Country = country,
                                 PersonDetail = new PersonDetailDto
                                 {
                                     Id = person.Id,
                                     FirstName = person.LastName,
                                     LastName = person.LastName,
                                     IdentityNumber = person.IdentityNumber,
                                     Email = person.Email,
                                     DepartmentDetail = new DepartmentDetailDto
                                     {
                                         Id = department.Id,
                                         DepartmentName = department.DepartmentName,
                                         AcademicUnitDetail = new AcademicUnitDetailDto
                                         {
                                             Id = academicUnit.Id,
                                             AcademicUnitName = academicUnit.AcademicUnitName,
                                             AcademicUnitType = academicUnitType
                                         }
                                     }
                                 }
                             };

                return result.ToList();
            }
        }

        public ForeignStudentDetailDto GetDto(Expression<Func<ForeignStudent, bool>> filter)
        {
            using (MSSQLContext context = new MSSQLContext())
            {
                var result = from foreignStudent in context.ForeignStudents.Where(filter)
                             join person in context.Persons
                             on foreignStudent.PersonId equals person.Id

                             join country in context.Countries
                             on foreignStudent.CountryId equals country.Id

                             join department in context.Departments
                             on person.DepartmentId equals department.Id

                             join academicUnit in context.AcademicUnits
                             on department.AcademicUnitId equals academicUnit.Id

                             join academicUnitType in context.AcademicUnitTypes
                             on academicUnit.AcademicUnitTypeId equals academicUnitType.Id

                             select new ForeignStudentDetailDto
                             {
                                 Id = foreignStudent.Id,
                                 Country = country,
                                 PersonDetail = new PersonDetailDto
                                 {
                                     Id = person.Id,
                                     FirstName = person.LastName,
                                     LastName = person.LastName,
                                     IdentityNumber = person.IdentityNumber,
                                     Email = person.Email,
                                     DepartmentDetail = new DepartmentDetailDto
                                     {
                                         Id = department.Id,
                                         DepartmentName = department.DepartmentName,
                                         AcademicUnitDetail = new AcademicUnitDetailDto
                                         {
                                             Id = academicUnit.Id,
                                             AcademicUnitName = academicUnit.AcademicUnitName,
                                             AcademicUnitType = academicUnitType
                                         }
                                     }
                                 }
                             };

                return result.SingleOrDefault();
            }
        }
    }
}
