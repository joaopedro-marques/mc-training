using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VideoGameApi.Data;
using VideoGameApi.Models;

namespace VideoGameApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideoGameController(VideoGameDbContext context) : ControllerBase
    {
        private readonly VideoGameDbContext _context = context;

        [HttpGet]
        public async Task<ActionResult<List<VideoGame>>> GetAllVideoGames()
        {
            return Ok(await _context.VideoGames
            .Include(g => g.VideoGameDetails)
            .Include(g => g.Publisher)
            .Include(g => g.Developer)
            .Include(g => g.Genres)
            .ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<VideoGame>> GetVideoGame(int id)
        {
            var videoGame = await _context.VideoGames.FindAsync(id);
            if (videoGame == null)
            {
                return NotFound();
            }
            return Ok(videoGame);
        }

        [HttpPost]
        public  async Task<ActionResult<VideoGame>> AddVideoGame(VideoGame newVideoGame)
        {
            if (newVideoGame == null)
                return BadRequest();
            _context.VideoGames.Add(newVideoGame);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetVideoGame), new { id = newVideoGame.Id }, newVideoGame);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateVideoGame(int id, VideoGame updatedVideoGame)
        {
            var videoGame = await _context.VideoGames.FindAsync(id);
            if (videoGame == null)
                return BadRequest();
            videoGame.Id = updatedVideoGame.Id;
            videoGame.Title = updatedVideoGame.Title;
            videoGame.Developer = updatedVideoGame.Developer;
            videoGame.Publisher = updatedVideoGame.Publisher;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteVideoGame(int id)
        {
            var videoGame = await _context.VideoGames.FindAsync(id);
            if (videoGame == null)
                return NotFound();
            _context.VideoGames.Remove(videoGame);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
