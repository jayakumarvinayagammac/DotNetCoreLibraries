using Microsoft.EntityFrameworkCore;
using Chinook.API.Features.Artist;
using Chinook.API.Features.Genre;
using Chinook.API.Features.MediaType;
using Chinook.API.Features.Entities;

namespace Chinook.API.Persistence
{
    public class ChinookDbContext : DbContext
    {
        public ChinookDbContext(DbContextOptions<ChinookDbContext> options)
            : base(options)
        {
        }

        public DbSet<Artist> Artists { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<MediaType> MediaTypes { get; set; }
        public DbSet<Playlist> Playlists { get; set; }
    }
}
