using Microsoft.AspNetCore.Mvc;
using Passwd.Valid.Domain.Interfaces;

namespace Passwd.Valid.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class PasswordController : ControllerBase
    {
        private readonly IPasswordService _passwordService;
        public PasswordController(IPasswordService passwordService)
        {
            _passwordService = passwordService;
        }

        [HttpGet, Route("Valid/{passwd}")]
        public bool ValidPassword(string passwd)
        {
            return _passwordService.IsValid(passwd);
        }
    }
}
