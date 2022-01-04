using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entities.Abstracts;
using Entities.Concretes;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstracts
{
    public interface IPersonOperationClaimService
    {
        IResult Add(UserOperationClaim entity);
        IResult Delete(UserOperationClaim entity);
        IResult Update(UserOperationClaim entity);
    }
}
