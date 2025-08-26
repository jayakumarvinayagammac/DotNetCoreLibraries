using System.Threading.Tasks;
using System.Threading;
using Chinook.API.Features.Entities;
namespace Chinook.API.Features.Playlists
{
    public interface IPlaylistRepository
    {
        Task<IEnumerable<Playlist>> GetAllPlaylistsAsync(CancellationToken  cancellationToken);
        Task<Playlist?> GetPlaylistByIdAsync(int playlistId, CancellationToken  cancellationToken);
    }
}