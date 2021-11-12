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
    public class EfLetterGradeDal : EfEntityRepositoryBase<LetterGrade, MSSQLContext>, ILetterGradeDal
    {
        public List<LetterGradeDetailDto> GetAllDto(Expression<Func<LetterGrade, bool>> filter = null)
        {
            using (MSSQLContext context = new MSSQLContext())
            {
                var result = from letterGrade in filter == null ? context.LetterGrades : context.LetterGrades.Where(filter)
                             join letterGradeType in context.LetterGradeTypes
                             on letterGrade.LetterGradeTypeId equals letterGradeType.Id

                             join takingLecture in context.TakingLectures
                             on letterGrade.TakingLectureId equals takingLecture.Id

                             join semester in context.Semesters
                             on takingLecture.SemesterId equals semester.Id

                             join lecture in context.Lectures
                             on takingLecture.LectureId equals lecture.Id

                             join department in context.Departments
                             on lecture.DepartmentId equals department.Id

                             join academicUnit in context.AcademicUnits
                             on department.AcademicUnitId equals academicUnit.Id

                             join academicUnitType in context.AcademicUnitTypes
                             on academicUnit.AcademicUnitTypeId equals academicUnitType.Id

                             join person in context.Persons
                             on department.Id equals person.DepartmentId

                             join typeOfEducation in context.TypeOfEducations
                             on lecture.TypeOfEducationId equals typeOfEducation.Id

                             select new LetterGradeDetailDto
                             {
                                Id = letterGrade.Id,
                                LetterGradeType = letterGradeType,
                                TakingLectureDetail = new TakingLectureDetailDto
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
                                }
                             };

                return result.ToList();
            }
        }

        public LetterGradeDetailDto GetDto(Expression<Func<LetterGrade, bool>> filter)
        {
            using (MSSQLContext context = new MSSQLContext())
            {
                var result = from letterGrade in context.LetterGrades.Where(filter)
                             join letterGradeType in context.LetterGradeTypes
                             on letterGrade.LetterGradeTypeId equals letterGradeType.Id

                             join takingLecture in context.TakingLectures
                             on letterGrade.TakingLectureId equals takingLecture.Id

                             join semester in context.Semesters
                             on takingLecture.SemesterId equals semester.Id

                             join lecture in context.Lectures
                             on takingLecture.LectureId equals lecture.Id

                             join department in context.Departments
                             on lecture.DepartmentId equals department.Id

                             join academicUnit in context.AcademicUnits
                             on department.AcademicUnitId equals academicUnit.Id

                             join academicUnitType in context.AcademicUnitTypes
                             on academicUnit.AcademicUnitTypeId equals academicUnitType.Id

                             join person in context.Persons
                             on department.Id equals person.DepartmentId

                             join typeOfEducation in context.TypeOfEducations
                             on lecture.TypeOfEducationId equals typeOfEducation.Id

                             select new LetterGradeDetailDto
                             {
                                 Id = letterGrade.Id,
                                 LetterGradeType = letterGradeType,
                                 TakingLectureDetail = new TakingLectureDetailDto
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
                                 }
                             };

                return result.SingleOrDefault();
            }
        }
    }
}
