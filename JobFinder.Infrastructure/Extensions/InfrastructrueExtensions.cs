﻿namespace JobFinder.Infrastructure.Extensions;

public static class InfrastructrueExtensions
{
    public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("JobFinderDb")));

        services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

        services.AddScoped<IJobService, JobService>();
        services.AddScoped<ICategoryService, CategoryService>();
     
    }
}
