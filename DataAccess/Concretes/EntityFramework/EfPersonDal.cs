using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
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
    public class EfPersonDal : EfEntityRepositoryBase<Person, MSSQLContext>, IPersonDal
    {
        public List<PersonDetailDto> GetAllDto(Expression<Func<Person, bool>> filter = null)
        {
            using (MSSQLContext context = new MSSQLContext())
            {
                var result = from person in filter == null ? context.Persons : context.Persons.Where(filter)
                             join department in context.Departments
                             on person.DepartmentId equals department.Id

                             join academicUnit in context.AcademicUnits
                             on department.AcademicUnitId equals academicUnit.Id

                             join academicUnitType in context.AcademicUnitTypes
                             on academicUnit.AcademicUnitTypeId equals academicUnitType.Id

                             select new PersonDetailDto
                             {
                                 Id = person.Id,
                                 FirstName = person.FirstName,
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
                                 },
                                 ProfilePicture = context.ProfilePictures.Where(p => p.PersonId == person.Id).SingleOrDefault()
                             };

                return result.ToList();
            }
        }

        public PersonDetailDto GetDto(Expression<Func<Person, bool>> filter)
        {
            using (MSSQLContext context = new MSSQLContext())
            {
                var result = from person in context.Persons.Where(filter)
                             join department in context.Departments
                             on person.DepartmentId equals department.Id

                             join academicUnit in context.AcademicUnits
                             on department.AcademicUnitId equals academicUnit.Id

                             join academicUnitType in context.AcademicUnitTypes
                             on academicUnit.AcademicUnitTypeId equals academicUnitType.Id

                             select new PersonDetailDto
                             {
                                 Id = person.Id,
                                 FirstName = person.FirstName,
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
                                 },
                                 ProfilePicture = context.ProfilePictures.Where(p => p.PersonId == person.Id).SingleOrDefault()
                             };

                return result.SingleOrDefault();
            }
        }
    }
}
