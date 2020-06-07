using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaner.DataAccess.Repositories
{
    public class ContractorEmployeeRepository<TEntity> : Repository<TEntity>, IContractorEmployeeRepository<TEntity> where TEntity : class
    {
        private readonly KiaOraEntities _context;
        private readonly DbSet<TEntity> _dbSet;

        public ContractorEmployeeRepository(KiaOraEntities context) : base(context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public Task<IEnumerable<ContractorEmployee>> GetAllActiveContractorEmployeeList()
        {
            throw new NotImplementedException();
        }
    }
}
