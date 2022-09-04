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
    {
        // uzgarib kelgan model dan Data ga joylash uchun entityga ugirish
        var nimadir = await _universityRepository.Create(ToEntity(model));   
        return ToModel(nimadir);
    }

    public async ValueTask<University> DeleteID(Guid id)
    {
        var deleteID =  _universityRepository.GetById(id);
        var delet=  await _universityRepository.Delete(deleteID);
        return ToModel(delet);
    }


    public async ValueTask<IEnumerable<University>> Get()
    {
        var getal =  _universityRepository.GetAll();
        return  getal.Select(ToModel);
    }

    public async  ValueTask<University> GetId(Guid id)
    {       
        var IdSearch =  _universityRepository.GetAll().FirstOrDefault(t=>t.Id==id);
        return ToModel(IdSearch);
    }
  

}