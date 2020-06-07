using Cleaner.DataAccess;
using System.Collections.Generic;

namespace Cleaner.Business
{
    public interface IApproveGroupUserService
    {
        IEnumerable<ApproveGroupUser> GetApproveGroupUserList();
        ApproveGroupUser GetApproveGroupUserById(int id);
        bool SaveApproveGroupUser(ApproveGroupUser approveGroup);
        bool UpdateApproveGroupUser(ApproveGroupUser approveGroup);
        bool DeleteApproveGroupUser(int id);
    }
}
