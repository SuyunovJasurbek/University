using WebApi.Entities;

namespace WebApi.Repositories;

public  interface IUniversityRepository
{
     ValueTask<University> Create(Entities.University entity) ;
     ValueTask<University> Delete (Entities.University delete);
     IQueryable<University> GetAll (); 
     University GetById (Guid Id);
}
