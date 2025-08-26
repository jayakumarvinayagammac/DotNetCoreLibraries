using Chinook.API.Features.Entities;

namespace Chinook.API.Features.Playlists
{
    public class PlaylistMappingProfile : AutoMapper.Profile
    {
        public PlaylistMappingProfile()
        {
            CreateMap<Playlist, PlaylistDto>()
                .ForMember(dest => dest.PlaylistId, opt => opt.MapFrom(src => src.PlaylistId))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name));
                
            CreateMap<PlaylistDto, Playlist>()
                .ForMember(dest => dest.PlaylistId, opt => opt.MapFrom(src => src.PlaylistId))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name));
        }
    }
}