using JobFinder.Infrastructure.Configurations;
using System.Reflection;

namespace JobFinder.Infrastructure.Data;

internal sealed class ApplicationDbContext : DbContext
{
    public DbSet<Job> Jobs => Set<Job>();
    public DbSet<Category> categories => Set<Category>();
    public DbSet<ApplicationForJob> Applications => Set<ApplicationForJob>();
    public DbSet<Skill> Skills => Set<Skill>();
    public DbSet<JobSkill> JobSkills => Set<JobSkill>();
    public DbSet<Location> Locations => Set<Location>();
    public DbSet<User> Users => Set<User>();
    public DbSet<NormalUser> NormalUsers => Set<NormalUser>();
    public DbSet<Company> Companies => Set<Company>();

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
