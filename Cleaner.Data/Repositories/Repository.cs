using Cleaner.DataAccess.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaner.DataAccess.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly KiaOraEntities _context;
        private readonly DbSet<TEntity> _dbSet;

        private IQueryable<TEntity> AsQueryable()
        {
            return _dbSet.AsQueryable().AsNoTracking();
        }

        public Repository(KiaOraEntities context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public virtual void Insert(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        public virtual void Update(TEntity entity)
        {
            if (_context.Entry(entity).State == EntityState.Detached)
            {
                _dbSet.Attach(entity);
            }

            _context.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Delete(int id)
        {
            TEntity entity = _dbSet.Find(id);
            _dbSet.Remove(entity);
        }

        public virtual IQueryable<TEntity> GetAll()
        {
            return AsQueryable();
        }

        public TEntity GetByID(int id)
        {
            TEntity entity = _dbSet.Find(id);
            return entity;
        }
    }
}
