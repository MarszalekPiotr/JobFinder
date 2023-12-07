

namespace JobFinder.Domain.Entities
{
    public sealed class Company
    {
        [Key]
        [ForeignKey("UserId")]
        public Guid UserId { get; set; }
        public User User { get; set; }

        public string CompanyName { get; set; } = string.Empty;
        public string CompanyDescription { get; set; } = string.Empty;
        public string CompanyContactEmail { get; set; } = string.Empty;
        public string CompanyLogoPath { get; set; } = string.Empty;

        // Job Relation
        public IEnumerable<Job>? Jobs { get; set; } 
        public IEnumerable<Location>?  Locations { get; set; }

    }
}
