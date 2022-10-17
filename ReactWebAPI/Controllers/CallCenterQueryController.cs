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
    public class CallCenterQueryController : ControllerBase
    {
        private readonly ICallCenterService callCenterService;

        public CallCenterQueryController(ICallCenterService callCenterService)
        {
            this.callCenterService = callCenterService;
        }

        [HttpGet("GetAllStudent")]
        public IActionResult GetAllStudent()
        {
            var newslist = callCenterService.GetAllQuery();

            if (newslist != null)
            {
                return Ok(newslist);
            }
            else
            {
                return NotFound(newslist);
            }

        }
        [HttpGet("GetDetalOfStudent")]
        public IActionResult detail(Guid id)
        {

            var res = callCenterService.GetQueryById(id);
            return Ok(res);
        }
        [HttpPost("CreateStudent")]
        public IActionResult PostStudent(CallCenterQuery query)
        {
            if (query != null)
            {
                var newQuery = callCenterService.CreateQuery(query);
                if (newQuery.sender_name != null)
                {
                    return Ok(newQuery);
                }

            }

            return BadRequest(query);
        }
        [HttpPut("UpdateStudent")]
        public IActionResult PutStudent(CallCenterQuery query)
        {
            var updatedQuery = callCenterService.UpdateQuery(query);
            if (updatedQuery != null)
            {
                return Ok(updatedQuery);
            }
            return NotFound(updatedQuery);
        }
        [HttpDelete("DeleteStudent")]
        public IActionResult delete(Guid id)
        {

            var deleted = callCenterService.DeleteQuery(id);
            return Ok(deleted);
        }
    }
}
