using System;
using Applications.DTOs;

namespace Applications.Queries
{
    public interface IBookQueryService
    {
        Task<List<BookDto>> GetBooksAsync(string bearerToken);
    }
}

