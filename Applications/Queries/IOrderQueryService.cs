using System;
using Applications.DTOs;

namespace Applications.Queries
{
    public interface IOrderQueryService
    {
        Task<List<OrderDto>> GetOrdersAsync(string bearerToken);
    }
}

