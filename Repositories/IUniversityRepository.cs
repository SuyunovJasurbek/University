using WebApi.Entities;

namespace WebApi.Repositories;

public  interface IUniversityRepository
{
    public ValueTask<University> Create(Entities.University entity) ;
    public ValueTask<University> Delete (Entities.University delete);

}