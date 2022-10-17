using ReactWebAPI.Model;
using ReactWebAPI.Model.Requests;
using ReactWebAPI.Repository.Classes;
using ReactWebAPI.Repository.Interfaaces;
using ReactWebAPI.Services.Interfaces;

namespace ReactWebAPI.Services.Classes
{
    public class NewsService : INewsService
    {
        private readonly INewsRepository newsDb;

        public NewsService(INewsRepository newsRepository)
        {
            newsDb = newsRepository;
        }

        public News CreateNews(NewsRequest requestNews)
        {
            
            if (string.IsNullOrEmpty(requestNews.Name))
            {
                return new News();
            }
            else if (string.IsNullOrEmpty(requestNews.des))
            {
                return new News();
            }
            else if (string.IsNullOrEmpty(requestNews.text))
            {
                return new News();
            }
            
            News news = new News()
            {
                dateTime = DateTime.Now,
                Name = requestNews.Name,
                des = requestNews.des,
                text = requestNews.text,
                Id = Guid.NewGuid(),
                source_link = requestNews.source_link,
                img = requestNews.img,
                
            };

            
            var created_news = newsDb.CreateNews(news);
            return created_news;
            
            
        }

        public News DeleteNews(Guid id)
        {
            var deleted_news = newsDb.DeleteNews(id);
            return deleted_news;
        }

        public List<News> GetAllNews()
        {
            List<News> newsList = newsDb.GetAllNews();
            return newsList;
        }

        public News GetNewsById(Guid id)
        {
            var newsById = newsDb.GetNews(id);
            return newsById;
        }

        public List<News> GetNewsOrderByTime()
        {
            var newsList = newsDb.GetAllNews();
            var orderedNews = newsList.OrderBy(x => x.dateTime).ToList();
            return orderedNews;
        }

        public News UpdateNews(News news)
        {
            var updated_news = newsDb.UpdateNews(news);
            return updated_news;
        }
    }
}
