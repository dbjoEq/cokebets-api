using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CokeBets.Models;

public class Bet
{
    [Key]
    [Column("bet_id")]
    public int BetId { get; set; }
    [Column("player_one")]
    public int PlayerOne { get; set; }
    [Column("player_two")]
    public int PlayerTwo { get; set; }
    [Column("bet_prompt")]
    public string? Prompt { get; set; }
    [Column("status")]
    public string? Status { get; set; }
    [Column("prize")]
    public string? Prize { get; set; }
    [Column("winner")]
    public int? Winner { get; set; }
    [Column("created_at")]
    public DateTime CreatedAt { get; set; }
    [Column("completed_at")]
    public DateTime? CompletedAt { get; set; }
    
}