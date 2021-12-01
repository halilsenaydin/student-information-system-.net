using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concretes
{
    public class ExamType:IEntity
    {
        public int Id { get; set; }
        public string ExamTypeName { get; set; } // Vize, Final, Büt, Muafiyet, Ödev..
    }
}
