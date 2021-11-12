using Core.Entities;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class DepartmentDetailDto:IDto
    {
        public int Id { get; set; }
        public string DepartmentName { get; set; }
        public AcademicUnitDetailDto AcademicUnitDetail { get; set; }
    }
}
