using System.Threading.Tasks;
using Cleaner.Model;
using Cleaner.DataAccess.Repositories;
using EncryptStringSample;
using Cleaner.DataAccess.UnitOfWork;

namespace Cleaner.Business
{
    public class UserLoginService : IUserLoginService
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserLoginService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public Task<UserAccount> GetUser(string userName, string password)
        {
            //var user = _unitOfWork.GetUser(userName);
            //if(user != null)
            //{
            //    if(ValidatePassword(password, user.Result.PasswordHash)){
            //        return user;
            //    }
            //}
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
