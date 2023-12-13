using JobFinder.Application.DTOs;
using Microsoft.AspNetCore.Identity;

namespace JobFinder.API.Controllers;

[ApiController]
[Route("[controller]")]
public class JobController : ControllerBase
{
    private readonly IJobService _service;


    public JobController(IJobService service)
        => _service = service;

    [HttpGet("jobs")]
    public async Task<IActionResult> GetJobs()
        => Ok(await _service.GetJobsAsync());

    [HttpPost("job")]
    public async Task<IActionResult> AddJob(AddJobDTO dto)
    {
        await _service.AddJobAsync(dto);
        return Ok();
    }  
}