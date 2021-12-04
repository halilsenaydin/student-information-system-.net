using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Views
{
    public class ExamView : IView
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int TakingLectureId { get; set; }
        public int ExamTypeId { get; set; }
        public int PersonId { get; set; }
        public int CurriculumId { get; set; }
        public int PersonDepartmentId { get; set; }
        public int PersonAcademicUnitId { get; set; }
        public int PersonAcademicUnitTypeId { get; set; }
        public int OpenLectureId { get; set; }
        public int LectureId { get; set; }
        public int TeacherId { get; set; }
        public int SemesterId { get; set; }
        public int LectureDepartmentId { get; set; }
        public int TypeOfEducationId { get; set; }
        public int LectureTypeId { get; set; }


        public int Point { get; set; }
        public decimal EffektRate { get; set; }
        public DateTime ExamDate { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int Class { get; set; }
        public decimal Agno { get; set; }
        public bool Status { get; set; }
        public string IdentityNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EMail { get; set; }
        public string DepartmentName { get; set; }
        public string AcademicUnitName { get; set; }
        public string YearName { get; set; }
        public string SemesterName { get; set; }
        public string LectureName { get; set; }
        public string LectureCode { get; set; }
    }
}
