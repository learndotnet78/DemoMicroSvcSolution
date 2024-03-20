using DemoOrderService.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoOrderService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        [HttpGet]
        public List<Order> GetOrders()
        {
            List<Order> orders = new List<Order>()
            {
                new Order { OrderId = 1, CustomerId = 1, OrderDate = new DateTime(2024, 01, 01), OrderAmount = 1200},
                new Order { OrderId = 2, CustomerId = 2, OrderDate = new DateTime(2024, 02, 01), OrderAmount = 1500},
                new Order { OrderId = 3, CustomerId = 3, OrderDate = new DateTime(2024, 03, 01), OrderAmount = 1800},
            };

            return orders;
        }
    }
}
