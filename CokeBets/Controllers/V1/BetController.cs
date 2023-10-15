using Asp.Versioning;
using CokeBets.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CokeBets.Controllers.V1;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/[controller]")]
public class BetController: ControllerBase
{
    private readonly ILogger<BetController> _logger;
    private readonly IBetService _betService;

    public BetController(ILogger<BetController> logger, IBetService betService)
    {
        _logger = logger;
        _betService = betService;
    }

    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [HttpGet(Name = "GetAllBets")]
    public async Task<IActionResult> GetAllBets()
    {
        var bets = await _betService.GetAllBets();
        return Ok(bets);
    }
    
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [HttpGet("active", Name = "GetAllActiveBets")]
    public async Task<IActionResult> GetAllActiveBets()
    {
        var bets = await _betService.GetAllActiveBets();
        return Ok(bets);
    }
    
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [HttpGet("completed", Name = "GetAllCompletedBets")]
    public async Task<IActionResult> GetAllCompletedBets()
    {
        var bets = await _betService.GetAllCompletedBets();
        return Ok(bets);
    }


    /// <summary>
    ///     Returns bet with given id
    /// </summary>
    /// <param name="betId">The bet id as configured in the SQL Server</param>
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [HttpGet("{betId}", Name = "GetBetWithId")]
    public async Task<IActionResult> GetBet(int betId)
    {
        var bet = _betService.GetBet(betId);
        if (bet == null)
        {
            return NotFound();
        }

        return Ok(bet);
    }
    
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [HttpGet("{userId}/active", Name = "GetAllActiveBetsForUser")]
    public async Task<IActionResult> GetAllActiveBetsForUser(int userId)
    {
        var bets = await _betService.GetAllActiveBetsForUser(userId);
        return Ok(bets);
    }
    
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [HttpGet("{userId}/completed", Name = "GetAllCompletedBetsForUser")]
    public async Task<IActionResult> GetAllCompletedBetsForUser(int userId)
    {
        var bets = await _betService.GetAllCompletedBetsForUser(userId);
        return Ok(bets);
    }
    
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [HttpGet("{userId}", Name = "GetAllBetsForUser")]
    public async Task<IActionResult> GetAllBetsForUser(int userId)
    {
        var bets = await _betService.GetAllBetsForUser(userId);
        return Ok(bets);
    }
}