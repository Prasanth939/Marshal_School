using MARSHALL_SCHOOL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MARSHALL_SCHOOL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttendanceController : ControllerBase
    {
        AttendenceRepository Attenrepo = new AttendenceRepository();


        [HttpGet("id")]
        public IActionResult GetAttendancebyStudentId(int Id)
        {
            try
            {
                return Ok(Attenrepo.GetAtedenceByStdId(Id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }


        }

        [HttpGet]
        public IActionResult GetAllAttendences()
        {
            var attendences = Attenrepo.GetAllAttencessOrderByDate();
            if (attendences == null)
            {
                return NotFound("there are no attendences");
            }

            return Ok(attendences);
        }

        [HttpGet("{id},{date}")]
        public IActionResult GetAttendenceByIdandDate(int id, string date)
        {

            var attendences = Attenrepo.GetAttedenceByIdAndDate(id, date);
            if (!attendences.Any())
            {
                return NotFound("there are no students with this id and date!");
            }
            return Ok(attendences);
        }
    }
}
