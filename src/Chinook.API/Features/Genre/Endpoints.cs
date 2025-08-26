using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace Chinook.API.Features.Genre;

public static class GenreEndpoints
{
    public static void MapGenreEndpoints(this IEndpointRouteBuilder endpoints)
    {
        endpoints.MapGet("/genres", (IGenreService genreService) =>
        {
            var genres = genreService.GetAllAsync();
            return Results.Ok(genres);
        })
        .WithName("GetGenres")
        .WithTags("Genres")
        .WithOpenApi();

        endpoints.MapGet("/genres/{id}", (int id, IGenreService genreService) =>
        {
            var genre = genreService.GetByIdAsync(id);
            return genre is not null ? Results.Ok(genre) : Results.NotFound();
        })
        .WithName("GetGenreById")
        .WithTags("Genres")
        .WithOpenApi();
    }
}
