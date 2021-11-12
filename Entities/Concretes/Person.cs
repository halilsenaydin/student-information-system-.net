using Core.Entities;
using Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concretes
{
    public class Person : AbstractPerson, IEntity
    {
        public override int Id { get; set; }
        public int DepartmentId { get; set; }
        public string IdentityNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; } // University Mail Address
    }
}
