using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Views
{
    public class TakingLectureDetailView : IView
    {
        // TakingLectures
        public int Id { get; set; }
        public int PersonId { get; set; }
        public int SemesterId { get; set; }
        public int LectureId { get; set; }

        // PersonsDetail
        public int DepartmentId { get; set; }
        public int AcademicUnitId { get; set; }
        public int AcademicUnitTypeId { get; set; }
        public string AcademicUnitType { get; set; }
        public string AcademicUnitName { get; set; }
        public string DepartmentName { get; set; }

        public string IdentityNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        // LecturesDetail
        public int TypeOfEducationId { get; set; }
        public string EducationType { get; set; }
        public string LectureName { get; set; }

        // Semesters
        public string YearName { get; set; }
        public string SemesterName { get; set; }
    }
}
