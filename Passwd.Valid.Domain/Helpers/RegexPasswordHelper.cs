using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passwd.Valid.Domain.Helpers
{
    public static class RegexPasswordHelper
    {
        public static string Validation { 
            get  { 
                return @"^(?=.*[a-zà-ú])(?=.*[A-ZÀ-Ú])(?=.*\d)(?=.*[-!@#$%^&*()+])(?!.*(.+).*\1)[A-ZÀ-Úa-zà-ú\d-!@#$%^&*()+]{9,}$"; 
            } 
        }
    }
}
