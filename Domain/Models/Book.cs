using System;
namespace Domain.Models
{
    public class Book : BaseEntity
    {
        public string Title { get; set; }
        public decimal Price { get; set; }
        public int Bookstand { get; set; }
        public int Shelf { get; set; }
        public ICollection<Author> Authors { get; set; }
    }
}

