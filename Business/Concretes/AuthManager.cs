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
        ITeacherService _teacherService;
        IStudentService _studentService;
        ILoginService _loginService;
        IContactService _contactService;
        private ITokenHelper _tokenHelper;
        public AuthManager(ITokenHelper tokenHelper, IPersonService personService, IContactService contactService, ILoginService loginService, ITeacherService teacherService, IStudentService studentService)
        {
            _tokenHelper = tokenHelper;
            _personService = personService;
            _teacherService = teacherService;
            _studentService = studentService;
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

        public IResult UserExists(string userName)
        {
            if (_loginService.GetByUserName(userName) != null)
            {
                return new ErrorResult("Kullanıcı mevcut");
            }
            return new SuccessResult();
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

        public IDataResult<Person> RegisterForStudent(RegisterForStudentDto registerForStudentDto)
        {
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(registerForStudentDto.Password, out passwordHash, out passwordSalt);
            var person = new Person
            {
                IdentityNumber = registerForStudentDto.IdentityNumber,
                DepartmentId = registerForStudentDto.DepartmentId,
                FirstName = registerForStudentDto.FirstName,
                LastName = registerForStudentDto.LastName,
                Email = registerForStudentDto.Email
            };
            _personService.Add(person);

            var login = new Login
            {
                PersonId = person.Id,
                UserName = registerForStudentDto.IdentityNumber,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                Status = true
            };
            _loginService.Add(login);

            var student = new Student
            {
                PersonId = person.Id,
                CurriculumId = registerForStudentDto.CurriculumId,
                Class = 1,
                Agno = 4.0M,
                Status = true
            };
            _studentService.Add(student);

            return new SuccessDataResult<Person>(person, "Öğrenci Kaydı Başarıyla Gerçekleştirildi");
        }

        public IDataResult<Person> RegisterForTeacher(RegisterForTeacherDto registerForTeacherDto)
        {
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(registerForTeacherDto.Password, out passwordHash, out passwordSalt);
            var person = new Person
            {
                IdentityNumber = registerForTeacherDto.IdentityNumber,
                DepartmentId = registerForTeacherDto.DepartmentId,
                FirstName = registerForTeacherDto.FirstName,
                LastName = registerForTeacherDto.LastName,
                Email = registerForTeacherDto.Email
            };
            _personService.Add(person);

            var login = new Login
            {
                PersonId = person.Id,
                UserName = registerForTeacherDto.IdentityNumber,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                Status = true
            };
            _loginService.Add(login);

            var teacher = new Teacher
            {
                PersonId = person.Id,
                DenotationId = registerForTeacherDto.DenotationId
                
            };
            _teacherService.Add(teacher);

            return new SuccessDataResult<Person>(person, "Öğretim Elemanı Kaydı Başarıyla Gerçekleştirildi");
        }
    }
}