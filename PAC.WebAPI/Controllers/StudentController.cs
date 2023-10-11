﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using PAC.Domain;
using PAC.IBusinessLogic;

namespace PAC.WebAPI
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentLogic _studentLogic;

        public StudentController(IStudentLogic studentLogic)
        {
            this._studentLogic = studentLogic;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var students = _studentLogic.GetStudents();
            return Ok(students);
        }

        [HttpGet]
        public IActionResult GetById(int id)
        {
            var students = _studentLogic.GetStudentById(id);
            return Ok(students);
        }

    }
}
