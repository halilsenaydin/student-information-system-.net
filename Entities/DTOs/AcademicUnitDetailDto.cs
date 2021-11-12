using Core.Entities;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class AcademicUnitDetailDto : IDto 
    { 
        public int Id { get; set; }
        public string AcademicUnitName { get; set; }
        public AcademicUnitType AcademicUnitType { get; set; }
    }
}
