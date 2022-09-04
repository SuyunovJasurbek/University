using System.Linq.Expressions;
using WebApi.Entities;

namespace WebApi.Repositories;

public  interface IUniversityRepository
{
     University GetById (Guid Id);
     ValueTask<University> Create(Entities.University entity) ;
     ValueTask<University> Delete (Entities.University delete);
     IEnumerable<University> GetAll ();
}
