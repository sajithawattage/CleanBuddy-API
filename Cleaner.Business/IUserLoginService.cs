using Cleaner.DataAccess;

namespace Cleaner.Business
{
    public interface IUserLoginService
    {
        UserAccount GetUser(string userName, string password);
    }
}
