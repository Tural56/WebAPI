using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReactWebAPI.Model;
using ReactWebAPI.Model.Requests;
using ReactWebAPI.Services.Interfaces;

namespace ReactWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsController : ControllerBase
    {
        private readonly  INewsService newsService;

        public NewsController(INewsService newsService)
        {
            this.newsService = newsService;
        }

        [HttpGet("GetAllNews")]
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
        [HttpGet("GetDetalOfNews")]
        public IActionResult detail(Guid id)
        {
            
            var res = newsService.GetNewsById(id);
            return Ok(res);
        }
        [HttpPost("CreateNews")]
        public IActionResult PostNews(NewsRequest request)
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
        [HttpPut("UpdateNews")]
        public IActionResult PutNews(News news)
        {
            var updatedNews = newsService.UpdateNews(news);
            if (updatedNews != null)
            {
                return Ok(updatedNews);
            }
            return NotFound(updatedNews);
        }
        [HttpDelete("DeleteNews")]
        public IActionResult delete(Guid id)
        {

            var deleted = newsService.DeleteNews(id);
            return Ok(deleted);
        }
    }
}
