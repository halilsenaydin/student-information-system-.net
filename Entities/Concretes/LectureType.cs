using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concretes
{
    public class LectureType:IEntity // Seçmeli, Zorunlu
    {
        public int Id { get; set; }
        public int LectureTypeName { get; set; }
    }
}
