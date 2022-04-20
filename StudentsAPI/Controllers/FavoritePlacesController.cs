using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentsAPI.Data;
using StudentsAPI.Models;

namespace StudentsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FavoritePlacesController : ControllerBase
    {
        private readonly DataContext _context;

        public FavoritePlacesController(DataContext context)
        {
            _context = context;
        }

        // GET: api/FavoritePlaces
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FavoritePlace>>> GetFavoritePlaces(int? id = null)
        {

            if (id == null || id == 0)
            {
                return await _context.FavoritePlaces.Take(5).ToListAsync();
            }

            return await _context.FavoritePlaces.ToListAsync();
        }

        // GET: api/FavoritePlaces/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FavoritePlace>> GetFavoritePlace(int id)
        {
            var favoritePlace = await _context.FavoritePlaces.FindAsync(id);

            if (favoritePlace == null)
            {
                return NotFound();
            }

            return favoritePlace;
        }

        // PUT: api/FavoritePlaces/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFavoritePlace(int id, FavoritePlace favoritePlace)
        {
            if (id != favoritePlace.Id)
            {
                return BadRequest();
            }

            _context.Entry(favoritePlace).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FavoritePlaceExists(id))
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

        // POST: api/FavoritePlaces
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<FavoritePlace>> PostFavoritePlace(FavoritePlace favoritePlace)
        {
            _context.FavoritePlaces.Add(favoritePlace);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFavoritePlace", new { id = favoritePlace.Id }, favoritePlace);
        }

        // DELETE: api/FavoritePlaces/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<FavoritePlace>> DeleteFavoritePlace(int id)
        {
            var favoritePlace = await _context.FavoritePlaces.FindAsync(id);
            if (favoritePlace == null)
            {
                return NotFound();
            }

            _context.FavoritePlaces.Remove(favoritePlace);
            await _context.SaveChangesAsync();

            return favoritePlace;
        }

        private bool FavoritePlaceExists(int id)
        {
            return _context.FavoritePlaces.Any(e => e.Id == id);
        }
    }
}
