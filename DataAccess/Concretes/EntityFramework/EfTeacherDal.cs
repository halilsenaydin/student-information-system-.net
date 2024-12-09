﻿using Core.DataAccess.EntityFramework;
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
    public class EfTeacherDal : EfEntityRepositoryBase<Teacher, MSSQLContext>, ITeacherDal
    {
        public List<TeacherDetailDto> GetAllDto(Expression<Func<Teacher, bool>> filter = null)
        {
            using (MSSQLContext context = new MSSQLContext())
            {
                var result = from teacher in filter == null ? context.Teachers : context.Teachers.Where(filter)
                             join person in context.Persons
                             on teacher.PersonId equals person.Id

                             join department in context.Departments
                             on person.DepartmentId equals department.Id

                             join academicUnit in context.AcademicUnits
                             on department.AcademicUnitId equals academicUnit.Id

                             join academicUnitType in context.AcademicUnitTypes
                             on academicUnit.AcademicUnitTypeId equals academicUnitType.Id

                             join denotation in context.Denotations
                             on teacher.DenotationId equals denotation.Id

                             select new TeacherDetailDto
                             {
                                 Id = teacher.Id,
                                 Denotation = denotation,
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
                                     },
                                     ProfilePicture = context.ProfilePictures.Where(p => p.PersonId == person.Id).SingleOrDefault()
                                 }
                             };

                return result.ToList();
            }
        }

        public TeacherDetailDto GetDto(Expression<Func<Teacher, bool>> filter)
        {
            using (MSSQLContext context = new MSSQLContext())
            {
                var result = from teacher in context.Teachers.Where(filter)
                             join person in context.Persons
                             on teacher.PersonId equals person.Id

                             join department in context.Departments
                             on person.DepartmentId equals department.Id

                             join academicUnit in context.AcademicUnits
                             on department.AcademicUnitId equals academicUnit.Id

                             join academicUnitType in context.AcademicUnitTypes
                             on academicUnit.AcademicUnitTypeId equals academicUnitType.Id

                             join denotation in context.Denotations
                             on teacher.DenotationId equals denotation.Id

                             select new TeacherDetailDto
                             {
                                 Id = teacher.Id,
                                 Denotation = denotation,
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
                                     },
                                     ProfilePicture = context.ProfilePictures.Where(p => p.PersonId == person.Id).SingleOrDefault()
                                 }
                             };

                return result.SingleOrDefault();
            }
        }
    }
}
