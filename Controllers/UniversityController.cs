using Microsoft.AspNetCore.Mvc;
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
    IUniversityService universityService)
    {
        _universityService=universityService;
    }

  [HttpGet]
   public async Task<IActionResult> GetAll()
   {
      if(!ModelState.IsValid)
      {
         return BadRequest();
      }
      
    var get = await _universityService.Get();
    return Ok(get.Select(ToDtos));
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
   } 


   [HttpGet]
   [Route("{id}")]
   public async Task<IActionResult> GetIdSearch ([FromRoute] Guid id)
   {
      if(!ModelState.IsValid)
      {
         return BadRequest(id);
      }
   
      var getId= await _universityService.GetId(id);
      return Ok(ToDtos(getId)); 
   }


   [HttpDelete]
   [Route("{Id}")]
   public async Task<IActionResult> DeleteId([FromBody]Guid Id)
   {
      if(!ModelState.IsValid)
      {
         return BadRequest(Id);
      }

      var deleteId = await _universityService.DeleteID(Id);
      return Ok(ToDtos(deleteId));
   }
}
