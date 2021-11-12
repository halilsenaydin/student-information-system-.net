using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concretes
{
    public class Login:IEntity
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public string UserName { get; set; } // Öğretmenler için belirlenebilir, öğrencilerin identity number değerleridir..
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }
        public bool Status { get; set; }
    }
}
