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
    IUniversityService universityService,
    AppDbContext context)
    {
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
   } 


   [HttpGet]
   [Route("{id}")]
   public async Task<IActionResult> GetIdSearch ([FromBody] Guid id)
   {
      if(!ModelState.IsValid)
      {
         return BadRequest(id);
      }
   
      var getId=_universityService.GetId(id);
      return Ok(ToDtos(getId.Result)); 
   }


   [HttpDelete]
   [Route("{Id}")]
   public async Task<IActionResult> DeleteId([FromBody]Guid Id)
   {
      if(!ModelState.IsValid)
      {
         return BadRequest(Id);
      }
      var deleteId =_universityService.DeleteID(Id);
      return Ok(deleteId.Result);
   }


   [HttpGet]
   public async Task<IActionResult> GetAll()
   {
    var get = _universityService.Get();
    return Ok(get.Result);
   }
}