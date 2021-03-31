using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passwd.Valid.Domain.Interfaces
{
    public interface IPasswordService
    {
        bool IsValid(string password);
    }
}
