﻿using Core.Entities;
using Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concretes
{
    public class Student : AbstractPerson, IEntity
    {
        public override int Id { get; set; }
        public int PersonId { get; set; }
        public int CurriculumId { get; set; }
        public string Class { get; set; }
    }
}