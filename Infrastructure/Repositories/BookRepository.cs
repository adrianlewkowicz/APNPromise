using System;
using Applications.DTOs;

namespace Infrastructure.Repositories
{
    public class BookRepository : IBookRepository
    {
        // Implementacja metod repozytorium dla książek
        public Task<List<BookDto>> GetBooksAsync(string bearerToken)
        {
            throw new NotImplementedException();
        }
    }
}

