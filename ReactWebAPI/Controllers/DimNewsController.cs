using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReactWebAPI.Model.Requests;
using ReactWebAPI.Model;
using ReactWebAPI.Services.Interfaces;

namespace ReactWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DimNewsController : ControllerBase
    {
        private readonly IDImNewsService newsService;

        public DimNewsController(IDImNewsService newsService)
        {
            this.newsService = newsService;
        }

        [HttpGet("GetAllDimNews")]
        public IActionResult GetAllNews()
        {
            var newslist = newsService.GetAllNews();
            
            if (newslist != null)
            {
                return Ok(newslist);
            }
            else
            {
                return NotFound(newslist);
            }

        }
        [HttpGet("GetDetalOfDimNews")]
        public IActionResult detail(Guid id)
        {

            var res = newsService.GetNewsById(id);
            return Ok(res);
        }
        [HttpPost("CreateDimNews")]
        public IActionResult PostNews(DimNewsRequest request)
        {
            if (request != null)
            {
                var createdNews = newsService.CreateNews(request);
                if (createdNews.Name != null)
                {
                    return Ok(createdNews);
                }

            }

            return BadRequest(request);
        }
        [HttpPut("UpdateDimNews")]
        public IActionResult PutNews(DimNews news)
        {
            var updatedNews = newsService.UpdateNews(news);
            if (updatedNews != null)
            {
                return Ok(updatedNews);
            }
            return NotFound(updatedNews);
        }
        [HttpDelete("DeleteDimNews")]
        public IActionResult delete(Guid id)
        {

            var deleted = newsService.DeleteNews(id);
            return Ok(deleted);
        }
    }
}
