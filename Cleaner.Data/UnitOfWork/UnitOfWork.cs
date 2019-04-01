using System;
using Cleaner.DataAccess.Repositories;

namespace Cleaner.DataAccess.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        
        private readonly IAddressRepository _addressRepository;
        private readonly IApproveGroupRepository _approveGroupRepository;
        private readonly IApproveGroupUserRepository _approveGroupUserRepository;
        private readonly IContractorEmployeeRepository _contractorEmployeeRepository;
        private readonly IContractorRepository _contractorRepository;
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IEquipmentCategoryRepository _equipmentCategoryRepository;
        private readonly IEquipmentRepository _equipmentRepository;
        private readonly IJobEquipmentRepository _jobEquipmentRepository;
        private readonly IJobRepository _jobRepository;
        private readonly IRequestHeaderRepository _requestHeaderRepository;
        private readonly ISiteRepository _siteRepository;
        private readonly ISiteSubContractorRepository _siteSubContractorRepository;
        private readonly ISubContractorRepository _subContractorRepository;
        private readonly IUserLoginRepository _userLoginRepository;
        private readonly IWorkTypeRepository _workTypeRepository;

        #region Constructors
        
        public UnitOfWork(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public UnitOfWork(IAddressRepository addressRepository)
        {
            _addressRepository = addressRepository;
        }

        public UnitOfWork(IApproveGroupRepository approveGroupRepository)
        {
            _approveGroupRepository = approveGroupRepository;
        }

        public UnitOfWork(IApproveGroupUserRepository approveGroupUserRepository)
        {
            _approveGroupUserRepository = approveGroupUserRepository;
        }
        
        public UnitOfWork(IContractorEmployeeRepository contractorEmployeeRepository)
        {
            _contractorEmployeeRepository = contractorEmployeeRepository;
        }

        public UnitOfWork(IContractorRepository contractorRepository)
        {
            _contractorRepository = contractorRepository;
        }

        public UnitOfWork(IEquipmentCategoryRepository equipmentCategoryRepository)
        {
            _equipmentCategoryRepository = equipmentCategoryRepository;
        }

        public UnitOfWork(IJobRepository jobRepository)
        {
            _jobRepository = jobRepository;
        }

        public UnitOfWork(IJobEquipmentRepository jobEquipmentRepository)
        {
            _jobEquipmentRepository = jobEquipmentRepository;
        }

        public UnitOfWork(IRequestHeaderRepository requestHeaderRepository)
        {
            _requestHeaderRepository = requestHeaderRepository;
        }

        public UnitOfWork(ISiteRepository siteRepository)
        {
            _siteRepository = siteRepository;
        }

        public UnitOfWork(ISiteSubContractorRepository siteSubContractorRepository)
        {
            _siteSubContractorRepository = siteSubContractorRepository;
        }

        public UnitOfWork(ISubContractorRepository subContractorRepository)
        {
            _subContractorRepository = subContractorRepository;
        }

        public UnitOfWork(IUserLoginRepository userLoginRepository)
        {
            _userLoginRepository = userLoginRepository;
        }

        public UnitOfWork(IWorkTypeRepository workTypeRepository)
        {
            _workTypeRepository = workTypeRepository;
        }

        public UnitOfWork(IEquipmentRepository equipmentRepository)
        {
            _equipmentRepository = equipmentRepository;
        }
        
        #endregion

        #region Getter
        
        public IEmployeeRepository EmployeeRepository
        {
            get
            {
                return _employeeRepository;
            }
        }

        public IEquipmentRepository EquipmentRepository
        {
            get
            {
                return _equipmentRepository;
            }
        }

        public IAddressRepository AddressRepository
        {
            get
            {
                return _addressRepository;
            }
        }

        public IApproveGroupRepository ApproveGroupRepository
        {
            get
            {
                return _approveGroupRepository;
            }
        }

        public IApproveGroupUserRepository ApproveGroupUserRepository
        {
            get
            {
                return _approveGroupUserRepository;
            }
        }
        
        public IContractorEmployeeRepository ContractorEmployeeRepository
        {
            get
            {
                return _contractorEmployeeRepository;
            }
        }

        public IContractorRepository ContractorRepository
        {
            get
            {
                return _contractorRepository;
            }
        }

        public IEquipmentCategoryRepository EquipmentCategoryRepository
        {
            get
            {
                return _equipmentCategoryRepository;
            }
        }

        public IJobRepository JobRepository
        {
            get
            {
                return _jobRepository;
            }
        }

        public IJobEquipmentRepository JobEquipmentRepository
        {
            get
            {
                return _jobEquipmentRepository;
            }
        }

        public IRequestHeaderRepository RequestHeaderRepository
        {
            get
            {
                return _requestHeaderRepository;
            }
        }

        public ISiteRepository SiteRepository
        {
            get
            {
                return _siteRepository;
            }
        }

        public ISiteSubContractorRepository SiteSubContractorRepository
        {
            get
            {
                return _siteSubContractorRepository;
            }
        }

        public ISubContractorRepository SubContractorRepository
        {
            get
            {
                return _subContractorRepository;
            }
        }

        public IUserLoginRepository UserLoginRepository
        {
            get
            {
                return _userLoginRepository;
            }
        }

        public IWorkTypeRepository WorkTypeRepository
        {
            get
            {
                return _workTypeRepository;
            }
        }



        #endregion

        void IUnitOfWork.Complete()
        {
            throw new NotImplementedException();
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls



        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~UnitOfWork() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        void IDisposable.Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }
}
