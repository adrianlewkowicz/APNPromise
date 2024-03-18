using System;
namespace Domain.Models
{
    public class OrderLine : BaseEntity
    {
        public int BookId { get; set; }
        public int Quantity { get; set; }
    }
}

