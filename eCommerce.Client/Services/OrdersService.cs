using System;
using AutoMapper;
using AutoMapper.Features;
using AutoMapper.Internal;
using AutoMapper.QueryableExtensions;
using eCommerce.Data.Context;
using eCommerce.Data.Dtos;
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;
using static System.Reflection.Metadata.BlobBuilder;

namespace eCommerce.Client.Services
{
    public class OrdersService : IOrdersService
    {
        private readonly ECommerceContext _context;
        private readonly IMapper _mapper;

        public OrdersService(ECommerceContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<OrderReturnDto> GetOrderByIdAsync(int orderId)
        {
            var orderEntity =  _context.Orders
                .Include(o => o.Products)
                .Include(o => o.Customer)
                .Include(o => o.Customer.Address)
                .FirstOrDefault(o => o.Id == orderId);

            return _mapper.Map<OrderReturnDto>(orderEntity); 
        }

        public async Task<Order> AddOrderAsync(OrderDto orderDto)
        {


            var productEntity = _mapper.Map<List<Product>>(orderDto.Products);
            var customerEntity = _mapper.Map<Customer>(orderDto.Customer);
            var addressEntity = _mapper.Map<Address>(orderDto.Customer.Address);
            var orderEntity = _mapper.Map<Order>(orderDto);

            customerEntity.Address = addressEntity;
            orderEntity.Customer = customerEntity;
            orderEntity.Products = productEntity;

            await HandleTotalPriceAsync(orderEntity);

            orderEntity.OrderDate = DateTime.Now;

            _context.Orders.Add(orderEntity);
            _context.SaveChanges();

            return orderEntity;

        }

        //Apply discounts and add up total price
        private async Task HandleTotalPriceAsync(Order entity)
        {
            if (entity.Products != null)
            {
                decimal total = 0;
                decimal discountAmount = 0;
                foreach (var product in entity.Products)
                {
                    if (product.OnSale)
                    {
                        product.Price = product.Price * product.Quantity;
                        discountAmount = product.Price * (decimal)product.Discount / 100;

                        product.Price -= discountAmount;

                        total += product.Price;
                    }
                    else
                    {

                        product.Price = product.Price * product.Quantity;
                        total += product.Price;
                    }
                }

                entity.TotalPrice = total;
            }
        }
    }
}

