using System.Security.Cryptography.X509Certificates;
namespace WebApi.Services;

public partial class UniversityService 
{

 //entitiydan modelga utish
   public static Models.University ToModel(Entities.University entity)
   {
    var modelgo = new Models.University ()
    {
        Id=entity.Id,
        Name=entity.Name,
        AccountNumber=entity.AccountNumber,
        Adres=entity.Adres,
        Email=entity.Email,
        Rooms=entity.Rooms,
        Category = entity.Category
    };
    return modelgo;
   }
 //modeldan entityga utish 
     public static Entities.University ToEntity(Models.University model)
    {
        var entity = new Entities.University()
        {
          Id=model.Id,
          Rooms=model.Rooms,
          Adres=model.Adres,
          AccountNumber=model.AccountNumber,
          Name=model.Name,
          Category=model.Category,
          Email=model.Email
        };
        return entity;
    }

}
