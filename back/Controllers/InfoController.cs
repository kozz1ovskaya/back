using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CarBon.Models;

namespace CarBon.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InfoController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public InfoController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserInfo>>> GetUser()
        {
            return await _context.UserInfo.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UserInfo>> GetUser(int id)
        {
            var user = await _context.UserInfo.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            return user;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutUser(int id, UserInfo user)
        {
            if (id != user.id)
            {
                return BadRequest();
            }

            _context.Entry(user).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<UserInfo>> PostUser(UserInfo user)
        {
            _context.UserInfo.Add(user);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUser", new { id = user.id }, user);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var user = await _context.UserInfo.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            _context.UserInfo.Remove(user);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UserExists(int id)
        {
            return _context.UserInfo.Any(e => e.id == id);
        }
    }
}
