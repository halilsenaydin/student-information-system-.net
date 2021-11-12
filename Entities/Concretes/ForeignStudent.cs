using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concretes
{
    public class ForeignStudent:IEntity // Yabancı öğrenciler Students tablosunda da tutuluyor ama ek özellikleri ForeignStudents tablosunda tutuluyor.
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public int CountryId { get; set; }
    }
}
