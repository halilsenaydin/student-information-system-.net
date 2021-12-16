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
    public interface IPersonService
    {
        IResult Add(AbstractPerson entity);
        IResult Delete(AbstractPerson entity);
        IResult Update(AbstractPerson entity);

        IDataResult<Person> GetByUserName(string userName);
        IDataResult<PersonOperationClaimDto> GetClaimsByUserName(string userName);

        Person Get(int id);
        Person GetByIdentityNumber(string identityNumber);
        Person GetByEmail(string email);
        IDataResult<Person> PersonExist(string userName);
    }
}
