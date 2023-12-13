

namespace JobFinder.Application.Repository
{
    public interface IRepositoryCollection
    {
        IGenericRepository<Job> _jobRepository { get;set; }
        IGenericRepository<Location> _locationRepository { get; set; }
        IGenericRepository<Skill> _skillRepository { get; set; }
        IGenericRepository<Category> _categoryRepository { get; set; }
    }
}
