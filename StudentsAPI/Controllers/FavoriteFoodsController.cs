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
    public class FavoriteFoodsController : ControllerBase
    {
        private readonly DataContext _context;

        public FavoriteFoodsController(DataContext context)
        {
            _context = context;
        }

        // GET: api/FavoriteFoods
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FavoriteFood>>> GetFavoriteFoods(int? id)
        {
            if (id == null || id == 0)
            {
                return await _context.FavoriteFoods.Take(5).ToListAsync();
            }

            return await _context.FavoriteFoods.ToListAsync();
        }

        // GET: api/FavoriteFoods/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FavoriteFood>> GetFavoriteFood(int id)
        {
            var favoriteFood = await _context.FavoriteFoods.FindAsync(id);

            if (favoriteFood == null)
            {
                return NotFound();
            }

            return favoriteFood;
        }

        // PUT: api/FavoriteFoods/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFavoriteFood(int id, FavoriteFood favoriteFood)
        {
            if (id != favoriteFood.Id)
            {
                return BadRequest();
            }

            _context.Entry(favoriteFood).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FavoriteFoodExists(id))
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

        // POST: api/FavoriteFoods
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<FavoriteFood>> PostFavoriteFood(FavoriteFood favoriteFood)
        {
            _context.FavoriteFoods.Add(favoriteFood);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFavoriteFood", new { id = favoriteFood.Id }, favoriteFood);
        }

        // DELETE: api/FavoriteFoods/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<FavoriteFood>> DeleteFavoriteFood(int id)
        {
            var favoriteFood = await _context.FavoriteFoods.FindAsync(id);
            if (favoriteFood == null)
            {
                return NotFound();
            }

            _context.FavoriteFoods.Remove(favoriteFood);
            await _context.SaveChangesAsync();

            return favoriteFood;
        }

        private bool FavoriteFoodExists(int id)
        {
            return _context.FavoriteFoods.Any(e => e.Id == id);
        }
    }
}
