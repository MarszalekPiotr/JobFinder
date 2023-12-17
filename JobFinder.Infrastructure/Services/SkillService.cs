using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobFinder.Infrastructure.Services
{
    public sealed class SkillService : ISkillService
    {
        private readonly IRepositoryCollection _repositoryCollection;

        public SkillService(IRepositoryCollection repositoryCollection)
        {
            _repositoryCollection = repositoryCollection;
        }

        public async Task AddSkillAsync(AddSkillDTO dto)
        {   

            await _repositoryCollection._skillRepository.AddAsync(new Skill { Name = dto.Name });
        }

        public async Task<SkillDTO> GetSkillAsync(Guid skillId)
        {
            var skill = await _repositoryCollection._skillRepository.GetByIdAsync(skillId);
            return new SkillDTO() { Id = skill.Id, Name = skill.Name };
        }
    }
}
