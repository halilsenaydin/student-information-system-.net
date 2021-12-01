using Core.Entities;
using Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concretes
{
    public class OpenLecture : IEntity
    {
        public int Id { get; set; }
        public int LectureId { get; set; }
        public int TeacherId { get; set; }
        public int SemesterId { get; set; }
        public bool Status { get; set; }
    }
}
