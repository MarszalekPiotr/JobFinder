

namespace JobFinder.Domain.Entities
{
    public sealed class JobSkill  
    {
        public Guid JobId { get; set; }
        public Job Job { get; set; }

        public Guid SkillId { get; set; }
        public Skill Skill { get; set; }
        public LevelEnum Level { get; set; }
    }
}
