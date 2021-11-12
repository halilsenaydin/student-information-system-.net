using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concretes
{
    public class LectureOfCurriculum:IEntity // Müfredata ait dersler
    {
        public int Id { get; set; }
        public int CurriculumId { get; set; }
        public int LectureId { get; set; }
        public int LectureTypeId { get; set; } // Her müfredatta seçmeli ve zorunlu dersler değişebilir..
        public int Class { get; set; }
    }
}
