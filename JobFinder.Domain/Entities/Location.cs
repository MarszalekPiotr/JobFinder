

namespace JobFinder.Domain.Entities
{
    public sealed class Location : BasicEntity
    {
        public string Name { get; set; } = string.Empty;
        public double X { get; set; }
        public double Y { get; set; }

        public Guid CompanyId { get; set; }
        public Company Company { get; set; }
        public IEnumerable<Job>? Jobs { get; set; }
        // Idk how to handle this coordinates and so on
    }
}
