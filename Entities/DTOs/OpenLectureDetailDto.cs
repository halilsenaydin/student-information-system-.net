using Core.Entities;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class OpenLectureDetailDto : IDto
    {
        public int Id { get; set; }
        public bool Status { get; set; }
        public TeacherDetailDto TeacherDetail { get; set; }
        public LectureDetailDto LectureDetail { get; set; }
        public Semester Semester { get; set; }
    }
}
