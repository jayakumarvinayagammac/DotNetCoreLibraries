using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chinook.API.Features.Artist
{
    public class ArtistService : IArtistService
    {
        private static readonly List<Artist> _artists = new List<Artist>();
        private static int _nextId = 1;

        public Task<IEnumerable<Artist>> GetAllAsync()
        {
            return Task.FromResult(_artists.AsEnumerable());
        }

        public Task<Artist> GetByIdAsync(int id)
        {
            var artist = _artists.FirstOrDefault(a => a.ArtistId == id);
            return Task.FromResult(artist);
        }

        public Task<Artist> CreateAsync(Artist artist)
        {
            artist.ArtistId = _nextId++;
            _artists.Add(artist);
            return Task.FromResult(artist);
        }

        public Task<Artist> UpdateAsync(int id, Artist artist)
        {
            var existing = _artists.FirstOrDefault(a => a.ArtistId == id);
            if (existing == null) return Task.FromResult<Artist>(null);
            existing.Name = artist.Name;
            return Task.FromResult(existing);
        }

        public Task<bool> DeleteAsync(int id)
        {
            var artist = _artists.FirstOrDefault(a => a.ArtistId == id);
            if (artist == null) return Task.FromResult(false);
            _artists.Remove(artist);
            return Task.FromResult(true);
        }
    }
}
