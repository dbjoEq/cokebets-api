using Asp.Versioning;
using CokeBets.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CokeBets.Controllers.V1;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/[controller]")]
public class UsersController : ControllerBase
{
    private readonly ILogger<CustomerController> _logger;
    private readonly IUsersService _usersService;


    public UsersController(ILogger<CustomerController> logger, IUsersService usersService)
    {
        _logger = logger;
        _usersService = usersService;
    }

    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [HttpGet(Name = "GetAllUsers")]
    public async Task<IActionResult> GetAllUsers()
    {
        try
        {
            var users = await _usersService.GetAllUsers();
            return Ok(users);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return NotFound();
        }
    }
}