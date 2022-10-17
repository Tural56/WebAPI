using ReactWebAPI.Model;
using ReactWebAPI.Repository.Interfaaces;

namespace ReactWebAPI.Repository.Interfaces
{
    public interface IDimNewsRepository : IMainRepository<DimNews>
    {
        List<DimNews> GetAllNews();

        DimNews GetNews(Guid id);

        List<DimNews> OrderById();

        DimNews CreateNews(DimNews newNews);

        DimNews UpdateNews(DimNews newNews);

        DimNews DeleteNews(Guid id);
    }
}
