using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReactWebAPI.Model.Requests;
using ReactWebAPI.Model;
using ReactWebAPI.Services.Classes;
using ReactWebAPI.Services.Interfaces;

namespace ReactWebAPI.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class VacancyController : ControllerBase
    {

        private readonly IVacancyService vacancyService;

        public VacancyController(IVacancyService vacancyService)
        {
            this.vacancyService = vacancyService;
        }

        [HttpGet("GetAllVacancy")]
        public IActionResult GetAllVacancy()
        {
            var vacancies = vacancyService.GetAllVacancy();

            if (vacancies != null)
            {
                return Ok(vacancies);
            }
            else
            {
                return NotFound(vacancies);
            }

        }
        [HttpGet("GetDetalOfVacancy")]
        public IActionResult detail(Guid id)
        {

            var res = vacancyService.GetVacancyById(id);
            return Ok(res);
        }
        [HttpPost("CreateVacancy")]
        public IActionResult PostVacancy(Vacancy vacancy)
        {
            if (vacancy != null)
            {
                var createdVacancy = vacancyService.CreateVacancy(vacancy);
                if (createdVacancy.Name != null)
                {
                    return Ok(createdVacancy);
                }

            }

            return BadRequest(vacancy);
        }
        [HttpPut("UpdateVacancy")]
        public IActionResult PutVacancy(Vacancy vacancy)
        {
            var updatedVacancy = vacancyService.UpdateVacancy(vacancy);
            if (updatedVacancy != null)
            {
                return Ok(updatedVacancy);
            }
            return NotFound(updatedVacancy);
        }
        [HttpDelete("DeleteVacancy")]
        public IActionResult delete(Guid id)
        {

            var deleted = vacancyService.DeleteVacancy(id);
            return Ok(deleted);
        }
    }
}
