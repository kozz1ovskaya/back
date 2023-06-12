
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using CarBon.Models;

namespace CarBon.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthorizationController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AuthorizationController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<UserLogin> GetAllCarts()
        {
            return _context.UserLogin.ToList();
        }

        //[HttpPost]
        //public IActionResult Authenticate(Authorization authorization)
        //{
        //    var user = _context.UserLogin.FirstOrDefault(u => u.login == authorization.login && u.password == authorization.password);

        //    if (user == null)
        //    {
        //        return Unauthorized();
        //    }

        //    // Генерация токена доступа, если аутентификация прошла успешно.
        //    // TODO: реализовать генерацию токена.

        //    return Ok(new { token = "your_access_token" });
        //}
    }
}