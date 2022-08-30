using WebApi.Models;

namespace WebApi.Services;

public interface IUniversityService
{
    ValueTask<University> CreateUniversity (Models.University model);
    ValueTask<University> Deleteuniversety (Models.University remove);
}