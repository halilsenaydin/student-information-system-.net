using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Views
{
    public class LectureDetailView : IView
    {
        // Lectures
        public int Id { get; set; }
        public int DepartmentId { get; set; }
        public int TypeOfEducationId { get; set; }
        public string LectureName { get; set; }

        // DepartmentsDetail
        public int AcademicUnitId { get; set; }
        public int AcademicUnitTypeId { get; set; }
        public string AcademicUnitType { get; set; }
        public string AcademicUnitName { get; set; }
        public string DepartmentName { get; set; }

        // TypesOfEducation
        public string EducationType { get; set; }
    }
}
