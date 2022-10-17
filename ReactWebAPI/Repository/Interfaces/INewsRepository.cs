using ReactWebAPI.Model;

namespace ReactWebAPI.Repository.Interfaaces
{
    public interface INewsRepository : IMainRepository<News>
    {
        List<News> GetAllNews();

        News GetNews(Guid id);

        List<News> OrderById();

        News CreateNews(News newNews);

        News UpdateNews(News newNews);

        News DeleteNews(Guid id);
    }
}
