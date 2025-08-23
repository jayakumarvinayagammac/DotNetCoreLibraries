namespace Chinook.API.Features.Genre;

public interface IGenreService
{
    IEnumerable<Genre> GetAll();
    Genre? GetById(int id);
}
