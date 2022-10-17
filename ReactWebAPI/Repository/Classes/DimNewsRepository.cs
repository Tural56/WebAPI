using ReactWebAPI.Model;
using ReactWebAPI.Model.AppDbContext;
using ReactWebAPI.Repository.Interfaces;

namespace ReactWebAPI.Repository.Classes
{
    public class DimNewsRepository : IDimNewsRepository
    {
        private readonly AppDbContext db;

        public DimNewsRepository(AppDbContext db)
        {
            this.db = db;
        }

        public DimNews CreateNews(DimNews newNews)
        {
            db.DimNews.Add(newNews);
            db.SaveChanges();
            return newNews;
        }

        public DimNews DeleteNews(Guid id)
        {
            DimNews news = db.DimNews.FirstOrDefault(x => x.Id == id);
            if (news != null)
            {

                db.DimNews.Remove(news);
                db.SaveChanges();
                return news;
            }
            else
            {
                return new DimNews();
            }

        }

        public List<DimNews> GetAllNews()
        {

            var news = db.DimNews.ToList();
            if (news != null)
            {
                return news;
            }
            return new List<DimNews>();
        }

        public DimNews GetNews(Guid id)
        {
            DimNews news = db.DimNews.FirstOrDefault(x => x.Id == id);
            if (news != null)
            {
                return news;
            }
            return new DimNews();
        }

        public List<DimNews> OrderById()
        {
            var list = db.DimNews.OrderBy(x => x.Id).ToList();
            if (list != null)
            {
                return list;
            }
            return new List<DimNews>();
        }

        public DimNews UpdateNews(DimNews newNews)
        {
            if (newNews != null)
            {
                db.DimNews.Update(newNews);
                return newNews;
            }

            return new DimNews();

        }
    }
}
