using System.Collections.Generic;
using System.Threading.Tasks;
using Chinook.API.Features.Genre;
using Chinook.API.Persistence;

namespace Chinook.API.Features.Genre
{
    public interface IGenreRepository
    {
        Task<IEnumerable<Genre>> GetAllAsync();
        Task<Genre> GetByIdAsync(int id);
        Task<Genre> AddAsync(Genre genre);
        Task<Genre> UpdateAsync(Genre genre);
        Task<bool> DeleteAsync(int id);
    }
}
