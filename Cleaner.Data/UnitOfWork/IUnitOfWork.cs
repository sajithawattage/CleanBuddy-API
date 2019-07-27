using Cleaner.DataAccess.Repositories;
using System;

namespace Cleaner.DataAccess.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IAddressRepository<TEntity> AddressRepository<TEntity>() where TEntity : class;

        IEmployeeRepository<TEntity> EmployeeRepository<TEntity>() where TEntity : class;

        IApproveGroupUserRepository<TEntity> ApproveGroupUserRepository<TEntity>() where TEntity : class;

        //IContractorEmployeeRepository<TEntity> ContractorEmployeeRepository<TEntity>() where TEntity : class

        IContractorRepository<TEntity> ContractorRepository<TEntity>() where TEntity : class;

        IEquipmentCategoryRepository<TEntity> EquipmentCategoryRepository<TEntity>() where TEntity : class;

        IJobRepository<TEntity> JobRepository<TEntity>() where TEntity : class;

        IJobEquipmentRepository<TEntity> JobEquipmentRepository<TEntity>() where TEntity : class;

        IRequestHeaderRepository<TEntity> RequestHeaderRepository<TEntity>() where TEntity : class;

        ISiteRepository<TEntity> SiteRepository<TEntity>() where TEntity : class;

        //ISiteSubContractorRepository<TEntity> SiteSubContractorRepository<TEntity>() where TEntity : class;

        //ISubContractorRepository<TEntity> SubContractorRepository<TEntity>() where TEntity : class;

        IUserLoginRepository<TEntity> UserLoginRepository<TEntity>() where TEntity : class;

        //IWorkTypeRepository<TEntity> WorkTypeRepository<TEntity>() where TEntity : class;

        void SaveChanges();
    }
}
