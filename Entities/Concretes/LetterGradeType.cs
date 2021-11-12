using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concretes
{
    public class LetterGradeType:IEntity // AA, BA..
    {
        public int Id { get; set; }
        public string LetterGradeName { get; set; }
    }
}
