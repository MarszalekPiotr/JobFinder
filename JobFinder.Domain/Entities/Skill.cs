

namespace JobFinder.Domain.Entities
{
    public sealed class Skill : BasicEntity
    {
        
        public string Name { get; set; } = string.Empty;    

        // Relation with NormalUser
       public  IEnumerable<NormalUser>? NormalUsers { get; set; }
        // Relation with Jobs
       public  IEnumerable<Job>? Jobs { get; set; }
    }
}
