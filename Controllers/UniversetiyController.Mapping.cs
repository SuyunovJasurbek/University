namespace WebApi.Controllers;

public partial class UniversityController
{
  //dtos dan modelga utish
   public static Models.University ToModel(Dtos.University dtos)
   {
     var model =  new Models.University()
     {
       Rooms=dtos.Rooms,
       Name=dtos.Name,
       Adres=dtos.Adres,
       Email=dtos.Email,
       Category=dtos.Category.ToString()
     };
     return model;
   }
}
