using Chinook.API.Features.Genre;
using Chinook.API.Features.MediaType;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// Dependency registration for Genre feature
builder.Services.AddGenreDependencies();
// Dependency registration for MediaType feature
builder.Services.AddMediaTypeDependencies();


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

app.Run();
