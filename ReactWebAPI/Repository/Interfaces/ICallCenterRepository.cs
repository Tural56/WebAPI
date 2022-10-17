using ReactWebAPI.Model;

namespace ReactWebAPI.Repository.Interfaces
{
    public interface ICallCenterRepository
    {
        List<CallCenterQuery> GetAllQuerys();

        CallCenterQuery GetCueryById(Guid id);

        List<CallCenterQuery> OrderById();

        List<CallCenterQuery> OrderByTime();

        CallCenterQuery CreateQuery(CallCenterQuery newCallCenterQuery);

        CallCenterQuery UpdateQuery(CallCenterQuery newCallCenterQuery);

        CallCenterQuery DeleteQuery(Guid id);
    }
}
