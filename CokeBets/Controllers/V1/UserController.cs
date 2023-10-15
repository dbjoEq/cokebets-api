using Asp.Versioning;
using CokeBets.Interfaces;
using CokeBets.Models;
using Microsoft.AspNetCore.Mvc;

namespace CokeBets.Controllers.V1;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/[controller]")]
public class UserController : ControllerBase
{
    private readonly ILogger<UserController> _logger;
    private readonly IUsersService _usersService;


    public UserController(ILogger<UserController> logger, IUsersService usersService)
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
    
    /// <summary>
    ///     Returns user with given id
    /// </summary>
    /// <param name="userId">The user id as configured in the SQL Server</param>
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [HttpGet("{userId}", Name = "GetUserWithId")]
    public async Task<IActionResult> GetUserWithId(int userId)
    {
        var user = _usersService.GetUser(userId);
        if (user == null)
        {
            return NotFound();
        }

        return Ok(user);
    }
}