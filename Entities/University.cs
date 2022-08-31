using System.ComponentModel.DataAnnotations;

namespace WebApi.Entities;

public class University
{
    public Guid? Id { get; set; }
    public int Rooms { get; set; }
    public string?  Email { get; set; } 
    [Required]
    public string? Name { get; set; }
    public string? Adres { get; set; }
    [Required]
    public string? Category { get; set; }
    [Required]
    public ulong AccountNumber { get; set; }
}