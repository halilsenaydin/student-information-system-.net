using Business.Abstracts;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using Core.Utilities.Security.Hashing;
using Core.Utilities.Security.JWT;
using Entities.Concretes;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concretes
{
    public class AuthManager : IAuthService
    {
        IPersonService _personService;
        ILoginService _loginService;
        IContactService _contactService;
        private ITokenHelper _tokenHelper;
        public AuthManager(ITokenHelper tokenHelper, IPersonService personService, IContactService contactService, ILoginService loginService)
        {
            _tokenHelper = tokenHelper;
            _personService = personService;
        }

        public IDataResult<AccessToken> CreateAccessToken(Person person)
        {
            var claims = _loginService.GetClaimsOfPerson(person.Id);
            var contact = _contactService.GetByPersonId(person.Id);
            User user = new User()
            {
                Id = person.Id,
                Email = contact.Data.Email,
                FirstName = person.FirstName,
                LastName = person.LastName
            };

            var accessToken = _tokenHelper.CreateToken(user, claims);
            return new SuccessDataResult<AccessToken>(accessToken, "Token oluşturuldu");
        }

        public IDataResult<Person> Login(LoginDto loginDto)
        {
            var userToCheckByUserName = _loginService.PersonExist(loginDto.UserName);
            if (!userToCheckByUserName.Success)
            {
                return new ErrorDataResult<Person>("Kullanıcı bulunamadı");
            }

            var login = _loginService.GetByUserName(loginDto.UserName);
            if (!HashingHelper.VerifyPasswordHash(loginDto.Password, login.PasswordHash, login.PasswordSalt))
            {
                return new ErrorDataResult<Person>("Parola hatası");
            }

            return new SuccessDataResult<Person>(userToCheckByUserName.Data);
        }
    }
}
