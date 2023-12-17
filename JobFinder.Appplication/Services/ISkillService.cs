using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobFinder.Application.Services
{
    public interface ISkillService
    {
        Task AddSkillAsync(AddSkillDTO skill);
        Task<SkillDTO> GetSkillAsync(Guid skillId);


    }
}
