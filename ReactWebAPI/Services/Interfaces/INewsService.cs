using ReactWebAPI.Model;
using ReactWebAPI.Model.Requests;

namespace ReactWebAPI.Services.Interfaces
{
    public interface INewsService
    {
        List<News> GetAllNews();

        News GetNewsById(Guid id);

        News CreateNews(NewsRequest news);

        News UpdateNews(News news);

        News DeleteNews(Guid id);

        List<News> GetNewsOrderByTime();
    }
}
