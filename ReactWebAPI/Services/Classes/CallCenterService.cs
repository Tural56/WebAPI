using ReactWebAPI.Model;
using ReactWebAPI.Repository.Classes;
using ReactWebAPI.Repository.Interfaces;
using ReactWebAPI.Services.Interfaces;

namespace ReactWebAPI.Services
{
    public class CallCenterService : ICallCenterService
    {
        private readonly ICallCenterRepository callCenterRepository;
        public CallCenterQuery CreateQuery(CallCenterQuery newCallCenterQuery)
        {
            if (string.IsNullOrEmpty(newCallCenterQuery.sender_name))
            {
                return new CallCenterQuery();
            }
            else if (string.IsNullOrEmpty(newCallCenterQuery.text))
            {
                return new CallCenterQuery();
            }


            //DimNews news = new DimNews()
            //{
            //    dateTime = DateTime.Now,
            //    Name = newCallCenterQuery.Name,
            //    des = newCallCenterQuery.des,

            //    Id = Guid.NewGuid(),
            //    source_link = requestNews.source_link,
            //    img = requestNews.img,

            //};


            var created_query = callCenterRepository.CreateQuery(newCallCenterQuery);
            return created_query;
        }

        public CallCenterQuery DeleteQuery(Guid id)
        {
            var deleted_query = callCenterRepository.DeleteQuery(id);
            return deleted_query;
        }

        public List<CallCenterQuery> GetAllQuery()
        {
            List<CallCenterQuery> queryList = callCenterRepository.GetAllQuerys();
            return queryList;
        }

        public CallCenterQuery GetCueryById(Guid id)
        {
            var queryById = callCenterRepository.GetCueryById(id);
            return queryById;
        }

        
        public List<CallCenterQuery> OrderByTime()
        {
            var List = callCenterRepository.GetAllQuerys();
            var orderedQuerys = List.OrderBy(x => x.sending_time).ToList();
            return orderedQuerys;
        }

        public CallCenterQuery UpdateQuery(CallCenterQuery newCallCenterQuery)
        {
            var updated_query = callCenterRepository.UpdateQuery(newCallCenterQuery);
            return updated_query;
        }
    }
}
