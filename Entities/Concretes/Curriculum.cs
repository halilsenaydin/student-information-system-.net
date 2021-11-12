using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concretes
{
    public class Curriculum:IEntity
    {
        public int Id { get; set; }
        public string CurriculumName { get; set; }
    }
}
