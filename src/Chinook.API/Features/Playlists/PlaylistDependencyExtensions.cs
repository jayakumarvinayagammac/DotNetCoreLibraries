namespace Chinook.API.Features.Playlists
{
    public static class PlaylistDependencyExtensions
    {
        public static IServiceCollection AddPlaylistDependencies(this IServiceCollection services)
        {
            services.AddScoped<IPlaylistService, PlaylistService>();
            services.AddScoped<IPlaylistRepository, PlaylistRepository>();
            return services;
        }
    }
}