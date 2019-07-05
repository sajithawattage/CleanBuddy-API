using Cleaner.DataAccess.Repositories;
using Cleaner.DataAccess.UnitOfWork;
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
        private IUnitOfWork _unitOfWork = null;

        public ApproveGroupService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public bool DeleteApproveGroup(int id)
        {
            this._unitOfWork.ApproveGroupUserRepository<ApproveGroup>().Delete(id);
            return false;
        }

        public ApproveGroup GetApproveGroupById(int id)
        {
            return this._unitOfWork.ApproveGroupUserRepository<ApproveGroup>().GetByID(id); 
        }

        public IEnumerable<ApproveGroup> GetApproveGroupList()
        {
            return this._unitOfWork.ApproveGroupUserRepository<ApproveGroup>().GetAll();
        }

        public bool SaveApproveGroup(ApproveGroup approveGroup)
        {
            this._unitOfWork.ApproveGroupUserRepository<ApproveGroup>().Insert(approveGroup);
            return false;
        }

        public bool UpdateApproveGroup(ApproveGroup approveGroup)
        {
            this._unitOfWork.ApproveGroupUserRepository<ApproveGroup>().Update(approveGroup);
            return false;
        }

        
    }
}
