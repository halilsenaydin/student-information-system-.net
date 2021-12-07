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
    public interface ILoginService
    {
        IResult Add(Login entity);
        IResult Delete(Login entity);
        IResult Update(Login entity);

        Login GetByUserName(string userName);
        List<OperationClaim> GetClaimsOfPerson(int personId);
        IDataResult<Person> PersonExist(string userName);
    }
}
