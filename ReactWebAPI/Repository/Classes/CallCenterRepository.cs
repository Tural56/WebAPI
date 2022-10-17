using ReactWebAPI.Model;
using ReactWebAPI.Model.AppDbContext;
using ReactWebAPI.Repository.Interfaces;

namespace ReactWebAPI.Repository.Classes
{
    public class CallCenterRepository : ICallCenterRepository
    {
        private readonly AppDbContext db;

        public CallCenterRepository(AppDbContext db)
        {
            this.db = db;
        }

        public CallCenterQuery CreateQuery(CallCenterQuery newCallCenterQuery)
        {
            db.callCenterRequests.Add(newCallCenterQuery);
            db.SaveChanges();
            return newCallCenterQuery;
        }

        public CallCenterQuery DeleteQuery(Guid id)
        {
            CallCenterQuery query = db.callCenterRequests.FirstOrDefault(x => x.Id == id);
            if (query != null)
            {

                db.callCenterRequests.Remove(query);
                db.SaveChanges();
                return query;
            }
            else
            {
                return new CallCenterQuery();
            }
        }

        public List<CallCenterQuery> GetAllQuerys()
        {
            var news = db.callCenterRequests.ToList();
            if (news != null)
            {
                return news;
            }
            return new List<CallCenterQuery>();
        }

        public CallCenterQuery GetCueryById(Guid id)
        {
            CallCenterQuery news = db.callCenterRequests.FirstOrDefault(x => x.Id == id);
            if (news != null)
            {
                return news;
            }
            return new CallCenterQuery();
        }

        public List<CallCenterQuery> OrderById()
        {
            var list = db.callCenterRequests.OrderBy(x => x.Id).ToList();
            if (list != null)
            {
                return list;
            }
            return new List<CallCenterQuery>();
        }

        public List<CallCenterQuery> OrderByTime()
        {
            List<CallCenterQuery> callsLIst = db.callCenterRequests.OrderBy(x => x.sending_time).ToList();
            return callsLIst;
        }

        public CallCenterQuery UpdateQuery(CallCenterQuery newCallCenterQuery)
        {
            if (newCallCenterQuery != null)
            {
                db.callCenterRequests.Update(newCallCenterQuery);
                return newCallCenterQuery;
            }

            return new CallCenterQuery();
        }
    }
}
