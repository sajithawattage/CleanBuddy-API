using Cleaner.DataAccess;
using System.Collections.Generic;

namespace Cleaner.Business
{
    public interface IApproveGroupService
    {
        IEnumerable<ApproveGroup> GetApproveGroupList();
        ApproveGroup GetApproveGroupById(int id);
        bool SaveApproveGroup(ApproveGroup approveGroup);
        bool UpdateApproveGroup(ApproveGroup approveGroup);
        bool DeleteApproveGroup(int id);
    }
}
