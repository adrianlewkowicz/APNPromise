using System;
namespace Domain.Models
{
    public class Order : BaseEntity
    {
        public string OrderId { get; set; }
        public ICollection<OrderLine> OrderLines { get; set; }
    }
}

