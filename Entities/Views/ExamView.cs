using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Views
{
    public class ExamView : IView
    {
        // Foreign Keys And Primary Key
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int SemesterId { get; set; }
        public int TakingLectureId { get; set; }
        public int ExamTypeId { get; set; }

        public string ExamTypeName { get; set; }
        public int Point { get; set; }
        public string LetterGradeName { get; set; }
        public decimal EffektRate { get; set; }
        public DateTime ExamDate { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string YearName { get; set; }
        public string SemesterName { get; set; }
        public string LectureName { get; set; }
        public string LectureCode { get; set; }
    }
}
