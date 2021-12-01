using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concretes
{
    public class TakingLecture:IEntity // Öğrencilerin aldığı ve öğretmenlerin dönem içinde verdiği dersler.
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int OpenLectureId { get; set; }
    }
}
