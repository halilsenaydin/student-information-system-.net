using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Views
{
    public class TakingLectureView : IView
    {
        // Foreign Keys And Primary Key
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int SemesterId { get; set; }
        public int TeacherId { get; set; }

        // Lectures
        public string LectureName { get; set; }
        public string LectureCode { get; set; }
        public string LectureTypeName { get; set; }

        // Semesters
        public string YearName { get; set; }
        public string SemesterName { get; set; }
    }
}
