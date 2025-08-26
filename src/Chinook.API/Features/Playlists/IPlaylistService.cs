namespace Chinook.API.Features.Playlists
{
    public interface IPlaylistService
    {
        Task<IEnumerable<PlaylistDto>> GetAllPlaylistsAsync(CancellationToken cancellationToken = default);
        Task<PlaylistDto> GetPlaylistByIdAsync(int playlistId, CancellationToken cancellationToken = default);
        // Task<PlaylistDto> CreatePlaylistAsync(PlaylistDto playlistDto, CancellationToken cancellationToken = default);
        // Task<PlaylistDto> UpdatePlaylistAsync(int playlistId, PlaylistDto playlistDto, CancellationToken cancellationToken = default);
        // Task<bool> DeletePlaylistAsync(int playlistId, CancellationToken cancellationToken = default);
    }
}