using WebApi.Data;
using WebApi.Entities;

namespace WebApi.Repositories;
public class UniversityRepository : IUniversityRepository 
{
    private readonly AppDbContext _context;

    public  UniversityRepository(AppDbContext context )
        {
            _context = context;
        }


    public async ValueTask<University> Create(University entity)
    { 
       var create = _context.universeties.Add(entity);
       await _context.SaveChangesAsync();   
       return create.Entity;
    }
    

    
    public async ValueTask<University> Delete(University delete)
    {
         var deletentry=_context.universeties.Remove(delete);      
         await _context.SaveChangesAsync();
         return deletentry.Entity;
    }

    public IQueryable<University> GetAll()
    {
       var getAl =_context.Set<University>();
       return getAl;
    }

    public University GetById(Guid Id)
    {
       var getId=_context.Set<University>().Find();
       return getId;
    }
}

