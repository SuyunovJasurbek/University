using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi.Data;
using WebApi.Services;

namespace WebApi.Controllers;
[ApiController]
[Route("[controller]")]
public partial class UniversityController :ControllerBase
{
    private readonly ILogger<UniversityController> _logger;
    private readonly IUniversityService _universityService;
    private readonly AppDbContext _context;
    public UniversityController(
    ILogger<UniversityController> logger ,
    IUniversityService universityService,
    AppDbContext context)
    {
        _logger =logger;
        _universityService=universityService;
        _context =context;
    }
  
   [HttpPost]
   public async Task<IActionResult> PostUniversity ([FromBody]Dtos.University dto )
   {
    if(!ModelState.IsValid)
    {
      return BadRequest(dto);
    }
     var createUniversityResult = await _universityService.CreateUniversity(ToModel(dto)); 

     return CreatedAtAction(nameof(PostUniversity), dto);
    //return Ok();
   }


   [HttpGet]

   public async Task<IActionResult> Get()
   {
     return Ok(_context.universeties.ToListAsync());
   }



   [HttpGet]
   [Route("{id}")]
   public async Task<IActionResult> GetIdSearch ( Guid id)
   {
      var getId=_universityService.GetId(id);
      return Ok(getId); 
   }









  //  [HttpDelete]
  //  [Route("[delete]")]

  //  public async Task<IActionResult> DeleteId(Guid Id)
  //  {
      
  //  }


}
