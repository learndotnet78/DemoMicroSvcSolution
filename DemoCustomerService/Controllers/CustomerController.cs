using DemoCustomerService.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoCustomerService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        [HttpGet]
        public List<Customer> GetCustomers()
        {
            List<Customer> customers = new List<Customer>()
            {
                new Customer { CustomerId = 1, CustomerName = "Al Jones", CustomerAddress = "1 Penn Place", CustomerCity = "New York" },
                new Customer { CustomerId = 2, CustomerName = "Jerry S", CustomerAddress = "12 Amy Way", CustomerCity = "Dallas" },
                new Customer { CustomerId = 3, CustomerName = "Amy Patel", CustomerAddress = "10 Nicole Terrace", CustomerCity = "Los Angles" }
            };

            return customers;
        }
    }
}
