namespace JobFinder.Infrastructure.Services;

internal sealed class JobService : IJobService
{
    private readonly IGenericRepository<Job> _jobRepository;
    private readonly IGenericRepository<Location> _locationRepository;

    public JobService(IGenericRepository<Job> jobRepository)
        => _jobRepository = jobRepository;

    public async Task<IEnumerable<JobDTO>> GetJobsAsync()
    {
        var allJobs = await _jobRepository.GetAllAsync();

        return allJobs.Select(x => new JobDTO()
        {
            Id = x.Id,
            Position = x.Position,
            MaxSalary = x.MaxSalary,
            MinSalary = x.MinSalary
        });
    }

    public async Task AddJobAsync(AddJobDTO dto)
    {
        var job = new Job()
        {
            Position = dto.Position,
            MinSalary = dto.MinSalary,
            MaxSalary = dto.MaxSalary,
            CategoryId = dto.CategoryId,
            Locations = _locationRepository.GetByIdListAsync(dto.LocationsIds).Result,
            Skills =  
        };

        await _jobRepository.AddAsync(job);
    }

    public async Task DeleteJobAsync()
        => await _jobRepository.DeleteAsync(new Job());
}

