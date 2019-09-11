using Cleaner.DataAccess.UnitOfWork;
using Cleaner.Model;
using System.Collections.Generic;

namespace Cleaner.Business
{
    public class ApproveGroupService : IApproveGroupService
    {
        private IUnitOfWork _unitOfWork = null;

        public ApproveGroupService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public bool DeleteApproveGroup(int id)
        {
            _unitOfWork.ApproveGroupUserRepository<ApproveGroup>().Delete(id);
            return false;
        }

        public ApproveGroup GetApproveGroupById(int id)
        {
            return _unitOfWork.ApproveGroupUserRepository<ApproveGroup>().GetByID(id);
        }

        public IEnumerable<ApproveGroup> GetApproveGroupList()
        {
            return _unitOfWork.ApproveGroupUserRepository<ApproveGroup>().GetAll();
        }

        public bool SaveApproveGroup(ApproveGroup approveGroup)
        {
            _unitOfWork.ApproveGroupUserRepository<ApproveGroup>().Insert(approveGroup);
            return false;
        }

        public bool UpdateApproveGroup(ApproveGroup approveGroup)
        {
            _unitOfWork.ApproveGroupUserRepository<ApproveGroup>().Update(approveGroup);
            return false;
        }


    }
}
