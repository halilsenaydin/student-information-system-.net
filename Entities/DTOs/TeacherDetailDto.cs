using Core.Entities;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class TeacherDetailDto:IDto
    {
        public int Id { get; set; }
        public PersonDetailDto PersonDetail { get; set; }
        public Denotation Denotation { get; set; }
    }
}
