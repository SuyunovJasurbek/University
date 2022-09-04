using System.ComponentModel.DataAnnotations;

namespace WebApi.Dtos;

public class University
{
    [Required]
    public int Rooms { get; set; }
    [Required]
    public string? Name { get; set; }
    [Required]
    public string? Adres { get; set; }
    [Required]
    [EmailAddress]
    public string?  Email { get; set; }
    [Required]
    public ECategory Category { get; set; }
    [Required]
    public ulong AccountNumber { get; set; }

}