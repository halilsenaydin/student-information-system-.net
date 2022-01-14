using Core.Entities;
using Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concretes
{
    public class SystemAdministrator : AbstractPerson, IEntity
    {
        public override int Id { get; set; }
        public int PersonId { get; set; }
    }
}