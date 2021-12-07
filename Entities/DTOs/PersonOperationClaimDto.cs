using Core.Entities;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class PersonOperationClaimDto : IDto
    {
        public int PersonId { get; set; }
        public List<OperationClaim>  OperationClaims { get; set; }
    }
}
