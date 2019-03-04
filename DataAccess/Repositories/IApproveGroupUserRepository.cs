using Cleaner.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cleaner.DataAccess.Repositories
{
    public interface IApproveGroupUserRepository : IGenericRepository<ApproveGroupUser>
    {
        Task<IEnumerable<ApproveGroupUser>> GetAllActiveEmployeeList();
    }
}
