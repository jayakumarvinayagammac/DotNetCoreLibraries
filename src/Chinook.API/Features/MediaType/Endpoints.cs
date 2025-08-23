using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace Chinook.API.Features.MediaType;

public static class MediaTypeEndpoints
{
    public static void MapMediaTypeEndpoints(this IEndpointRouteBuilder endpoints)
    {
        endpoints.MapGet("/mediatypes", (IMediaTypeService mediaTypeService) =>
        {
            var mediaTypes = mediaTypeService.GetAll();
            return Results.Ok(mediaTypes);
        })
        .WithName("GetMediaTypes")
        .WithOpenApi();

        endpoints.MapGet("/mediatypes/{id}", (int id, IMediaTypeService mediaTypeService) =>
        {
            var mediaType = mediaTypeService.GetById(id);
            return mediaType is not null ? Results.Ok(mediaType) : Results.NotFound();
        })
        .WithName("GetMediaTypeById")
        .WithOpenApi();
    }
}
