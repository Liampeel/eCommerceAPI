using eCommerce.Data.Dtos;
using eCommerce.Client.Services;
using Microsoft.AspNetCore.Mvc;


namespace eCommerce.Client.Controllers
{
    [ApiController]
    [Route("orders")]
    public class OrdersController : ControllerBase
    {
        private readonly IOrdersService _ordersService;

        public OrdersController(IOrdersService ordersService)
        {
            _ordersService = ordersService;
        }

        [HttpGet("{orderId}")]
        public async Task<IActionResult> GetOrderById(int orderId)
        {
            var order = await _ordersService.GetOrderByIdAsync(orderId);

            if (order == null)
            {
                return NotFound();

            }
            return Ok(order);
        }

        [HttpPost]
        public async Task<IActionResult> PostOrder(OrderDto orderDto)
        {
            var orderId = await _ordersService.AddOrderAsync(orderDto);

            return Ok(orderId);
        }
    }
}

