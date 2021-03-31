using Passwd.Valid.Domain.Helpers;
using System;
using System.Text.RegularExpressions;

namespace Passwd.Valid.Domain.Entities
{
    public class Password
    {
        public Password(string passwordValidation)
        {
            try
            {
                this.Passwd = passwordValidation;

                this.PasswdIsValid = Regex.IsMatch(
                        this.Passwd,
                        RegexPasswordHelper.Validation
                    );
            }
            catch (RegexMatchTimeoutException)
            {
                this.PasswdIsValid = false;
            }
            catch (ArgumentException)
            {
                this.PasswdIsValid = false;
            }
        }

        public string Passwd { get; }
        public bool PasswdIsValid { get; }
    }
}
