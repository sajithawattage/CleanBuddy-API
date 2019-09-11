using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cleaner.Model;
using Cleaner.DataAccess.Infrastructure;
using Dapper;
using System.Data;
using Cleaner.DataAccess.SqlConstant;
using System.Data.Entity;

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
