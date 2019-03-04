using System.Threading.Tasks;
using Cleaner.Model;
using Cleaner.DataAccess.Repositories;
using EncryptStringSample;

namespace Cleaner.Business
{
    public class UserLoginService : IUserLoginService
    {
        IUserLoginRepository _userLoginRepositary;

        public UserLoginService(IUserLoginRepository userLoginRepositary)
        {
            _userLoginRepositary = userLoginRepositary;
        }

        public Task<UserAccount> GetUser(string userName, string password)
        {
            var user = _userLoginRepositary.GetUser(userName);
            if(user != null)
            {
                if(ValidatePassword(password, user.Result.PasswordHash)){
                    return user;
                }
            }
            return null;
        }
        
        private bool ValidatePassword(string password, string passwordHash)
        {
            var result = false;
            if(string.Equals(password, StringCipher.Decrypt(passwordHash)))
            {
                result = true;
            }
            return result;
        }
    }
}
