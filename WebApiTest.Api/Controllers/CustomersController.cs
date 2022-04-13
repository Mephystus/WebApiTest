namespace WebApiTest.Api.Controllers;

using DataSource;
using Microsoft.AspNetCore.Mvc;
using Models;

[Route("api/[controller]")]
[ApiController]
public class CustomersController : ControllerBase
{
    [HttpGet("{id:int}")]
    public IActionResult GetCustomer(int id)
    {
        var customers = CustomerDataSource.GetCustomers();

        var customer = customers.FirstOrDefault(x => x.Id == id);

        if (customer != null)
        {
            return Ok(customer);
        }

        var message = $"Customer {id} does not exist!";

        return NotFound(message);
    }

    [HttpDelete("{id:int}")]
    public IActionResult DeleteCustomer(int id)
    {
        int count = CustomerDataSource.DeleteCustomer(id);

        return Ok(count);
    }

    [HttpPost]
    public IActionResult CreateCustomer(Customer customer)
    {
        CustomerDataSource.CreateCustomer(customer);

        return Ok();
    }

    [HttpPut]
    public IActionResult UpdateCustomer(Customer customer)
    {
        CustomerDataSource.UpdateCustomer(customer);

        return Ok();
    }
}