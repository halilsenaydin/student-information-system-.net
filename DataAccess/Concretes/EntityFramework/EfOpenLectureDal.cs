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
    public class EfOpenLectureDal : EfEntityRepositoryBase<OpenLecture, MSSQLContext>, IOpenLectureDal
    {
        public List<OpenLectureDetailDto> GetAllDto(Expression<Func<OpenLecture, bool>> filter = null)
        {
            using (MSSQLContext context = new MSSQLContext())
            {
                var result = from openLecture in filter == null ? context.OpenLectures : context.OpenLectures.Where(filter)

                             // Of Lecture
                             join lecture in context.Lectures
                             on openLecture.LectureId equals lecture.Id

                             join semester in context.Semesters
                             on openLecture.SemesterId equals semester.Id

                             join lectureType in context.LectureTypes
                             on lecture.LectureTypeId equals lectureType.Id

                             join typeOfEducation in context.TypeOfEducations
                             on lecture.TypeOfEducationId equals typeOfEducation.Id

                             join department in context.Departments
                             on lecture.DepartmentId equals department.Id

                             join academicUnit in context.AcademicUnits
                             on department.AcademicUnitId equals academicUnit.Id

                             join academicUnitType in context.AcademicUnitTypes
                             on academicUnit.AcademicUnitTypeId equals academicUnitType.Id

                             join curriculum in context.Curriculums
                             on lecture.CurriculumId equals curriculum.Id

                             // Of Teacher
                             join teacher in context.Teachers
                             on openLecture.TeacherId equals teacher.Id

                             join personTeacher in context.Persons
                             on teacher.PersonId equals personTeacher.Id

                             join departmentTeacher in context.Departments
                             on personTeacher.DepartmentId equals departmentTeacher.Id

                             join academicUnitTeacher in context.AcademicUnits
                             on departmentTeacher.AcademicUnitId equals academicUnitTeacher.Id

                             join academicUnitTypeTeacher in context.AcademicUnitTypes
                             on academicUnitTeacher.AcademicUnitTypeId equals academicUnitTypeTeacher.Id

                             join denotation in context.Denotations
                             on teacher.DenotationId equals denotation.Id

                             select new OpenLectureDetailDto
                             {
                                 Id = openLecture.Id,
                                 Status = openLecture.Status,
                                 Semester = semester,
                                 LectureDetail = new LectureDetailDto
                                 {
                                     Id = lecture.Id,
                                     Class = lecture.Class,
                                     LectureName = lecture.LectureName,
                                     LectureCode = lecture.LectureCode,
                                     LectureType = lectureType,
                                     TypeOfEducation = typeOfEducation,
                                     Curriculum = curriculum,
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

                                 TeacherDetail = new TeacherDetailDto
                                 {
                                     Id = teacher.Id,
                                     Denotation = denotation,
                                     PersonDetail = new PersonDetailDto
                                     {
                                         Id = personTeacher.Id,
                                         FirstName = personTeacher.LastName,
                                         LastName = personTeacher.LastName,
                                         IdentityNumber = personTeacher.IdentityNumber,
                                         Email = personTeacher.Email,
                                         DepartmentDetail = new DepartmentDetailDto
                                         {
                                             Id = departmentTeacher.Id,
                                             DepartmentName = departmentTeacher.DepartmentName,
                                             AcademicUnitDetail = new AcademicUnitDetailDto
                                             {
                                                 Id = academicUnitTeacher.Id,
                                                 AcademicUnitName = academicUnitTeacher.AcademicUnitName,
                                                 AcademicUnitType = academicUnitTypeTeacher
                                             }
                                         }
                                     }
                                 }
                             };

                return result.ToList();
            }
        }

        public OpenLectureDetailDto GetDto(Expression<Func<OpenLecture, bool>> filter)
        {
            using (MSSQLContext context = new MSSQLContext())
            {
                var result = from openLecture in context.OpenLectures.Where(filter)

                                 // Of Lecture
                             join lecture in context.Lectures
                             on openLecture.LectureId equals lecture.Id

                             join semester in context.Semesters
                             on openLecture.SemesterId equals semester.Id

                             join lectureType in context.LectureTypes
                             on lecture.LectureTypeId equals lectureType.Id

                             join typeOfEducation in context.TypeOfEducations
                             on lecture.TypeOfEducationId equals typeOfEducation.Id

                             join department in context.Departments
                             on lecture.DepartmentId equals department.Id

                             join academicUnit in context.AcademicUnits
                             on department.AcademicUnitId equals academicUnit.Id

                             join academicUnitType in context.AcademicUnitTypes
                             on academicUnit.AcademicUnitTypeId equals academicUnitType.Id

                             join curriculum in context.Curriculums
                             on lecture.CurriculumId equals curriculum.Id

                             // Of Teacher
                             join teacher in context.Teachers
                             on openLecture.TeacherId equals teacher.Id

                             join personTeacher in context.Persons
                             on teacher.PersonId equals personTeacher.Id

                             join departmentTeacher in context.Departments
                             on personTeacher.DepartmentId equals departmentTeacher.Id

                             join academicUnitTeacher in context.AcademicUnits
                             on departmentTeacher.AcademicUnitId equals academicUnitTeacher.Id

                             join academicUnitTypeTeacher in context.AcademicUnitTypes
                             on academicUnitTeacher.AcademicUnitTypeId equals academicUnitTypeTeacher.Id

                             join denotation in context.Denotations
                             on teacher.DenotationId equals denotation.Id

                             select new OpenLectureDetailDto
                             {
                                 Id = openLecture.Id,
                                 Status = openLecture.Status,
                                 Semester = semester,
                                 LectureDetail = new LectureDetailDto
                                 {
                                     Id = lecture.Id,
                                     Class = lecture.Class,
                                     LectureName = lecture.LectureName,
                                     LectureCode = lecture.LectureCode,
                                     LectureType = lectureType,
                                     TypeOfEducation = typeOfEducation,
                                     Curriculum = curriculum,
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

                                 TeacherDetail = new TeacherDetailDto
                                 {
                                     Id = teacher.Id,
                                     Denotation = denotation,
                                     PersonDetail = new PersonDetailDto
                                     {
                                         Id = personTeacher.Id,
                                         FirstName = personTeacher.LastName,
                                         LastName = personTeacher.LastName,
                                         IdentityNumber = personTeacher.IdentityNumber,
                                         Email = personTeacher.Email,
                                         DepartmentDetail = new DepartmentDetailDto
                                         {
                                             Id = departmentTeacher.Id,
                                             DepartmentName = departmentTeacher.DepartmentName,
                                             AcademicUnitDetail = new AcademicUnitDetailDto
                                             {
                                                 Id = academicUnitTeacher.Id,
                                                 AcademicUnitName = academicUnitTeacher.AcademicUnitName,
                                                 AcademicUnitType = academicUnitTypeTeacher
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
