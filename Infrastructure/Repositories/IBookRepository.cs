using Applications.DTOs;

namespace Infrastructure.Repositories
{
    public interface IBookRepository
    {
        // Deklaracje metod repozytorium dla książek
        Task<List<BookDto>> GetBooksAsync(string bearerToken);
    }
}

