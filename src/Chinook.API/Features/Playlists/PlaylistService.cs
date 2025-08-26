using AutoMapper;
using Chinook.API.Features.Entities;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Chinook.API.Features.Playlists
{
    public class PlaylistService : IPlaylistService
    {
        private readonly IPlaylistRepository _playlistRepository;
        private readonly IMapper _mapper;

        public PlaylistService(IPlaylistRepository playlistRepository, IMapper mapper)
        {
            _playlistRepository = playlistRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<PlaylistDto>> GetAllPlaylistsAsync(CancellationToken cancellationToken = default)
        {
            var playlists = await _playlistRepository.GetAllPlaylistsAsync(cancellationToken);
            return _mapper.Map<IEnumerable<PlaylistDto>>(playlists);
        }
        public async Task<PlaylistDto> GetPlaylistByIdAsync(int playlistId, CancellationToken cancellationToken = default)
        {
            var playlist = await _playlistRepository.GetPlaylistByIdAsync(playlistId, cancellationToken);
            if (playlist == null)
            {
                throw new KeyNotFoundException($"Playlist with ID {playlistId} not found.");
            }
            return _mapper.Map<PlaylistDto>(playlist);
        }
        // public async Task<PlaylistDto> CreatePlaylistAsync(PlaylistDto playlistDto, CancellationToken cancellationToken = default)
        // {
        //     var playlist = _mapper.Map<Playlist>(playlistDto);
        //     // Add creation logic here (e.g., add to DbContext and save changes)
        //     // For demonstration, we'll just return the mapped DTO
        //     return _mapper.Map<PlaylistDto>(playlist);
        // }
        // public async Task<PlaylistDto> UpdatePlaylistAsync(int playlistId, PlaylistDto playlistDto, CancellationToken cancellationToken = default)
        // {
        //     var existingPlaylist = await _playlistRepository.GetPlaylistByIdAsync(playlistId, cancellationToken);
        //     if (existingPlaylist == null)
        //     {
        //         throw new KeyNotFoundException($"Playlist with ID {playlistId} not found.");
        //     }
        //     // Update properties
        //     existingPlaylist.Name = playlistDto.Name;
        //     // Add update logic here (e.g., update DbContext and save changes)
        //     return _mapper.Map<PlaylistDto>(existingPlaylist);
        // }
        // public async Task<bool> DeletePlaylistAsync(int playlistId, CancellationToken cancellationToken = default)
        // {
        //     var existingPlaylist = await _playlistRepository.GetPlaylistByIdAsync(playlistId, cancellationToken);
        //     if (existingPlaylist == null)
        //     {
        //         return false;
        //     }
        //     // Add deletion logic here (e.g., remove from DbContext and save changes)
        //     return true;
        // }          
    }
}