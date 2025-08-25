using System.Collections.Generic;
using System.Threading.Tasks;

namespace Chinook.API.Features.Genre
{
    public class GenreService : IGenreService
    {
        private readonly IGenreRepository _genreRepository;

        public GenreService(IGenreRepository genreRepository)
        {
            _genreRepository = genreRepository;
        }

        public async Task<IEnumerable<Genre>> GetAllAsync()
        {
            return await _genreRepository.GetAllAsync();
        }

        public async Task<Genre> GetByIdAsync(int id)
        {
            return await _genreRepository.GetByIdAsync(id);
        }
    }
}
