using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concretes
{
    public class Exam:IEntity
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int TakingLectureId { get; set; }
        public int ExamTypeId { get; set; }
        public int Point { get; set; }
    }
}
