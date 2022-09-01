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

    public async ValueTask<University> DeleteID(Guid id)
    {
        var deleteID = _universityRepository.GetById(id);
        var delet= _universityRepository.Delete(deleteID);
        return new ();
    }
    public ValueTask<University> GetId(Guid id)
    {
        var IdSearch = _universityRepository.GetAll().FirstOrDefault(t=>t.Id==id);
        return  new (ToModel(IdSearch));
    }

        public ValueTask<University> Get()
    {
        throw new NotImplementedException();
    }

    // chala

}