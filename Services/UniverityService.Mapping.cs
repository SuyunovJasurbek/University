using System.Security.Cryptography.X509Certificates;
namespace WebApi.Services;

public partial class UniversityService 
{

 //entitiydan modelga utish
   public static Models.University ToModel(Entities.University entity)
   {
    var modelgo = new Models.University ()
    {
        Name=entity.Name,
        AccountNumber=entity.AccountNumber,
        Adres=entity.Adres,
        Email=entity.Email,
        Id=entity.Id,
        Rooms=entity.Rooms
    };
    return modelgo;
   }
}
