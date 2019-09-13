using Cleaner.DataAccess.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;

namespace Cleaner.DataAccess.Repositories
{
    public class ContractorRepository<TEntity> : Repository<TEntity>, IContractorRepository<TEntity> where TEntity : class
    {
        private readonly KiaOraEntities _context;
        private readonly DbSet<TEntity> _dbSet;

        public ContractorRepository(KiaOraEntities context) : base(context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public Task<IEnumerable<Contractor>> GetAllActiveContractorList()
        {
            throw new NotImplementedException();
        }
    }
}
