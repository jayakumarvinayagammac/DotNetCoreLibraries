using System.Threading.Tasks;
using System.Threading;
using Chinook.API.Features.Entities;
using Chinook.API.Persistence;
using Microsoft.EntityFrameworkCore;
namespace Chinook.API.Features.Playlists
{
    public class PlaylistRepository : IPlaylistRepository
    {
        private readonly ChinookDbContext _context;

        public PlaylistRepository(ChinookDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Playlist>> GetAllPlaylistsAsync(CancellationToken cancellationToken)
        {
            return await _context.Playlists.ToListAsync(cancellationToken);
        }

        public async Task<Playlist?> GetPlaylistByIdAsync(int playlistId, CancellationToken cancellationToken)
        {
            return await _context.Playlists.FindAsync(new object[] { playlistId }, cancellationToken);
        }
    }
}