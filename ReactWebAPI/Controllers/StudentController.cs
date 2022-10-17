using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReactWebAPI.Model;
using ReactWebAPI.Model.Requests;
using ReactWebAPI.Services.Classes;
using ReactWebAPI.Services.Interfaces;

namespace ReactWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService studentService;

        public StudentController(IStudentService studentService)
        {
            this.studentService = studentService;
        }

        [HttpGet("GetAllStudent")]
        public IActionResult GetAllStudent()
        {
            var studentlist = studentService.GetAllStudents();

            if (studentlist != null)
            {
                return Ok(studentlist);
            }
            else
            {
                return NotFound(studentlist);
            }

        }
        [HttpGet("GetDetalOfStudent")]
        public IActionResult detail(Guid id)
        {

            var res = studentService.GetStudentById(id);
            return Ok(res);
        }
        [HttpPost("CreateStudent")]
        public IActionResult PostStudent(StudentRequest student)
        {
            if (student != null)
            {
                var createdNews = studentService.CreateStudent(student);
                if (createdNews.Name != null)
                {
                    return Ok(createdNews);
                }

            }

            return BadRequest(student);
        }
        [HttpPut("UpdateStudent")]
        public IActionResult PutStudent(Student student)
        {
            var updatedNews = studentService.UpdateStudent(student);
            if (updatedNews != null)
            {
                return Ok(updatedNews);
            }
            return NotFound(updatedNews);
        }
        [HttpDelete("DeleteStudent")]
        public IActionResult delete(Guid id)
        {

            var deleted = studentService.DeleteStudent(id);
            return Ok(deleted);
        }
    }
}
