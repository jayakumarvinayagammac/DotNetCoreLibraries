namespace Chinook.API.Features.MediaType;

public class MediaTypeService : IMediaTypeService
{
    private static readonly List<MediaType> _mediaTypes = new()
    {
        new MediaType { MediaTypeId = 1, Name = "MPEG audio" },
        new MediaType { MediaTypeId = 2, Name = "Protected AAC audio" },
        new MediaType { MediaTypeId = 3, Name = "Protected MPEG-4 video" }
    };

    public IEnumerable<MediaType> GetAll() => _mediaTypes;

    public MediaType? GetById(int id) => _mediaTypes.FirstOrDefault(m => m.MediaTypeId == id);
}
