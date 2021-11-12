using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concretes
{
    public class OpenLecture:IEntity
    {
        public int Id { get; set; }
        public int LectureOfCurriculumId { get; set; }
        public int SemesterId { get; set; }
    }
}
