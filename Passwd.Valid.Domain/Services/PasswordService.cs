using Passwd.Valid.Domain.Entities;
using Passwd.Valid.Domain.Interfaces;

namespace Passwd.Valid.Domain.Services
{
    public class PasswordService : IPasswordService
    {
        public bool IsValid(string passwordValidation)
        {
            var passObj = new Password(passwordValidation);
            return passObj.PasswdIsValid;
        }
    }
}
