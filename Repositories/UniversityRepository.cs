using System.Linq;
using Microsoft.EntityFrameworkCore;
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

    public University GetById(Guid Id)
    {
      var getId=_context.universeties.Find(Id);
      return getId;
    }


    public async ValueTask<University> Create(University entity)
    { 
       var create = _context.universeties.Add(entity);
       await _context.SaveChangesAsync();   
       return create.Entity;
    }


    public async ValueTask<University> Delete(University delete)
    {
        var uchirish  = _context.universeties.Remove(delete);
        await _context.SaveChangesAsync();
        return uchirish.Entity;
    }


    public IEnumerable<University> GetAll()
    {
       var getAl =_context.universeties.ToList();
       return getAl;
    }
}

