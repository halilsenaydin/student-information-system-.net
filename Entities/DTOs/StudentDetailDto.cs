﻿using Core.Entities;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class StudentDetailDto:IDto
    {
        public int Id { get; set; }
        public int Class { get; set; }
        public decimal Agno { get; set; }
        public bool Status { get; set; }
        public PersonDetailDto PersonDetail { get; set; }
        public Curriculum Curriculum { get; set; }
    }
}
