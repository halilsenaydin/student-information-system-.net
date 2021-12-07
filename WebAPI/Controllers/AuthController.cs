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

    }
}
