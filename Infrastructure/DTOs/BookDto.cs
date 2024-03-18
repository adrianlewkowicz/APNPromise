using System;
namespace Applications.DTOs
{
    public class BookDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public int Bookstand { get; set; }
        public int Shelf { get; set; }
        public List<AuthorDto> Authors { get; set; }
    }
}

