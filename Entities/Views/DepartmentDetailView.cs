using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Views
{
    public class DepartmentDetailView : IView
    {
        // Departments
        public int Id { get; set; }
        public int AcademicUnitId { get; set; }
        public string DepartmentName { get; set; }

        // AcademicUnitsDetail
        public int AcademicUnitTypeId { get; set; }
        public string AcademicUnitType { get; set; }
        public string AcademicUnitName { get; set; }
    }
}
