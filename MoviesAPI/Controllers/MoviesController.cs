using Microsoft.AspNetCore.Mvc;
using MoviesAPI.Models;
using System.Collections.Generic;

namespace MoviesAPI.Controllers
{
    [Route("api/movies")]
    public class MoviesController : Controller
    {
        [HttpGet]
        public IActionResult GetAllMovies()
        {
            return Ok(new List<MovieModel>());
        }

        [HttpGet("{id}")]
        public IActionResult GetMovie(int id)
        {
            MovieModel movie = null;

            if (movie == null)
                return NotFound();

            return Ok(movie);
        }

        [HttpPost]
        public IActionResult CreateMovie(MovieModel movie)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            return Ok();
        }
        
        [HttpDelete("{id}")]
        public IActionResult DeleteMovie(int id)
        {
            MovieModel movie = null;

            if (movie == null)
                return NotFound();

            return Ok();
        }
    }
}
