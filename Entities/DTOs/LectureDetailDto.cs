﻿using Core.Entities;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class LectureDetailDto:IDto
    {
        public int Id { get; set; }
        public string LectureName { get; set; }
        public DepartmentDetailDto DepartmentDetail { get; set; }
        public TypeOfEducation TypeOfEducation { get; set; }
    }
}