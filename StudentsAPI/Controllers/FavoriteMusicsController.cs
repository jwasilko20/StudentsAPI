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
    public class FavoriteMusicsController : ControllerBase
    {
        private readonly DataContext _context;

        public FavoriteMusicsController(DataContext context)
        {
            _context = context;
        }

        // GET: api/FavoriteMusics
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FavoriteMusic>>> GetFavoriteMusics(int? id)
        {
            if (id == null || id == 0)
            {
                return await _context.FavoriteMusics.Take(5).ToListAsync();

            }

            return await _context.FavoriteMusics.ToListAsync();
        }

        // GET: api/FavoriteMusics/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FavoriteMusic>> GetFavoriteMusic(int id)
        {
            var favoriteMusic = await _context.FavoriteMusics.FindAsync(id);

            if (favoriteMusic == null)
            {
                return NotFound();
            }

            return favoriteMusic;
        }

        // PUT: api/FavoriteMusics/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFavoriteMusic(int id, FavoriteMusic favoriteMusic)
        {
            if (id != favoriteMusic.Id)
            {
                return BadRequest();
            }

            _context.Entry(favoriteMusic).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FavoriteMusicExists(id))
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

        // POST: api/FavoriteMusics
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<FavoriteMusic>> PostFavoriteMusic(FavoriteMusic favoriteMusic)
        {
            _context.FavoriteMusics.Add(favoriteMusic);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFavoriteMusic", new { id = favoriteMusic.Id }, favoriteMusic);
        }

        // DELETE: api/FavoriteMusics/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<FavoriteMusic>> DeleteFavoriteMusic(int id)
        {
            var favoriteMusic = await _context.FavoriteMusics.FindAsync(id);
            if (favoriteMusic == null)
            {
                return NotFound();
            }

            _context.FavoriteMusics.Remove(favoriteMusic);
            await _context.SaveChangesAsync();

            return favoriteMusic;
        }

        private bool FavoriteMusicExists(int id)
        {
            return _context.FavoriteMusics.Any(e => e.Id == id);
        }
    }
}
