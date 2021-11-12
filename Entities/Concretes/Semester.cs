using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concretes
{
    public class Semester:IEntity
    {
        public int Id { get; set; }
        public string YearName { get; set; } // eg. 2020 - 2021 
        public string SemesterName { get; set; } // eg. Güz Dönemi
    }
}
