using JobFinder.Application.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JobFinder.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillController : ControllerBase
    {
        private readonly IServiceContainer _serviceContainer;

        public SkillController(IServiceContainer serviceContainer) => _serviceContainer = serviceContainer;

        [HttpPost("AddSkill")]
        public async Task<IActionResult> AddSkill(AddSkillDTO addSkillDTO)
        {
            await _serviceContainer.skillService.AddSkillAsync(addSkillDTO);
            return Ok();
        }

        [HttpGet("Skill")]
        public async Task<IActionResult> GetSkill(Guid id) 
        {
            return Ok(await _serviceContainer.skillService.GetSkillAsync(id));
        }

    }
}
