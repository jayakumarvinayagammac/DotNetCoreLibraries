namespace Chinook.API.Features.Genre;

public static class GenreDependencyExtensions
{
    public static IServiceCollection AddGenreDependencies(this IServiceCollection services)
    {
        services.AddScoped<IGenreService, GenreService>();
        services.AddScoped<IGenreRepository, GenreRepository>();
        return services;
    }
}
