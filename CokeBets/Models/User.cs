using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CokeBets.Models;

public class User
{
    [Key]
    [Column("user_id")]
    public int UserId { get; set; }
    [Column("external_provider_id")]
    public int ExternalProviderId { get; set; }
    [Column("email_address")]
    public string? EmailAddress { get; set; }
}