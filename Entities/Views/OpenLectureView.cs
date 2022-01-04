using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Views
{
    public class OpenLectureView : IView
    {
        // Foreign Keys And Primary Key
        public int Id { get; set; }
        public int TeacherId { get; set; }
        public int SemesterId { get; set; }

        // Semesters
        public string YearName { get; set; }
        public string SemesterName { get; set; }

        // Lectures
        public int LectureId { get; set; }
        public string LectureName { get; set; }
        public string LectureCode { get; set; }
        public int Class { get; set; }

        // LectureTypes
        public string LectureTypeName { get; set; }

        // TypeOfEducations
        public string EducationType { get; set; }

        // Departments
        public string DepartmentName { get; set; }
    }
}
