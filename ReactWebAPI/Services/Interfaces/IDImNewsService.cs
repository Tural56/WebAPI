using ReactWebAPI.Model.Requests;
using ReactWebAPI.Model;

namespace ReactWebAPI.Services.Interfaces
{
    public interface IDImNewsService
    {
        List<DimNews> GetAllNews();

        DimNews GetNewsById(Guid id);

        DimNews CreateNews(DimNewsRequest news);

        DimNews UpdateNews(DimNews news);

        DimNews DeleteNews(Guid id);

        List<DimNews> GetNewsOrderByTime();
    }
}
