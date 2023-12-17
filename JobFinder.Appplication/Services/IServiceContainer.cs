using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobFinder.Application.Services
{
    public interface IServiceContainer 
    {
        public ILocationService LocationService { get; set; }
        public IJobService JobService { get; set; }
        public ICategoryService CategoryService { get; set; }
        public ISkillService skillService { get; set; }


    }
}
