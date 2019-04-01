using Cleaner.Data.Context;
using System;

namespace Cleaner.Data.DataAccess
{
    public class UnitOfWork : IDisposable
    {
        private CleanerEntities context = new CleanerEntities();
        
        private GenericRepository<Address> addressRepository;
        private GenericRepository<ApproveGroup> approveGroupRepository;
        private GenericRepository<ApproveGroupUser> approveGroupUserRepository;
        private GenericRepository<Contractor> contractorRepository;
        private GenericRepository<ContractorEmployee> contractorEmployeeRepository;
        private GenericRepository<Employee> employeeRepository;
        private GenericRepository<Equipment> equipmentRepository;
        private GenericRepository<EquipmentCategory> equipmentCategoryRepository;
        private GenericRepository<Job> jobRepository;
        private GenericRepository<JobEquipment> jobEquipmentRepository;
        private GenericRepository<RequestHeader> requestHeaderRepository;
        private GenericRepository<Site> siteRepository;
        private GenericRepository<SiteSubContractor> siteSubContractorRepository;
        private GenericRepository<SubContractor> subContractorRepository;
        private GenericRepository<UserLogin> userLoginRepository;
        private GenericRepository<WorkType> workTypeRepository;

        #region Properties

        public GenericRepository<Address> AddressRepository
        {
            get
            {
                if (this.addressRepository == null)
                {
                    this.addressRepository = new GenericRepository<Address>(context);
                }
                return addressRepository;
            }
        }

        public GenericRepository<ApproveGroup> ApproveGroupRepository
        {
            get
            {
                if (this.approveGroupRepository == null)
                {
                    this.approveGroupRepository = new GenericRepository<ApproveGroup>(context);
                }
                return approveGroupRepository;
            }
        }

        public GenericRepository<ApproveGroupUser> ApproveGroupUserRepository
        {
            get
            {
                if (this.approveGroupUserRepository == null)
                {
                    this.approveGroupUserRepository = new GenericRepository<ApproveGroupUser>(context);
                }
                return approveGroupUserRepository;
            }
        }

        public GenericRepository<Contractor> ContractorRepository
        {
            get
            {
                if (this.contractorRepository == null)
                {
                    this.contractorRepository = new GenericRepository<Contractor>(context);
                }
                return contractorRepository;
            }
        }

        public GenericRepository<ContractorEmployee> ContractorEmployeeRepository
        {
            get
            {
                if (this.contractorEmployeeRepository == null)
                {
                    this.contractorEmployeeRepository = new GenericRepository<ContractorEmployee>(context);
                }
                return contractorEmployeeRepository;
            }
        }

        public GenericRepository<Employee> EmployeeRepository
        {
            get
            {
                if (this.employeeRepository == null)
                {
                    this.employeeRepository = new GenericRepository<Employee>(context);
                }
                return employeeRepository;
            }
        }

        public GenericRepository<Equipment> EquipmentRepository
        {
            get
            {
                if (this.equipmentRepository == null)
                {
                    this.equipmentRepository = new GenericRepository<Equipment>(context);
                }
                return equipmentRepository;
            }
        }

        public GenericRepository<EquipmentCategory> EquipmentCategoryRepository
        {
            get
            {
                if (this.equipmentCategoryRepository == null)
                {
                    this.equipmentCategoryRepository = new GenericRepository<EquipmentCategory>(context);
                }
                return equipmentCategoryRepository;
            }
        }

        public GenericRepository<Job> JobRepository
        {
            get
            {
                if (this.jobRepository == null)
                {
                    this.jobRepository = new GenericRepository<Job>(context);
                }
                return jobRepository;
            }
        }

        public GenericRepository<JobEquipment> JobEquipmentRepository
        {
            get
            {
                if (this.jobEquipmentRepository == null)
                {
                    this.jobEquipmentRepository = new GenericRepository<JobEquipment>(context);
                }
                return jobEquipmentRepository;
            }
        }

        public GenericRepository<RequestHeader> RequestHeaderRepository
        {
            get
            {
                if (this.requestHeaderRepository == null)
                {
                    this.requestHeaderRepository = new GenericRepository<RequestHeader>(context);
                }
                return requestHeaderRepository;
            }
        }

        public GenericRepository<Site> SiteRepository
        {
            get
            {
                if (this.siteRepository == null)
                {
                    this.siteRepository = new GenericRepository<Site>(context);
                }
                return siteRepository;
            }
        }

        public GenericRepository<SiteSubContractor> SiteSubContractorRepository
        {
            get
            {
                if (this.siteSubContractorRepository == null)
                {
                    this.siteSubContractorRepository = new GenericRepository<SiteSubContractor>(context);
                }
                return siteSubContractorRepository;
            }
        }

        public GenericRepository<SubContractor> SubContractorRepository
        {
            get
            {
                if (this.subContractorRepository == null)
                {
                    this.subContractorRepository = new GenericRepository<SubContractor>(context);
                }
                return subContractorRepository;
            }
        }

        public GenericRepository<UserLogin> UserLoginRepository
        {
            get
            {
                if (this.userLoginRepository == null)
                {
                    this.userLoginRepository = new GenericRepository<UserLogin>(context);
                }
                return userLoginRepository;
            }
        }

        public GenericRepository<WorkType> WorkTypeRepository
        {
            get
            {
                if (this.workTypeRepository == null)
                {
                    this.workTypeRepository = new GenericRepository<WorkType>(context);
                }
                return workTypeRepository;
            }
        }

        #endregion

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
