using Cleaner.DataAccess.UnitOfWork;
using Cleaner.Model;
using EncryptStringSample;

namespace Cleaner.Business
{
    public class UserLoginService : IUserLoginService
    {
        private IUnitOfWork _unitOfWork = null;

        public UserLoginService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }
        public UserAccount GetUser(string userName, string password)
        {
            var user = _unitOfWork.UserLoginRepository<UserAccount>().GetUser(userName);
            if (user != null)
            {
                if (ValidatePassword(password, user.PasswordHash))
                {
                    return user;
                }
            }
            return null;
        }

        private bool ValidatePassword(string password, string passwordHash)
        {
            var result = false;
            if (string.Equals(password, StringCipher.Decrypt(passwordHash)))
            {
                result = true;
            }
            return result;
        }
    }
}
