using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concretes
{
    public class Department:IEntity
    {
        public int Id { get; set; }
        public int AcademicUnitId { get; set; }
        public string DepartmentName { get; set; }
    }
}
