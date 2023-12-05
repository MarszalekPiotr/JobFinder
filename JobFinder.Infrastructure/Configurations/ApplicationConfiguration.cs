using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobFinder.Infrastructure.Configurations
{
    internal sealed class ApplicationConfiguration : IEntityTypeConfiguration<ApplicationForJob>
    {
        public void Configure(EntityTypeBuilder<ApplicationForJob> builder)
        {
            builder.HasKey(app => new { app.JobId, app.ApplicantId });
        }
    }
}
