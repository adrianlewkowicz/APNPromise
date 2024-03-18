using System;
using Applications.DTOs;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Applications.Queries
{
    public class BookQueryService : IBookQueryService
    {
        private readonly DataContext _context; // Zmiana na DataContext

        public BookQueryService(DataContext context) // Zmiana na DataContext
        {
            _context = context;
        }

        public async Task<List<BookDto>> GetBooksAsync(string bearerToken)
        {
            // Tutaj wykonujesz zapytanie do bazy danych za pomocą Entity Framework
            var books = await _context.Books.ToListAsync();

            // Mapujesz obiekty Book na obiekty BookDto
            var bookDtos = books.Select(book => new BookDto
            {
                Id = book.Id,
                Title = book.Title,
                Price = book.Price,
                Bookstand = book.Bookstand,
                Shelf = book.Shelf,
                Authors = book.Authors.Select(author => new AuthorDto
                {
                    FirstName = author.FirstName,
                    LastName = author.LastName
                }).ToList()
            }).ToList();

            return bookDtos;
        }
    }
}

