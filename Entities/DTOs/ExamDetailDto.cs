using Core.Entities;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class ExamDetailDto:IDto
    {
        public int Id { get; set; }
        public int Point { get; set; }
        public StudentDetailDto StudentDetail { get; set; }
        public TakingLectureDetailDto TakingLectureDetail { get; set; }
        public ExamType ExamType { get; set; }
    }
}
