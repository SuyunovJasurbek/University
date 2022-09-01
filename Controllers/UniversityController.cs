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
   [Route("{id}")]
   public async Task<IActionResult> GetIdSearch ([FromBody] Guid id)
   {
      var getId=_universityService.GetId(id);
      return Ok(); 
   }

   [HttpDelete]
   [Route("{Id}")]
   public async Task<IActionResult> DeleteId(Guid Id)
   {
      var deleteId =_universityService.DeleteID;
      return Ok(deleteId);
   }
   [HttpGet]
   public async Task<IActionResult> Get ()
   {
    var alo  =  _context.universeties.ToListAsync();
    return Ok(alo);
   }


}
