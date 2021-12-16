using Business.Abstracts;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstracts;
using Entities.Abstracts;
using Entities.Concretes;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concretes
{
    public class PersonManager : IPersonService
    {
        IPersonDal _dal;
        ILoginService _loginService;
        public PersonManager(IPersonDal dal, ILoginService loginService)
        {
            _dal = dal;
            _loginService = loginService;
        }

        public IResult Add(AbstractPerson entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(AbstractPerson entity)
        {
            throw new NotImplementedException();
        }

        public IResult Update(AbstractPerson entity)
        {
            throw new NotImplementedException();
        }

        public Person Get(int id)
        {
            return _dal.Get(p => p.Id == id);
        }

        public Person GetByIdentityNumber(string identityNumber)
        {
            return _dal.Get(p => p.IdentityNumber == identityNumber);
        }

        public Person GetByEmail(string email)
        {
            return _dal.Get(p => p.Email == email);
        }

        public IDataResult<Person> GetByUserName(string userName)
        {
            var login = _loginService.GetByUserName(userName);
            var person = Get(login.PersonId);

            return new SuccessDataResult<Person>(person);
        }

        public IDataResult<PersonOperationClaimDto> GetClaimsByUserName(string userName)
        {
            var login = _loginService.GetByUserName(userName);
            var claims = _loginService.GetClaimsOfPerson(login.PersonId);
            var personDto = new PersonOperationClaimDto()
            {
                PersonId = login.PersonId,
                OperationClaims = claims
            };

            return new SuccessDataResult<PersonOperationClaimDto>();
        }
        public IDataResult<Person> PersonExist(string userName)
        {
            var login = _loginService.GetByUserName(userName);
            var person = Get(login.PersonId);
            if (login != null)
            {
                return new ErrorDataResult<Person>(person, "Kullanıcı mevcut");
            }

            return new SuccessDataResult<Person>(person); // Kullanıcı mevcut değil.
        }
    }
}
