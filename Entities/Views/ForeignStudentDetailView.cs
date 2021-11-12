using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Views
{
    public class ForeignStudentDetailView : IView
    {
        // ForeignStudents
        public int Id { get; set; }
        public int PersonId { get; set; }
        public int CountryId { get; set; }

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

        // Countries
        public string CountryName { get; set; }
        public string Location { get; set; }
        public float ExchangeRate { get; set; }
    }
}
