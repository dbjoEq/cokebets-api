using Asp.Versioning;
using CokeBets.Interfaces;
using CokeBets.Models;
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

    public async Task<IActionResult> GetMockUser()
    {
        var mockUser = new Users()
        {
            UserId = 90909090,
            ExternalProviderId = "120391203910293012",
            EmailAddress = "testUser@testMail.com"
        };
        return Ok(mockUser);
    }
}