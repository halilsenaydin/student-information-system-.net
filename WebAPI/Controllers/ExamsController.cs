﻿using Business.Abstracts;
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
    public class ExamsController : ControllerBase
    {
        IExamService _service;
        public ExamsController(IExamService service)
        {
            _service = service;
        }

        [HttpGet("get")]
        public IActionResult Get(int id)
        {
            var result = _service.Get(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _service.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getdto")]
        public IActionResult GetDto(int id)
        {
            var result = _service.GetDto(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getalldto")]
        public IActionResult GetAllDto()
        {
            var result = _service.GetAllDto();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getdtobystudentid")]
        public IActionResult GetDtoByStudentId(int id)
        {
            var result = _service.GetDtoByStudentId(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getalldtobystudentid")]
        public IActionResult GetAllDtoByStudentId(int id)
        {
            var result = _service.GetAllDtoByStudentId(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getviewbystudentidandsemesterid")]
        public IActionResult GetViewByStudentIdAndSemesterId(int examId, int studentId, int semesterId)
        {
            var result = _service.GetViewByStudentIdAndSemesterId(examId, studentId, semesterId);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getallviewbystudentidandsemesterid")]
        public IActionResult GetAllViewByStudentIdAndSemesterId(int studentId, int semesterId)
        {
            var result = _service.GetAllViewByStudentIdAndSemesterId(studentId, semesterId);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
    }
}
