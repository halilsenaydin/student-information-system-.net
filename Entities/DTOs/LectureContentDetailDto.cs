using Core.Entities;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class LectureContentDetailDto : IDto
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public LectureDetailDto LectureDetail { get; set; }
    }
}
