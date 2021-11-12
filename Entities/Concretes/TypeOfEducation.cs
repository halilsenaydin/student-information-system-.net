using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concretes
{
    public class TypeOfEducation:IEntity // Lisans,  Yüksek Lisans, Doktora..
    {
        public int Id { get; set; }
        public string EducationType { get; set; }
    }
}
