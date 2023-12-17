using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobFinder.Infrastructure.Services
{
    public sealed class ServiceContainer : IServiceContainer
    {
        public ILocationService LocationService { get ;set; }
        public IJobService JobService { get ; set ; }
        public ICategoryService CategoryService { get ; set ; }
        public ISkillService skillService { get ; set ; }

        public ServiceContainer(ILocationService locationService, IJobService jobService, ICategoryService categoryService, ISkillService skillService)
        {
            LocationService = locationService;
            JobService = jobService;
            CategoryService = categoryService;
            this.skillService = skillService;
        }
    }
}
