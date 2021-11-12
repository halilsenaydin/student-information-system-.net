using Core.Entities;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class LetterGradeDetailDto:IDto
    {
        public int Id { get; set; }
        public LetterGradeType LetterGradeType { get; set; }
        public TakingLectureDetailDto TakingLectureDetail { get; set; }
    }
}
