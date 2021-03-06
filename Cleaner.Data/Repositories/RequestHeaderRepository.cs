﻿using System.Data.Entity;

namespace Cleaner.DataAccess.Repositories
{
    public class RequestHeaderRepository<TEntity> : Repository<TEntity>, IRequestHeaderRepository<TEntity> where TEntity : class
    {
        private readonly KiaOraEntities _context;
        private readonly DbSet<TEntity> _dbSet;

        public RequestHeaderRepository(KiaOraEntities context) : base(context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }
        
    }
}
