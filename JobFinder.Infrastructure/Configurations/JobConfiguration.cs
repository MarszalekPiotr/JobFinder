namespace JobFinder.Infrastructure.Configurations;

internal sealed class JobConfiguration : IEntityTypeConfiguration<Job>
{
    public void Configure(EntityTypeBuilder<Job> builder)
    {
        builder.ToTable("Jobs");
        builder.HasKey(x => x.Id);
        builder.HasOne(j => j.Category)
            .WithMany(c => c.Jobs)
            .HasForeignKey(j => j.CategoryId);

        builder.HasMany(j => j.Locations)
            .WithMany(l => l.Jobs);

        builder.HasMany(j => j.Skills)
            .WithMany(s => s.Jobs)
            .UsingEntity<JobSkill>(
              js => js.HasOne(js => js.Skill).WithMany().HasForeignKey(js => js.SkillId),

              js => js.HasOne(js => js.Job).WithMany().HasForeignKey(js => js.JobId),

              js => js.HasKey(js => new { js.JobId, js.SkillId })
              );
            
    }
}
