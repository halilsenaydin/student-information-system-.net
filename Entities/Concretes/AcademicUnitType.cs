using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concretes
{
    public class AcademicUnitType:IEntity //Fakülteler, Enstitüler..
    {
        public int Id { get; set; }
        public string AcademicUnitTypeName { get; set; }
    }
}
