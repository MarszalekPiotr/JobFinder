using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobFinder.Infrastructure.Repositories
{
    internal class RepositoryCollection : IRepositoryCollection
    {
        public IGenericRepository<Job> _jobRepository { get  ; set ; }
        public IGenericRepository<Location> _locationRepository { get; set; }
        public IGenericRepository<Skill> _skillRepository { get; set ; }
        public IGenericRepository<Category> _categoryRepository { get; set; }

        public RepositoryCollection(IGenericRepository<Job> jobRepository, IGenericRepository<Location> locationRepository, IGenericRepository<Skill> skillRepository, IGenericRepository<Category> categoryRepository)
        {
            _categoryRepository = categoryRepository;
            _jobRepository = jobRepository;
            _locationRepository = locationRepository;
            _skillRepository = skillRepository;
        }
    }
}
