using Microsoft.Extensions.DependencyInjection;

namespace Chinook.API.Features.Artist
{
    public static class ArtistDependencyExtensions
    {
        public static IServiceCollection AddArtistFeature(this IServiceCollection services)
        {
            services.AddSingleton<IArtistService, ArtistService>();
            return services;
        }
    }
}
