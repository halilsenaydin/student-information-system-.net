using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concretes
{
    public class Contact:IEntity
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public string Email { get; set; } // İletişim adresi için..
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

    }
}
