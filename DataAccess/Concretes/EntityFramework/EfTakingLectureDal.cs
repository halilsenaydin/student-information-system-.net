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
    public class EfTakingLectureDal : EfEntityRepositoryBase<TakingLecture, MSSQLContext>, ITakingLectureDal
    {
        public List<TakingLectureDetailDto> GetAllDto(Expression<Func<TakingLecture, bool>> filter = null)
        {
            using (MSSQLContext context = new MSSQLContext())
            {
                var result = from takingLecture in filter == null ? context.TakingLectures : context.TakingLectures.Where(filter)
                             join person in context.Persons
                             on takingLecture.PersonId equals person.Id

                             join department in context.Departments
                             on person.DepartmentId equals department.Id

                             join academicUnit in context.AcademicUnits
                             on department.AcademicUnitId equals academicUnit.Id

                             join academicUnitType in context.AcademicUnitTypes
                             on academicUnit.AcademicUnitTypeId equals academicUnitType.Id

                             join lecture in context.Lectures
                             on takingLecture.LectureId equals lecture.Id

                             join semester in context.Semesters
                             on takingLecture.SemesterId equals semester.Id

                             join typeOfEducation in context.TypeOfEducations
                             on lecture.TypeOfEducationId equals typeOfEducation.Id

                             select new TakingLectureDetailDto
                             {
                                 Id = takingLecture.Id,
                                 Semester = semester,
                                 LectureDetail = new LectureDetailDto
                                 {
                                     Id = lecture.Id,
                                     LectureName = lecture.LectureName,
                                     TypeOfEducation = typeOfEducation,
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
                                 },
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

        public TakingLectureDetailDto GetDto(Expression<Func<TakingLecture, bool>> filter)
        {
            using (MSSQLContext context = new MSSQLContext())
            {
                var result = from takingLecture in context.TakingLectures.Where(filter)
                             join person in context.Persons
                             on takingLecture.PersonId equals person.Id

                             join department in context.Departments
                             on person.DepartmentId equals department.Id

                             join academicUnit in context.AcademicUnits
                             on department.AcademicUnitId equals academicUnit.Id

                             join academicUnitType in context.AcademicUnitTypes
                             on academicUnit.AcademicUnitTypeId equals academicUnitType.Id

                             join lecture in context.Lectures
                             on takingLecture.LectureId equals lecture.Id

                             join semester in context.Semesters
                             on takingLecture.SemesterId equals semester.Id

                             join typeOfEducation in context.TypeOfEducations
                             on lecture.TypeOfEducationId equals typeOfEducation.Id

                             select new TakingLectureDetailDto
                             {
                                 Id = takingLecture.Id,
                                 Semester = semester,
                                 LectureDetail = new LectureDetailDto
                                 {
                                     Id = lecture.Id,
                                     LectureName = lecture.LectureName,
                                     TypeOfEducation = typeOfEducation,
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
                                 },
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
