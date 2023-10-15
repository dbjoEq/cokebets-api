using System.ComponentModel.DataAnnotations;

namespace CokeBets.Models;

public class Customer
{
    [Key]
    public long CustomerId { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? CompanyName { get; set; }
}