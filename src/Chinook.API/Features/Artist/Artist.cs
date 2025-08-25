namespace Chinook.API.Features.Artist
{
    public record Artist
    {
        public int ArtistId { get; set; }
        public string Name { get; set; }
    }
     public record ArtistDto(int ArtistId, string Name);    
}
