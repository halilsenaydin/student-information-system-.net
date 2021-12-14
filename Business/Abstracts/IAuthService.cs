using Core.Utilities.Results;
using Core.Utilities.Security.JWT;
using Entities.Concretes;
using Entities.DTOs;
using Entities.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstracts
{
    public interface IAuthService
    {
        IDataResult<Person> RegisterForStudent(RegisterForStudentDto registerForStudentDto);
        IDataResult<Person> RegisterForTeacher(RegisterForTeacherDto registerForTeacherDto);
        IDataResult<Person> Login(LoginDto loginDto);
        IDataResult<AccessToken> CreateAccessToken(Person person);
        IResult UserExists(string userName);
    }
}
