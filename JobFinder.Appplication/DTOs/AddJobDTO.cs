using JobFinder.Application.DTOs.CreatingJobDTO;
using JobFinder.Domain.Entities;

namespace JobFinder.Application.DTOs;

public class AddJobDTO
{   
    public string Position { get; set; } = string.Empty;
    public double MinSalary { get; set; }
    public double MaxSalary { get; set; }
    public Guid CategoryId { get; set; }
    public List<Guid> LocationsIds { get; set; }
    public List<Guid>? SkillsIds { get; set; }
    public Guid CompanyId { get; set; }


}
