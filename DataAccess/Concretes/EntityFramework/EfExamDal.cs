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
    public class EfExamDal : EfEntityRepositoryBase<Exam, MSSQLContext>, IExamDal
    {
        public List<ExamDetailDto> GetAllDto(Expression<Func<Exam, bool>> filter = null)
        {
            using (MSSQLContext context = new MSSQLContext())
            {
                var result = from exam in filter == null ? context.Exams : context.Exams.Where(filter)
                             join examType in context.ExamTypes
                             on exam.ExamTypeId equals examType.Id

                             join student in context.Students
                             on exam.StudentId equals student.Id

                             join person in context.Persons
                             on student.PersonId equals person.Id

                             join department in context.Departments
                             on person.DepartmentId equals department.Id

                             join academicUnit in context.AcademicUnits
                             on department.AcademicUnitId equals academicUnit.Id

                             join academicUnitType in context.AcademicUnitTypes
                             on academicUnit.AcademicUnitTypeId equals academicUnitType.Id

                             join takingLecture in context.TakingLectures
                             on exam.TakingLectureId equals takingLecture.Id

                             join semester in context.Semesters
                             on takingLecture.SemesterId equals semester.Id

                             join lecture in context.Lectures
                             on takingLecture.LectureId equals lecture.Id

                             join typeOfEducation in context.TypeOfEducations
                             on lecture.TypeOfEducationId equals typeOfEducation.Id

                             select new ExamDetailDto
                             {
                                 Id = exam.Id,
                                 Point = exam.Point,
                                 ExamType = examType,
                                 StudentDetail = new StudentDetailDto
                                 {
                                     Id = student.Id,
                                     Class = student.Class,
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
                                 },
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

        public ExamDetailDto GetDto(Expression<Func<Exam, bool>> filter)
        {
            using (MSSQLContext context = new MSSQLContext())
            {
                var result = from exam in context.Exams.Where(filter)
                             join examType in context.ExamTypes
                             on exam.ExamTypeId equals examType.Id

                             join student in context.Students
                             on exam.StudentId equals student.Id

                             join person in context.Persons
                             on student.PersonId equals person.Id

                             join department in context.Departments
                             on person.DepartmentId equals department.Id

                             join academicUnit in context.AcademicUnits
                             on department.AcademicUnitId equals academicUnit.Id

                             join academicUnitType in context.AcademicUnitTypes
                             on academicUnit.AcademicUnitTypeId equals academicUnitType.Id

                             join takingLecture in context.TakingLectures
                             on exam.TakingLectureId equals takingLecture.Id

                             join semester in context.Semesters
                             on takingLecture.SemesterId equals semester.Id

                             join lecture in context.Lectures
                             on takingLecture.LectureId equals lecture.Id

                             join typeOfEducation in context.TypeOfEducations
                             on lecture.TypeOfEducationId equals typeOfEducation.Id

                             select new ExamDetailDto
                             {
                                 Id = exam.Id,
                                 Point = exam.Point,
                                 ExamType = examType,
                                 StudentDetail = new StudentDetailDto
                                 {
                                     Id = student.Id,
                                     Class = student.Class,
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
                                 },
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
