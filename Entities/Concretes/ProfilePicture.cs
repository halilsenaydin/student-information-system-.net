using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concretes
{
    public class ProfilePicture:IEntity
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public string Path { get; set; }
        public DateTime Date { get; set; }
    }
}
