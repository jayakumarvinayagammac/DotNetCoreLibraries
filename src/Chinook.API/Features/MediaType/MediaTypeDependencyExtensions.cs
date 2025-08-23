namespace Chinook.API.Features.MediaType;

public static class MediaTypeDependencyExtensions
{
    public static IServiceCollection AddMediaTypeDependencies(this IServiceCollection services)
    {
        services.AddScoped<IMediaTypeService, MediaTypeService>();
        return services;
    }
}
