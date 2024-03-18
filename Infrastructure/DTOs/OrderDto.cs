using System;
namespace Applications.DTOs
{
    public class OrderDto
    {
        public string OrderId { get; set; }
        public List<OrderLineDto> OrderLines { get; set; }
    }
}

