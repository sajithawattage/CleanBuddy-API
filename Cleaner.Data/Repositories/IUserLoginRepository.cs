namespace Cleaner.DataAccess.Repositories
{
    public interface IUserLoginRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        DataAccess.UserAccount GetUser(string userName);
    }
}
