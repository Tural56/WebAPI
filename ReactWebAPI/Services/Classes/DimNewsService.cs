using ReactWebAPI.Model;
using ReactWebAPI.Model.Requests;
using ReactWebAPI.Repository.Interfaaces;
using ReactWebAPI.Repository.Interfaces;
using ReactWebAPI.Services.Interfaces;

namespace ReactWebAPI.Services.Classes
{
    public class DimNewsService : IDImNewsService
    {
        private readonly IDimNewsRepository newsDb;

        public DimNewsService(IDimNewsRepository newsDb)
        {
            this.newsDb = newsDb;
        }

        public DimNews CreateNews(DimNewsRequest requestNews)
        {

            if (string.IsNullOrEmpty(requestNews.Name))
            {
                return new DimNews();
            }
            else if (string.IsNullOrEmpty(requestNews.des))
            {
                return new DimNews();
            }
            

            DimNews news = new DimNews()
            {
                dateTime = DateTime.Now,
                Name = requestNews.Name,
                des = requestNews.des,
                
                Id = Guid.NewGuid(),
                source_link = requestNews.source_link,
                img = requestNews.img,

            };


            var created_news = newsDb.CreateNews(news);
            return created_news;


        }

        public DimNews DeleteNews(Guid id)
        {
            var deleted_news = newsDb.DeleteNews(id);
            return deleted_news;
        }

        public List<DimNews> GetAllNews()
        {
            List<DimNews> newsList = newsDb.GetAllNews();
            return newsList;
        }

        public DimNews GetNewsById(Guid id)
        {
            var newsById = newsDb.GetNews(id);
            return newsById;
        }

        public List<DimNews> GetNewsOrderByTime()
        {
            var newsList = newsDb.GetAllNews();
            var orderedNews = newsList.OrderBy(x => x.dateTime).ToList();
            return orderedNews;
        }

        public DimNews UpdateNews(DimNews news)
        {
            var updated_news = newsDb.UpdateNews(news);
            return updated_news;
        }
    }
}
