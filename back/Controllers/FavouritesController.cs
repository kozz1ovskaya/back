using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CarBon.Models;
using System;
using back.Models;

namespace CarBon.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FavouritesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public FavouritesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Favourites
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Favourites>>> GetFavourites()
        {
            return await _context.Favourites.ToListAsync();
        }

        // GET: api/Favourites/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Favourites>> GetFavourites(int id)
        {
            var favourites = await _context.Favourites.FindAsync(id);

            if (favourites == null)
            {
                return NotFound();
            }

            return favourites;
        }

        // POST: api/Favourites
        [HttpPost]
        public async Task<ActionResult<Favourites>> PostFavourites(Product product)
        {
            var favourites = new Favourites
            {
                title = product.title,
                price = product.price,
                image = product.image
            };

            _context.Favourites.Add(favourites);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetFavourites), new { id = favourites.id }, favourites);
        }
    }
}