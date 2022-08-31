using WebApi.Models;

namespace WebApi.Services;

public interface IUniversityService
{
    ValueTask<University> CreateUniversity (Models.University model);
    ValueTask<University> DeleteID (Guid id );
    ValueTask<University> GetId(Guid id );
    ValueTask<University> Get();
}