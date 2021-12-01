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
    public class EfLectureContentDal : EfEntityRepositoryBase<LectureContent, MSSQLContext>, ILectureContentDal
    {
        public List<LectureContentDetailDto> GetAllDto(Expression<Func<LectureContent, bool>> filter = null)
        {
            using (MSSQLContext context = new MSSQLContext())
            {
                var result = from lectureContent in filter == null ? context.LectureContents : context.LectureContents.Where(filter)

                             join lecture in context.Lectures
                             on lectureContent.LectureId equals lecture.Id

                             // Of Lecture
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

                             select new LectureContentDetailDto
                             {
                                 Id = lectureContent.Id,
                                 Content = lectureContent.Content,
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
                             };

                return result.ToList();
            }
        }

        public LectureContentDetailDto GetDto(Expression<Func<LectureContent, bool>> filter)
        {
            using (MSSQLContext context = new MSSQLContext())
            {
                var result = from lectureContent in context.LectureContents.Where(filter)

                             join lecture in context.Lectures
                             on lectureContent.LectureId equals lecture.Id

                             // Of Lecture
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

                             select new LectureContentDetailDto
                             {
                                 Id = lectureContent.Id,
                                 Content = lectureContent.Content,
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
                             };

                return result.SingleOrDefault();
            }
        }
    }
}
