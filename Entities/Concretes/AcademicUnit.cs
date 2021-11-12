using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concretes
{
    public class AcademicUnit:IEntity
    {
        public int Id { get; set; }
        public int AcademicUnitTypeId { get; set; } // eg. Fakülteler
        public string AcademicUnitName { get; set; } // eg. Mühendislik Fakültesi
    }
}
