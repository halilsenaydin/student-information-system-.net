using Core.Entities;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class TakingLectureDetailDto:IDto
    {
        public int Id { get; set; }
        public PersonDetailDto PersonDetail { get; set; }
        public LectureDetailDto LectureDetail { get; set; }
        public Semester Semester { get; set; }
    }
}
