namespace WebApi.Models;

public class University
{
    public Guid? Id { get; set; }
    public int Rooms { get; set; }
    public string?  Email { get; set; } 
    public string? Name { get; set; }
    public string? Adres { get; set; }
    public string? Category { get; set; }
    public ulong AccountNumber { get; set; }
}