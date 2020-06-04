namespace Cleaner.DataAccess.Repositories
{
    public interface IJobRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
    }
}
