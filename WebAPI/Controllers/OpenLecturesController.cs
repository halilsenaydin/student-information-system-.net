using Business.Abstracts;
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
    public class OpenLecturesController : ControllerBase
    {
        IOpenLectureService _service;
        public OpenLecturesController(IOpenLectureService service)
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

        [HttpGet("getviewbyteacheridandsemesterid")]
        public IActionResult GetViewByTeacherIdAndSemesterId(int teacherId, int semesterId)
        {
            var result = _service.GetViewByTeacherIdAndSemesterId(teacherId, semesterId);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getallviewbyteacheridandsemesterid")]
        public IActionResult GetAllViewByTeacherIdAndSemesterId(int teacherId, int semesterId)
        {
            var result = _service.GetAllViewByTeacherIdAndSemesterId(teacherId, semesterId);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
    }
}
