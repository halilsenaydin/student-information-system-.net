using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Views
{
    public class TeacherDetailView : IView
    {
        // Teachers
        public int Id { get; set; }
        public int PersonId { get; set; }
        public int DenotationId { get; set; }

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

        // Denotations
        public string DenotationName { get; set; }
        public string Abbreviation { get; set; }
    }
}
