using JobFinder.Application.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JobFinder.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        IServiceContainer _serviceContainer;
        public LocationController(IServiceContainer serviceContainer)
        { 
            _serviceContainer = serviceContainer;
        }

        [HttpPost("AddLocation")]
        public async Task<IActionResult> AddLocation(AddLocationDTO dto)
        {
            await _serviceContainer.LocationService.AddLocationAsync(dto);
            return Ok();
        }

        [HttpGet("GetLocation")]
        public async Task<IActionResult> GetLocation(Guid id) => Ok(await _serviceContainer.LocationService.GetLocationAsync(id));
    }
}
