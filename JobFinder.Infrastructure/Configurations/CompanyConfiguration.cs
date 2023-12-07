using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobFinder.Infrastructure.Configurations
{
    internal sealed class CompanyConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasMany(com => com.Locations).WithOne(l => l.Company).HasForeignKey(l => l.CompanyId);
            builder.HasMany(com => com.Jobs).WithOne(J => J.Company).HasForeignKey(j => j.CompanyId); 
        }
    }
}
