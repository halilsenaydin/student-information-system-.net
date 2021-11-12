using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concretes
{
    public class Lecture:IEntity
    {
        public int Id { get; set; }
        public int DepartmentId { get; set; }
        public int TypeOfEducationId { get; set; }
        public string LectureName { get; set; }
    }
}
