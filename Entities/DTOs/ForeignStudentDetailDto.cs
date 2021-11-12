using Core.Entities;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class ForeignStudentDetailDto:IDto
    {
        public int Id { get; set; }
        public PersonDetailDto PersonDetail { get; set; }
        public Country Country { get; set; }
    }
}
