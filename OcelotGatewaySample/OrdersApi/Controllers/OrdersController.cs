using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace OrdersApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrdersController : ControllerBase
    {
       
        private static readonly List<Order> orders = new List<Order>
        {
            new Order { OrderId = 1001, CustomerName = "Alice", ProductName = "Wireless Bluetooth Headphones", Quantity = 1, OrderDate = DateTime.Parse("2025-04-30") },
            new Order { OrderId = 1002, CustomerName = "Bob", ProductName = "Organic Green Tea", Quantity = 3, OrderDate = DateTime.Parse("2025-05-01") },
            new Order { OrderId = 1003, CustomerName = "Charlie", ProductName = "Yoga Mat - Non Slip", Quantity = 2, OrderDate = DateTime.Parse("2025-05-02") }
        };
        private readonly ILogger<OrdersController> _logger;

        public OrdersController(ILogger<OrdersController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetOrders")]
        public IEnumerable<Order> Get()
        {
            return orders.ToArray();
        }
    }
}
