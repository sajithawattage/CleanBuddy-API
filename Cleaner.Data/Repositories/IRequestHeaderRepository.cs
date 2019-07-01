using Cleaner.Model;

namespace Cleaner.DataAccess.Repositories
{
    public interface IRequestHeaderRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
    }
}
