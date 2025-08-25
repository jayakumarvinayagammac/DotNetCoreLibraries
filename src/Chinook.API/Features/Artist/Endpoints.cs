using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace Chinook.API.Features.Artist
{
    public static class Endpoints
    {
        public static void MapArtistEndpoints(this IEndpointRouteBuilder endpoints)
        {
            endpoints.MapGet("/artists", async (IArtistService service) =>
                Results.Ok(await service.GetAllAsync()));

            endpoints.MapGet("/artists/{id:int}", async (int id, IArtistService service) =>
            {
                var artist = await service.GetByIdAsync(id);
                return artist is not null ? Results.Ok(artist) : Results.NotFound();
            });

            endpoints.MapPost("/artists", async (Artist artist, IArtistService service) =>
                Results.Created($"/artists/{artist.ArtistId}", await service.CreateAsync(artist)));

            endpoints.MapPut("/artists/{id:int}", async (int id, Artist artist, IArtistService service) =>
            {
                var updated = await service.UpdateAsync(id, artist);
                return updated is not null ? Results.Ok(updated) : Results.NotFound();
            });

            endpoints.MapDelete("/artists/{id:int}", async (int id, IArtistService service) =>
                await service.DeleteAsync(id) ? Results.NoContent() : Results.NotFound());
        }
    }
}
