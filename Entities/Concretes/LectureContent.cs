using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concretes
{
    public class LectureContent:IEntity
    {
        public int Id { get; set; }
        public int LectureId { get; set; }
        public string Content { get; set; }
    }
}
