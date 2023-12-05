using JobFinder.Infrastructure.Configurations;
using System.Reflection;

namespace JobFinder.Infrastructure.Data;

internal sealed class ApplicationDbContext : DbContext
{
    public DbSet<Job> Jobs => Set<Job>();

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        //Q: this line find all Configurations in project?
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}   
