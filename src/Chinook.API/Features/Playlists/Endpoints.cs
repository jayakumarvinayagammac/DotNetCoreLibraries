namespace Chinook.API.Features.Playlists
{
    public static class PlaylistEndpoints
    {
        public static void MapPlaylistEndpoints(this WebApplication app)
        {
            app.MapGet("/playlists", async (IPlaylistService playlistService, CancellationToken cancellationToken) =>
            {
                var playlists = await playlistService.GetAllPlaylistsAsync(cancellationToken);
                return Results.Ok(playlists);
            })
            .WithName("GetAllPlaylists")
            .WithTags("Playlists");

            app.MapGet("/playlists/{id:int}", async (int id, IPlaylistService playlistService, CancellationToken cancellationToken) =>
            {
                var playlist = await playlistService.GetPlaylistByIdAsync(id, cancellationToken);
                return playlist is not null ? Results.Ok(playlist) : Results.NotFound();
            })
            .WithName("GetPlaylistById")
            .WithTags("Playlists");
        }
    }
}