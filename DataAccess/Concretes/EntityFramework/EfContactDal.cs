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
    public class EfContactDal : EfEntityRepositoryBase<Contact, MSSQLContext>, IContactDal
    {
        public List<ContactDetaiDto> GetAllDto(Expression<Func<Contact, bool>> filter = null)
        {
            using (MSSQLContext context = new MSSQLContext())
            {
                var result = from contact in filter == null ? context.Contacts : context.Contacts.Where(filter)
                             join person in context.Persons
                             on contact.PersonId equals person.Id

                             join department in context.Departments
                             on person.DepartmentId equals department.Id

                             join academicUnit in context.AcademicUnits
                             on department.AcademicUnitId equals academicUnit.Id

                             join academicUnitType in context.AcademicUnitTypes
                             on academicUnit.AcademicUnitTypeId equals academicUnitType.Id

                             select new ContactDetaiDto
                             {
                                 Id = contact.Id,
                                 Email = contact.Email,
                                 PhoneNumber = contact.PhoneNumber,
                                 Address = contact.Address,
                                 PersonDetail = new PersonDetailDto
                                 {
                                     Id = person.Id,
                                     Email = person.Email,
                                     FirstName = person.FirstName,
                                     LastName = person.LastName,
                                     IdentityNumber = person.IdentityNumber,
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

        public ContactDetaiDto GetDto(Expression<Func<Contact, bool>> filter)
        {
            using (MSSQLContext context = new MSSQLContext())
            {
                var result = from contact in context.Contacts.Where(filter)
                             join person in context.Persons
                             on contact.PersonId equals person.Id

                             join department in context.Departments
                             on person.DepartmentId equals department.Id

                             join academicUnit in context.AcademicUnits
                             on department.AcademicUnitId equals academicUnit.Id

                             join academicUnitType in context.AcademicUnitTypes
                             on academicUnit.AcademicUnitTypeId equals academicUnitType.Id

                             select new ContactDetaiDto
                             {
                                 Id = contact.Id,
                                 Email = contact.Email,
                                 PhoneNumber = contact.PhoneNumber,
                                 Address = contact.Address,
                                 PersonDetail = new PersonDetailDto
                                 {
                                     Id = person.Id,
                                     Email = person.Email,
                                     FirstName = person.FirstName,
                                     LastName = person.LastName,
                                     IdentityNumber = person.IdentityNumber,
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
