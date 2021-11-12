using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concretes
{
    public class Denotation:IEntity
    {
        public int Id { get; set; }
        public string DenotationName { get; set; } // eg. Doktor Öğretim Üyesi
        public string Abbreviation { get; set; } // eg. Dr. Öğr.
    }
}
