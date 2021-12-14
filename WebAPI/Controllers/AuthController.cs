using Business.Abstracts;
using Entities.Concretes;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        IAuthService _service;
        public AuthController(IAuthService service)
        {
            _service = service;
        }

        [HttpGet("login")]
        public IActionResult Login(LoginDto loginDto)
        {
            var result = _service.Login(loginDto);
            if (!result.Success)
            {
                return BadRequest(result);
            }

            var token = _service.CreateAccessToken(result.Data);
            if (!token.Success)
            {
                return BadRequest(token);
            }
            
            return Ok(token);
        }

        [HttpPost("registerforstudent")]
        public ActionResult RegisterForStudent(RegisterForStudentDto registerForStudent)
        {
            var userExists = _service.UserExists(registerForStudent.Email);
            if (!userExists.Success)
            {
                return BadRequest(userExists.Message);
            }

            var registerResult = _service.RegisterForStudent(registerForStudent);
            var result = _service.CreateAccessToken(registerResult.Data);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("registerforteacher")]
        public ActionResult RegisterForTeacher(RegisterForTeacherDto registerForTeacher)
        {
            var userExists = _service.UserExists(registerForTeacher.Email);
            if (!userExists.Success)
            {
                return BadRequest(userExists.Message);
            }

            var registerResult = _service.RegisterForTeacher(registerForTeacher);
            var result = _service.CreateAccessToken(registerResult.Data);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }
    }
}
