using Core.DataAccess.EntityFramework;
using DataAccess.Abstracts;
using Entities.Abstracts;
using Entities.Concretes;
using Entities.DTOs;
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
                             
                             // Exam Type
                             join examType in context.ExamTypes
                             on exam.ExamTypeId equals examType.Id

                             // Of Lecture
                             join takingLecture in context.TakingLectures
                             on exam.TakingLectureId equals takingLecture.Id

                             join openLecture in context.OpenLectures
                             on takingLecture.OpenLectureId equals openLecture.Id

                             join semester in context.Semesters
                             on openLecture.SemesterId equals semester.Id

                             join lecture in context.Lectures
                             on openLecture.LectureId equals lecture.Id

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

                             // Of Student
                             join student in context.Students
                             on exam.StudentId equals student.Id

                             join curriculum in context.Curriculums
                             on student.CurriculumId equals curriculum.Id

                             join personStudent in context.Persons
                             on student.PersonId equals personStudent.Id

                             join departmentStudent in context.Departments
                             on personStudent.DepartmentId equals departmentStudent.Id

                             join academicUnitStudent in context.AcademicUnits
                             on departmentStudent.AcademicUnitId equals academicUnitStudent.Id

                             join academicUnitTypeStudent in context.AcademicUnitTypes
                             on academicUnitStudent.AcademicUnitTypeId equals academicUnitTypeStudent.Id

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

                             select new ExamDetailDto
                             {
                                 Id = exam.Id,
                                 Point = exam.Point,
                                 ExamType = examType,
                                 StudentDetail = new StudentDetailDto
                                 {
                                     Id = student.Id,
                                     Class = student.Class,
                                     Agno = student.Agno,
                                     Status = student.Status,
                                     Curriculum = curriculum,
                                     PersonDetail = new PersonDetailDto
                                     {
                                         Id = personStudent.Id,
                                         FirstName = personStudent.LastName,
                                         LastName = personStudent.LastName,
                                         IdentityNumber = personStudent.IdentityNumber,
                                         Email = personStudent.Email,
                                         DepartmentDetail = new DepartmentDetailDto
                                         {
                                             Id = departmentStudent.Id,
                                             DepartmentName = departmentStudent.DepartmentName,
                                             AcademicUnitDetail = new AcademicUnitDetailDto
                                             {
                                                 Id = academicUnitStudent.Id,
                                                 AcademicUnitName = academicUnitStudent.AcademicUnitName,
                                                 AcademicUnitType = academicUnitTypeStudent
                                             }
                                         },
                                         ProfilePicture = context.ProfilePictures.Where(p => p.PersonId == personStudent.Id).SingleOrDefault()
                                     }
                                 },
                                 TakingLectureDetail = new TakingLectureDetailDto
                                 {
                                     Id = takingLecture.Id,
                                     StudentDetail = new StudentDetailDto {  },
                                     OpenLectureDetail = new OpenLectureDetailDto
                                     {
                                         Id = openLecture.Id,
                                         Status = openLecture.Status,
                                         Semester = semester,
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
                                                 },
                                                 ProfilePicture = context.ProfilePictures.Where(p => p.PersonId == personTeacher.Id).SingleOrDefault()
                                             }
                                         },

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

                             // Exam Type
                             join examType in context.ExamTypes
                             on exam.ExamTypeId equals examType.Id

                             // Of Lecture
                             join takingLecture in context.TakingLectures
                             on exam.TakingLectureId equals takingLecture.Id

                             join openLecture in context.OpenLectures
                             on takingLecture.OpenLectureId equals openLecture.Id

                             join semester in context.Semesters
                             on openLecture.SemesterId equals semester.Id

                             join lecture in context.Lectures
                             on openLecture.LectureId equals lecture.Id

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
                             // Of Student
                             join student in context.Students
                             on exam.StudentId equals student.Id

                             join curriculum in context.Curriculums
                             on student.CurriculumId equals curriculum.Id

                             join personStudent in context.Persons
                             on student.PersonId equals personStudent.Id

                             join departmentStudent in context.Departments
                             on personStudent.DepartmentId equals departmentStudent.Id

                             join academicUnitStudent in context.AcademicUnits
                             on departmentStudent.AcademicUnitId equals academicUnitStudent.Id

                             join academicUnitTypeStudent in context.AcademicUnitTypes
                             on academicUnitStudent.AcademicUnitTypeId equals academicUnitTypeStudent.Id

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

                             select new ExamDetailDto
                             {
                                 Id = exam.Id,
                                 Point = exam.Point,
                                 ExamType = examType,
                                 StudentDetail = new StudentDetailDto
                                 {
                                     Id = student.Id,
                                     Class = student.Class,
                                     Agno = student.Agno,
                                     Status = student.Status,
                                     Curriculum = curriculum,
                                     PersonDetail = new PersonDetailDto
                                     {
                                         Id = personStudent.Id,
                                         FirstName = personStudent.LastName,
                                         LastName = personStudent.LastName,
                                         IdentityNumber = personStudent.IdentityNumber,
                                         Email = personStudent.Email,
                                         DepartmentDetail = new DepartmentDetailDto
                                         {
                                             Id = departmentStudent.Id,
                                             DepartmentName = departmentStudent.DepartmentName,
                                             AcademicUnitDetail = new AcademicUnitDetailDto
                                             {
                                                 Id = academicUnitStudent.Id,
                                                 AcademicUnitName = academicUnitStudent.AcademicUnitName,
                                                 AcademicUnitType = academicUnitTypeStudent
                                             }
                                         },
                                         ProfilePicture = context.ProfilePictures.Where(p => p.PersonId == personStudent.Id).SingleOrDefault()
                                     }
                                 },
                                 TakingLectureDetail = new TakingLectureDetailDto
                                 {
                                     Id = takingLecture.Id,
                                     StudentDetail = new StudentDetailDto { },
                                     OpenLectureDetail = new OpenLectureDetailDto
                                     {
                                         Id = openLecture.Id,
                                         Status = openLecture.Status,
                                         Semester = semester,
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
                                                 },
                                                 ProfilePicture = context.ProfilePictures.Where(p => p.PersonId == personTeacher.Id).SingleOrDefault()
                                             }
                                         },

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
                                         }
                                     }
                                 }
                             };

                return result.SingleOrDefault();
            }
        }
    }
}
