using MoviesAPI.Utils;

namespace MoviesAPI.Models
{
    public class MovieModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string Synopsis { get; set; }
        public Enums.MoviesGenres Genre { get; set; }
    }
}
