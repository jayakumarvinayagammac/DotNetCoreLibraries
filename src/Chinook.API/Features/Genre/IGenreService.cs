namespace Chinook.API.Features.Genre;

public interface IGenreService
{
    Task<IEnumerable<Genre>> GetAllAsync();
    Task<Genre> GetByIdAsync(int id);
}
