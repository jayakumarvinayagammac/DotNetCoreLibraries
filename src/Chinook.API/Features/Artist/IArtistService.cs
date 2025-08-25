using System.Collections.Generic;
using System.Threading.Tasks;

namespace Chinook.API.Features.Artist
{
    public interface IArtistService
    {
        Task<IEnumerable<Artist>> GetAllAsync();
        Task<Artist> GetByIdAsync(int id);
        Task<Artist> CreateAsync(Artist artist);
        Task<Artist> UpdateAsync(int id, Artist artist);
        Task<bool> DeleteAsync(int id);
    }
}
