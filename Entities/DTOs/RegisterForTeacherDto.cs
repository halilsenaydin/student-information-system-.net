using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class RegisterForTeacherDto : IDto
    {
        // For Students Tables
        public int DenotationId { get; set; }

        // For Persons Tables
        public int DepartmentId { get; set; }
        public string IdentityNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}