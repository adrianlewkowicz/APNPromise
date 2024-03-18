using System;
using Applications.DTOs;

namespace Applications.Queries
{
    public class OrderQueryService : IOrderQueryService
    {
        // Implementacja pobierania zamówień
        public Task<List<OrderDto>> GetOrdersAsync(string bearerToken)
        {
            throw new NotImplementedException();
        }
    }
}

