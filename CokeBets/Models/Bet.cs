using System.ComponentModel.DataAnnotations;

namespace CokeBets.Models;

public class Bet
{
    [Key]
    public long BetId { get; set; }
    public long PlayerOne { get; set; }
    public long PlayerTwo { get; set; }
    public string? Prompt { get; set; }
    public string? Status { get; set; }
    public string? Prize { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime CompletedAt { get; set; }
    
}