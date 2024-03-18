using System;
using Applications.DTOs;

namespace Applications.Commands
{
    public interface IBookCommandService
    {
        Task PostBookAsync(BookDto book, string bearerToken);
    }
}

