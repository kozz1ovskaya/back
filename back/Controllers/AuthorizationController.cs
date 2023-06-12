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
    }
}