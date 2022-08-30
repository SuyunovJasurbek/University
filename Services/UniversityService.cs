using WebApi.Models;
using WebApi.Repositories;

namespace WebApi.Services;
public partial class UniversityService : IUniversityService
{
    private ILogger<UniversityService> _logger;
    private IUniversityRepository _universityRepository;

    public UniversityService(ILogger <UniversityService> logger ,
    IUniversityRepository universityRepository )
    {
        _logger =logger;
        _universityRepository=universityRepository;
    }


    public  async ValueTask<University> CreateUniversity(Models.University model)
    { // uzgarib kelgan model dan Data ga joylash uchun entityga ugirish
        var entity = new Entities.University()
        {
          Id=model.Id,
          Rooms=model.Rooms,
          Adres=model.Adres,
          AccountNumber=model.AccountNumber,
          Name=model.Name,
          Category=model.Category,
        };

        var nimadir = await _universityRepository.Create(entity);
        
        return ToModel(nimadir);
    }
// chala
    public ValueTask<University> Deleteuniversety(University remove)
    {
        throw new NotImplementedException();
    }
}