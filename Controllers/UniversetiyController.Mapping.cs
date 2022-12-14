using System.Reflection;
using System.Xml;
using WebApi.Dtos;

namespace WebApi.Controllers;

public partial class UniversityController
{
  //dtos dan modelga utish
   public static Models.University ToModel(Dtos.University dtos)
   {
     var model =  new Models.University()
     {
       Id=Guid.NewGuid(),
       Rooms=dtos.Rooms,
       Name=dtos.Name,
       Adres=dtos.Adres,
       Email=dtos.Email,
       AccountNumber=dtos.AccountNumber,
       Category=dtos.Category.ToString()
     };
     return model;
   }

  //model dan dtosga utish
   public static  Dtos.University ToDtos( Models.University model )
   {
    var dtos = new Dtos.University ()
    {
      Rooms=model.Rooms,
      Name=model.Name,
      Adres=model.Adres,
      Email=model.Email,
      AccountNumber=model.AccountNumber,
      Category=model.Category switch
      {
        "Business"=>ECategory.Business,
        "ExactSciences"=>ECategory.Medicine,
        "Programming"=>ECategory.Programming,
         _ => ECategory.ExactSciences
      }
    };
    return dtos;
   }
}
