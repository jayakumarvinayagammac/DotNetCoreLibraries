namespace Chinook.API.Features.MediaType;

public interface IMediaTypeService
{
    IEnumerable<MediaType> GetAll();
    MediaType? GetById(int id);
}
