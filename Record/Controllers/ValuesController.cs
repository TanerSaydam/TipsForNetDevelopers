using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Record.Dtos;

namespace Record.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public sealed class ValuesController : ControllerBase
    {
        [HttpPost("[action]")]
        public IActionResult Login(LoginDto loginDto)
        {
            //LoginDto loginDto2 = new()
            //{
            //    Email = "tanersaydam@gmail.com",
            //    Password = "1",
            //    RememberMe = true
            //};
            //loginDto2.Email = string.Empty;

            return Ok("Giriş başarılı");
        }

        [HttpPost("[action]")]
        public IActionResult LoginWithRecord(Login login)
        {
            //Login login2 = new("tanersaydam@gmail.com", "1");            
            return Ok("Giriş başarılı");
        }
    }
}
