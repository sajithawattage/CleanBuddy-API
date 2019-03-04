using Cleaner.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cleaner.DataAccess.Repositories
{
    public interface IRequestHeaderRepository : IGenericRepository<RequestHeader>
    {
        Task<IEnumerable<RequestHeader>> GetAllActiveRequestHeaderList();
        Task<IEnumerable<RequestHeader>> GetAllRequestHeaderList();
        void AddRequestHeader(RequestHeader requestHeader);
        void UpdateRequestHeader(RequestHeader requestHeader);
        void RemoveRequestHeader(RequestHeader requestHeader);
    }
}
