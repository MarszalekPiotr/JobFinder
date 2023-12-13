

namespace JobFinder.Domain.Entities;

public sealed class Job : BasicEntity
{
    
    public string Position { get; set; } = string.Empty;
    public double MinSalary { get; set; }
    public double MaxSalary { get; set; }
    // Relation properties
    [ForeignKey("CompanyId")]
    public Guid? CompanyId { get; set; }
    public Company? Company { get; set; }
    public IEnumerable<Location> Locations { get; set; }
    public IEnumerable<ApplicationForJob>? Applications { get; set; }
    public IEnumerable<Skill>? Skills { get; set; }

    

    [ForeignKey("CategoryId")]
    public Guid CategoryId { get; set; }
    public Category Category { get; set; }
}
