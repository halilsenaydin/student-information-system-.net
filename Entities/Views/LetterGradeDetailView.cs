using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Views
{
    public class LetterGradeDetailView : IView
    {
        // LetterGrades
        public int Id { get; set; }
        public int TakingLectureId { get; set; }
        public int LetterGradeTypeId { get; set; }
        public int PersonId { get; set; }
        public int SemesterId { get; set; }
        public int LectureId { get; set; }
        public int DepartmentId { get; set; }
        public int AcademicUnitId { get; set; }
        public int AcademicUnitTypeId { get; set; }
        public int TypeOfEducationId { get; set; }

        public string IdentityNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string EducationType { get; set; }
        public string DepartmentName { get; set; }
        public string AcademicUnitType { get; set; }
        public string AcademicUnitName { get; set; }
        public string LectureName { get; set; }
        public string YearName { get; set; }
        public string SemesterName { get; set; }
        public string LetterGradeName { get; set; }
    }
}
