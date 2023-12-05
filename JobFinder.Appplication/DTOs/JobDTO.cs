namespace JobFinder.Application.DTOs;

public class JobDTO
{
    public Guid Id { get; set; }
    public string Position { get; set; } = string.Empty;
    public double MinSalary { get; set; }
    public double MaxSalary { get; set; }
}
