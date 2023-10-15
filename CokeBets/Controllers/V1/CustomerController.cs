using Asp.Versioning;
using CokeBets.Interfaces;
using CokeBets.Models;
using Microsoft.AspNetCore.Mvc;

namespace CokeBets.Controllers.V1;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/[controller]")]
public class CustomerController: ControllerBase
{

    private readonly ILogger<CustomerController> _logger;
    private readonly ICustomerService _customerService;
    
    public CustomerController(ILogger<CustomerController> logger, ICustomerService customerService)
    {
        _logger = logger;
        _customerService = customerService;
    }

    /// <summary>
    ///     Returns customer with given id
    /// </summary>
    /// <param name="customerId">The customer id as configured in the SQL Server</param>
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [HttpGet("{customerId}", Name = "GetCustomer")]
    public async Task<IActionResult> GetCustomer(long customerId)
    {
        var customer = await _customerService.GetCustomer(customerId);
        if (customer != null)
        {
            return Ok(customer);
        }

        return NotFound();
    }

    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [HttpGet(Name = "GetAllCustomers")]
    public async Task<IActionResult> GetAllCustomers()
    {
        try
        {
            var customers = await _customerService.GetAllCustomers();
            Console.WriteLine(customers);
            return Ok();
        }
        catch (Exception error)
        {
            Console.WriteLine(error);
            return NotFound();
        }
        
    }
    
}