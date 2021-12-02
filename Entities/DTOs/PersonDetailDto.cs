using Core.Entities;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class PersonDetailDto:IDto
    {
        public int Id { get; set; }
        public string IdentityNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DepartmentDetailDto DepartmentDetail { get; set; }
        public ProfilePicture ProfilePicture { get; set; }
    }
}
