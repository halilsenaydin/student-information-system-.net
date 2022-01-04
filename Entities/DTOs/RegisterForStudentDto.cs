using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class RegisterForStudentDto : IDto
    {
        // For Students Tables
        public int CurriculumId { get; set; }
        public int Class { get; set; }
        public decimal Agno { get; set; }

        // For Persons Tables
        public int DepartmentId { get; set; }
        public string IdentityNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}