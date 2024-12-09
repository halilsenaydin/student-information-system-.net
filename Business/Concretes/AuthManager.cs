﻿using Business.Abstracts;
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
            _contactService = contactService;
            _loginService = loginService;
        }

        public IDataResult<AccessToken> CreateAccessToken(Person person)
        {
            var claims = _loginService.GetClaimsOfPerson(person.Id);
            //var contact = _contactService.GetByPersonId(person.Id);
            User user = new User()
            {
                Id = person.Id,
                Email = person.Email,
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
            var userToCheckByUserName = _personService.PersonExist(loginDto.UserName);
            if (userToCheckByUserName.Success)
            {
                return new ErrorDataResult<Person>("Kullanıcı bulunamadı");
            }

            var login = _loginService.GetByUserName(loginDto.UserName);
            bool isValid = HashingHelper.VerifyPasswordHash(loginDto.Password, login.PasswordHash, login.PasswordSalt);
            if (!isValid)
            {
                return new ErrorDataResult<Person>("Parola hatası");
            }

            return new SuccessDataResult<Person>(userToCheckByUserName.Data);
        }

        public IDataResult<Person> RegisterForStudent(RegisterForStudentDto registerForStudentDto)
        {
            byte[] passwordHash, passwordSalt;
            var password = "741963qwe";
            HashingHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);
            var person = new Person
            {
                IdentityNumber = registerForStudentDto.IdentityNumber,
                DepartmentId = registerForStudentDto.DepartmentId,
                FirstName = registerForStudentDto.FirstName,
                LastName = registerForStudentDto.LastName,
                Email = String.Format("{0}.{1}20@ogr.atauni.edu.tr", registerForStudentDto.FirstName.ToLower(), registerForStudentDto.LastName.ToLower())
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
            var password = "741963qwe";
            HashingHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);
            var person = new Person
            {
                IdentityNumber = registerForTeacherDto.IdentityNumber,
                DepartmentId = registerForTeacherDto.DepartmentId,
                FirstName = registerForTeacherDto.FirstName,
                LastName = registerForTeacherDto.LastName,
                Email = String.Format("{0}.{1}@atauni.edu.tr", registerForTeacherDto.FirstName.ToLower(), registerForTeacherDto.LastName.ToUpper())
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