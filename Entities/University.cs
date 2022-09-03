using System.Diagnostics;
using System.ComponentModel.DataAnnotations;

namespace WebApi.Entities;

public class University
{
    public Guid Id { get; set; }
    public int Rooms { get; set; }
    public string?  Email { get; set; }  
    public string? Name { get; set; }
    public string? Adres { get; set; } 
    public string? Category { get; set; }
    public ulong AccountNumber { get; set; }
    
    [Obsolete("boshqa kostruktr ishlatib bulmaydi" )]
    public University()
    { }
    public University ( Guid id , int rooms, string email, string name, string adres, string category, ulong accountNumber)
    {
       Name=name;
       Rooms=rooms;
       Email=email;
       Name=name;
       Adres=adres;
       Category=category;
       AccountNumber=accountNumber;
    }
}