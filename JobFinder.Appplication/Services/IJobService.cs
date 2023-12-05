namespace JobFinder.Application.Services;

public interface IJobService
{
    Task<IEnumerable<JobDTO>> GetJobsAsync();

    Task AddJobAsync(AddJobDTO dto);
    Task DeleteJobAsync();
}
