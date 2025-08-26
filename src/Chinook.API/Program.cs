using Chinook.API.Features.Genre;
using Chinook.API.Features.MediaType;
using Chinook.API.Features.Artist;
using Chinook.API.Persistence;
using Microsoft.EntityFrameworkCore;
using Chinook.API.Features.Playlists;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// Dependency registration for Genre feature
builder.Services.AddGenreDependencies();
// Dependency registration for MediaType feature
builder.Services.AddMediaTypeDependencies();
// Dependency registration for Playlist feature
builder.Services.AddPlaylistDependencies();
// Dependency registration for Artist feature
builder.Services.AddArtistFeature();
// Configure DbContext with SQLite
var currentDirectory = Directory.GetCurrentDirectory();
Console.WriteLine($"Current Directory: {currentDirectory}");
builder.Services.AddDbContext<ChinookDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("ChinookConnection")));

builder.Services.AddAutoMapper(typeof(Program));

//builder.Services.AddAutoMapper(typeof(ArtistMappingProfile));
//builder.Services.AddAutoMapper(typeof(GenreMappingProfile));
//private readonly IMapper _mapper;
//var dto = _mapper.Map<GenreDto>(genre);
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
// Register Genre vertical slice endpoints
Chinook.API.Features.Genre.GenreEndpoints.MapGenreEndpoints(app);
// Register MediaType vertical slice endpoints
Chinook.API.Features.MediaType.MediaTypeEndpoints.MapMediaTypeEndpoints(app);
// Register Artist vertical slice endpoints
Chinook.API.Features.Artist.Endpoints.MapArtistEndpoints(app);
// Register Playlist vertical slice endpoints
Chinook.API.Features.Playlists.PlaylistEndpoints.MapPlaylistEndpoints(app);

app.Run();
