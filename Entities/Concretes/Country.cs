using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concretes
{
    public class Country:IEntity
    {
        public int Id { get; set; }
        public string CountryName { get; set; }
        public string Location { get; set; } // 39.91987 32.85427, GPS Coordinates of Ankara
        public float ExchangeRate { get; set; } // 1 TL Ne Kadar?
    }
}
