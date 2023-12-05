namespace JobFinder.Application.DTOs;

public class AddJobDTO
{
    public string Position { get; set; } = string.Empty;
    public double MinSalary { get; set; }
    public double MaxSalary { get; set; }
}
