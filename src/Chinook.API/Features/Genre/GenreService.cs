namespace Chinook.API.Features.Genre;

public class GenreService : IGenreService
{
    private static readonly List<Genre> _genres = new()
    {
        new Genre(1, "Rock"),
        new Genre(2, "Jazz"),
        new Genre(3, "Metal")
    };

    public IEnumerable<Genre> GetAll() => _genres;

    public Genre? GetById(int id) => _genres.FirstOrDefault(g => g.GenreId == id);
}
