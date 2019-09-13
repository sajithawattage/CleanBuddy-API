namespace Cleaner.DataAccess.Repositories
{
    public interface IUserLoginRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        Model.UserAccount GetUser(string userName);
    }
}
