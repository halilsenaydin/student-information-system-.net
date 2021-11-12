using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Views
{
    public class AcademicUnitView : IView
    {
        // AcademicUnits
        public int Id { get; set; }
        public int AcademicUnitTypeId { get; set; }
        public string AcademicUnitName { get; set; }

        // AcademicUnitTypes
        public string AcademicUnitType { get; set; }
    }
}
