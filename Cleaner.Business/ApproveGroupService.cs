using Cleaner.DataAccess.Repositories;
using Cleaner.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaner.Business
{
    public class ApproveGroupService : IApproveGroupService
    {
        IApproveGroupRepository _approveGroupRepo;

        public ApproveGroupService(IApproveGroupRepository approveGroupRepo)
        {
            _approveGroupRepo = approveGroupRepo;
        }

        public bool DeleteApproveGroup(int id)
        {
            return (_approveGroupRepo.Delete(id) > 0) ? true : false;
        }

        public ApproveGroup GetApproveGroupById(int id)
        {
            return _approveGroupRepo.Get(id);
        }

        public Task<IEnumerable<ApproveGroup>> GetApproveGroupList()
        {
            return _approveGroupRepo.GetAll();
        }

        public bool SaveApproveGroup(ApproveGroup approveGroup)
        {
            return (_approveGroupRepo.Add(approveGroup) > 0) ? true : false;
        }

        public bool UpdateApproveGroup(ApproveGroup approveGroup)
        {
            return (_approveGroupRepo.Update(approveGroup) > 0) ? true : false;
        }
    }
}
