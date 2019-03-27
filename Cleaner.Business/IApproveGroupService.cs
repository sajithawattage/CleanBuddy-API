using Cleaner.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
