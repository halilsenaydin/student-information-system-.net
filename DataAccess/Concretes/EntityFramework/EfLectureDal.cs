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
    public class EfLectureDal : EfEntityRepositoryBase<Lecture, MSSQLContext>, ILectureDal
    {
        public List<LectureDetailDto> GetAllDto(Expression<Func<Lecture, bool>> filter = null)
        {
            using (MSSQLContext context = new MSSQLContext())
            {
                var result = from lecture in filter == null ? context.Lectures : context.Lectures.Where(filter)
                             join department in context.Departments
                             on lecture.DepartmentId equals department.Id

                             join academicUnit in context.AcademicUnits
                             on department.AcademicUnitId equals academicUnit.Id

                             join academicUnitType in context.AcademicUnitTypes
                             on academicUnit.AcademicUnitTypeId equals academicUnitType.Id

                             join typeOfEducation in context.TypeOfEducations
                             on lecture.TypeOfEducationId equals typeOfEducation.Id

                             join curriculum in context.Curriculums
                             on lecture.CurriculumId equals curriculum.Id

                             join lectureType in context.LectureTypes
                             on lecture.LectureTypeId equals lectureType.Id

                             select new LectureDetailDto
                             {
                                 Id = lecture.Id,
                                 Class = lecture.Class,
                                 LectureCode = lecture.LectureCode,
                                 LectureName = lecture.LectureName,
                                 LectureType = lectureType,
                                 TypeOfEducation = typeOfEducation,
                                 Curriculum = curriculum,
                                 LectureContents = context.LectureContents.Where(lc=>lc.LectureId == lecture.Id).ToList(),
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
                             };

                return result.ToList();
            }
        }

        public LectureDetailDto GetDto(Expression<Func<Lecture, bool>> filter)
        {
            using (MSSQLContext context = new MSSQLContext())
            {
                var result = from lecture in context.Lectures.Where(filter)
                             join department in context.Departments
                             on lecture.DepartmentId equals department.Id

                             join academicUnit in context.AcademicUnits
                             on department.AcademicUnitId equals academicUnit.Id

                             join academicUnitType in context.AcademicUnitTypes
                             on academicUnit.AcademicUnitTypeId equals academicUnitType.Id

                             join typeOfEducation in context.TypeOfEducations
                             on lecture.TypeOfEducationId equals typeOfEducation.Id

                             join curriculum in context.Curriculums
                             on lecture.CurriculumId equals curriculum.Id

                             join lectureType in context.LectureTypes
                             on lecture.LectureTypeId equals lectureType.Id

                             select new LectureDetailDto
                             {
                                 Id = lecture.Id,
                                 Class = lecture.Class,
                                 LectureCode = lecture.LectureCode,
                                 LectureName = lecture.LectureName,
                                 LectureType = lectureType,
                                 TypeOfEducation = typeOfEducation,
                                 Curriculum = curriculum,
                                 LectureContents = context.LectureContents.Where(lc => lc.LectureId == lecture.Id).ToList(),
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
                             };

                return result.SingleOrDefault();
            }
        }
    }
}
