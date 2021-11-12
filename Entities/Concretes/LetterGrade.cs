using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concretes
{
    public class LetterGrade:IEntity // Öğrencilerin aldığı derslerdeki harf notları
    {
        public int Id { get; set; }
        public int TakingLectureId { get; set; }
        public int LetterGradeTypeId { get; set; }
    }
}
