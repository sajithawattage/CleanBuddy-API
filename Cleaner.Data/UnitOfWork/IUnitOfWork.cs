using Cleaner.DataAccess.Repositories;
using System;

namespace Cleaner.DataAccess.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IEmployeeRepository EmployeeRepository { get; }
        IEquipmentRepository EquipmentRepository { get; }
        IAddressRepository AddressRepository{ get; }
        IApproveGroupRepository ApproveGroupRepository { get; }
        IApproveGroupUserRepository ApproveGroupUserRepository { get; }
        IContractorEmployeeRepository ContractorEmployeeRepository { get; }
        IContractorRepository ContractorRepository { get; }
        IEquipmentCategoryRepository EquipmentCategoryRepository { get; }
        IJobRepository JobRepository { get; }
        IJobEquipmentRepository JobEquipmentRepository { get; }
        IRequestHeaderRepository RequestHeaderRepository { get; }
        ISiteRepository SiteRepository { get; }
        ISiteSubContractorRepository SiteSubContractorRepository { get; }
        ISubContractorRepository SubContractorRepository { get; }
        IUserLoginRepository UserLoginRepository { get; }
        IWorkTypeRepository WorkTypeRepository { get; }

        void Complete();
    }
}
