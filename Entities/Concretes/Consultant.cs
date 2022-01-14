using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concretes
{
    public class Consultant : IEntity
    {
        public int Id { get; set; }
        public int TeacherId { get; set; }
        public int StudentId { get; set; }
    }
}
