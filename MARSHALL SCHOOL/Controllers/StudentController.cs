﻿using MARSHALL_SCHOOL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MARSHALL_SCHOOL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        StudentRepository stdRepository = new StudentRepository();
        [HttpGet]
        public IActionResult GetS()
        {
            var students = stdRepository.GetAllStudents();
            return Ok(students);
            
        }
        [HttpGet("Id")]
        public IActionResult GetStudentbyid(int Id)

        {
            var students = stdRepository.GetAllStudents();
            var student = students.FirstOrDefault(s => s.Id == Id);
            if(student == null)
            {
                return BadRequest("There are no stundets with this ID!");
            }
            return Ok(student);
        }
        [HttpPost]  
        public IActionResult CreateStudent(Student student)
        {

            var std = stdRepository.CreateStudent(student);
            if(std == null)
            {
                return BadRequest("Unable to create Students");

            }
            return Ok(std);

        }

        [HttpDelete]
        public IActionResult DeleteStudent(int Id) {
            var res = stdRepository.RemoveStudent(Id);
            if(res == 0)
            {
                return NotFound("There are no stunts to delete!");
            }
            return Ok("Deleted Succssfully!");
        }


    }
}
