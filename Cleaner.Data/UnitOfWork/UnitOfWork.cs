using System;
using System.Collections;
using System.Linq;
using Cleaner.DataAccess.Infrastructure;
using Cleaner.DataAccess.Repositories;

namespace Cleaner.DataAccess.UnitOfWork
{

    public class UnitOfWork : IUnitOfWork, IDisposable
    {







        #region Private Fields

        private readonly CDbContext _context = new CDbContext();
        private bool _disposed = true;
        private Hashtable _repositories;

        #endregion             


        public UnitOfWork()
        {
            if (_repositories == null)
            {
                _repositories = new Hashtable();
            }
        }

        public IAddressRepository<TEntity> AddressRepository<TEntity>() where TEntity : class
        {
            return CreateRepositoryInstance<AddressRepository<TEntity>, IAddressRepository<TEntity>>();
        }

        public IEmployeeRepository<TEntity> EmployeeRepository<TEntity>() where TEntity : class
        {
            return CreateRepositoryInstance<EmployeeRepository<TEntity>, IEmployeeRepository<TEntity>>();
        }
        public IApproveGroupUserRepository<TEntity> ApproveGroupUserRepository<TEntity>() where TEntity : class
        {
            return CreateRepositoryInstance<ApproveGroupUserRepository<TEntity>, IApproveGroupUserRepository<TEntity>>();
        }
        //public IContractorEmployeeRepository<TEntity> ContractorEmployeeRepository<TEntity>() where TEntity : class
        //{
        //    return CreateRepositoryInstance<ContractorEmployeeRepository<TEntity>, IContractorEmployeeRepository<TEntity>>();
        //}
        public IContractorRepository<TEntity> ContractorRepository<TEntity>() where TEntity : class
        {
            return CreateRepositoryInstance<ContractorRepository<TEntity>, IContractorRepository<TEntity>>();
        }
        public IEquipmentCategoryRepository<TEntity> EquipmentCategoryRepository<TEntity>() where TEntity : class
        {
            return CreateRepositoryInstance<EquipmentCategoryRepository<TEntity>, IEquipmentCategoryRepository<TEntity>>();
        }
        public IJobRepository<TEntity> JobRepository<TEntity>() where TEntity : class
        {
            return CreateRepositoryInstance<JobRepository<TEntity>, IJobRepository<TEntity>>();
        }
        public IJobEquipmentRepository<TEntity> JobEquipmentRepository<TEntity>() where TEntity : class
        {
            return CreateRepositoryInstance<JobEquipmentRepository<TEntity>, IJobEquipmentRepository<TEntity>>();
        }
        public IRequestHeaderRepository<TEntity> RequestHeaderRepository<TEntity>() where TEntity : class
        {
            return CreateRepositoryInstance<RequestHeaderRepository<TEntity>, IRequestHeaderRepository<TEntity>>();
        }
        public ISiteRepository<TEntity> SiteRepository<TEntity>() where TEntity : class
        {
            return CreateRepositoryInstance<AddressRepository<TEntity>, ISiteRepository<TEntity>>();
        }
        //public ISiteSubContractorRepository<TEntity> SiteSubContractorRepository<TEntity>() where TEntity : class
        //{
        //    return CreateRepositoryInstance<SiteSubContractorRepository<TEntity>, ISiteSubContractorRepository<TEntity>>();
        //}
        //public ISubContractorRepository<TEntity> SubContractorRepository<TEntity>() where TEntity : class
        //{
        //    return CreateRepositoryInstance<SubContractorRepository<TEntity>, ISubContractorRepository<TEntity>>();
        //}
        public IUserLoginRepository<TEntity> UserLoginRepository<TEntity>() where TEntity : class
        {
            return CreateRepositoryInstance<UserLoginRepository<TEntity>, IUserLoginRepository<TEntity>>();
        }
        //public IWorkTypeRepository<TEntity> WorkTypeRepository<TEntity>() where TEntity : class
        //{
        //    return CreateRepositoryInstance<WorkTypeRepository<TEntity>, IWorkTypeRepository<TEntity>>();
        //}
        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public virtual void Dispose(bool disposing)
        {
            if (!_disposed && disposing)
            {
                _context.Dispose();
            }
            _disposed = true;
        }

        private U CreateRepositoryInstance<T, U>()
        {
            var model = typeof(T).GenericTypeArguments.FirstOrDefault();
            if (_repositories.ContainsKey(model.Name))
            {
                return (U)_repositories[model.Name];
            }
            var repositoryType = typeof(T).GetGenericTypeDefinition();
            _repositories.Add(model.Name, Activator.CreateInstance(repositoryType.MakeGenericType(model), _context));
            return (U)_repositories[model.Name];
        }


    }
}
