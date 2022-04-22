namespace WebApiTest.Api.Controllers;

using Microsoft.AspNetCore.Mvc;
using Models;
using Services.DataSource;
using Services.Interfaces;

[Route("api/[controller]")]
[ApiController]
public class CustomersController : ControllerBase
{
    private readonly ICustomerService _customerService;

    public CustomersController(ICustomerService customerService)
    {
        _customerService = customerService;
    }

    [HttpGet("{id:int}")]
    public IActionResult GetCustomer(int id)
    {
        var customer = _customerService.GetCustomer(id);

        return Ok(customer);
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