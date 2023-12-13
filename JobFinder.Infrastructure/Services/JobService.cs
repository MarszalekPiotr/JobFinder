namespace JobFinder.Infrastructure.Services;

internal sealed class JobService : IJobService
{
    private readonly IRepositoryCollection _repositoryCollection;

    public JobService(IRepositoryCollection repositoryCollection)
        => _repositoryCollection = repositoryCollection;

    public async Task<IEnumerable<JobDTO>> GetJobsAsync()
    {
        var allJobs = await _repositoryCollection._jobRepository.GetAllAsync();

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
            Locations = _repositoryCollection._locationRepository.GetByIdListAsync(dto.LocationsIds).Result,
            Skills =  _repositoryCollection._skillRepository.GetByIdListAsync(dto.SkillsIds).Result,
            //CompanyId = dto.CompanyId,
        };

        await  _repositoryCollection._jobRepository.AddAsync(job);
    }

    public async Task DeleteJobAsync()
        => await _repositoryCollection._jobRepository.DeleteAsync(new Job());
}

