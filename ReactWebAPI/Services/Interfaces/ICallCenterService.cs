using ReactWebAPI.Model;

namespace ReactWebAPI.Services.Interfaces
{
    public interface ICallCenterService
    {
        List<CallCenterQuery> GetAllQuery();

        CallCenterQuery GetQueryById(Guid id);

        

        List<CallCenterQuery> OrderByTime();

        CallCenterQuery CreateQuery(CallCenterQuery newCallCenterQuery);

        CallCenterQuery UpdateQuery(CallCenterQuery newCallCenterQuery);

        CallCenterQuery DeleteQuery(Guid id);
    }
}
