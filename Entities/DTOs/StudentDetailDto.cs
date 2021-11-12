using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class StudentDetailDto:IDto
    {
        public int Id { get; set; }
        public string Class { get; set; }
        public PersonDetailDto PersonDetail { get; set; }
    }
}
