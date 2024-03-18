using System;
using System.Threading.Tasks;
using Applications.DTOs;
using Domain.Models;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Applications.Commands
{
    public class BookCommandService : IBookCommandService
    {
        private readonly DataContext _context;

        public BookCommandService(DataContext context)
        {
            _context = context;
        }

        // Implementacja wysyłania książki
        public async Task PostBookAsync(BookDto book, string bearerToken)
        {
            // Sprawdzenie, czy token jest prawidłowy (możesz dodać implementację weryfikacji tokenu)

            // Tworzenie nowego obiektu książki na podstawie danych z obiektu DTO
            var newBook = new Book
            {
                Title = book.Title,
                Price = book.Price,
                Bookstand = book.Bookstand,
                Shelf = book.Shelf
                // Możesz dodać inne właściwości książki
            };

            // Dodanie książki do zbioru Books w bazie danych
            _context.Books.Add(newBook);

            // Zapisanie zmian w bazie danych
            await _context.SaveChangesAsync();
        }
    }
}
