namespace Chinook.API.Features.Genre;

public static class GenreDependencyExtensions
{
    public static IServiceCollection AddGenreDependencies(this IServiceCollection services)
    {
        services.AddScoped<IGenreService, GenreService>();
        return services;
    }
}
