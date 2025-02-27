using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MLE.Order.Application.Dtos;
using MLE.Order.Application.Interfaces.Services;

namespace MLE.Order.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpPost("create-order")]
        public async Task<IActionResult> CreateOrder(CreateOrderDto request)
        {
            await _orderService.CreateOrder(request);
            return Ok();
        }
        [HttpGet("get-orders")]
        public async Task<IActionResult> GetOrders()
        {
            
            return Ok(await _orderService.GetAll());
        }
    }
}