using System;
using eCommerce.Data.Context;
using eCommerce.Data.Dtos;


namespace eCommerce.Client.Services
{
    public interface IOrdersService
    {
        Task<OrderReturnDto> GetOrderByIdAsync(int orderId);

        Task<Order> AddOrderAsync(OrderDto orderDto);

    }

}

