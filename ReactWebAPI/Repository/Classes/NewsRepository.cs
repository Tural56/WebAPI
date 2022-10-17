using Microsoft.AspNetCore.Mvc;
using ReactWebAPI.Model;
using ReactWebAPI.Model.AppDbContext;
using ReactWebAPI.Repository.Interfaaces;

namespace ReactWebAPI.Repository.Classes
{
    public class NewsRepository : INewsRepository
    {
        private readonly AppDbContext db;

        public NewsRepository(AppDbContext db)
        {
            this.db = db;
        }

        public News CreateNews(News newNews)
        {
                db.News.Add(newNews);
                db.SaveChanges();
                return newNews;
        }

        public News DeleteNews(Guid id)
        {
            News news = db.News.FirstOrDefault(x => x.Id == id);
            if (news != null)
            {
                
                db.News.Remove(news);
                db.SaveChanges();
                return news;
            }
            else
            {
                return new News();
            }
            
        }

        public List<News> GetAllNews()
        {
            
            var news = db.News.ToList();
            if (news != null)
            {
                return news;
            }
            return new List<News>();
        }

        public News GetNews(Guid id)
        {
            News news = db.News.FirstOrDefault(x => x.Id == id);
            if (news != null)
            {
                return news;
            }
            return new News();
        }

        public List<News> OrderById()
        {
            var list = db.News.OrderBy(x => x.Id).ToList();
            if (list != null)
            {
                return list;
            }
            return new List<News>();
        }

        public News UpdateNews(News newNews)
        {
            if (newNews != null)
            {
                db.News.Update(newNews);
                return newNews;
            }
            
            return new News();
                
        }
    }
}
