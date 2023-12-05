using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobFinder.Infrastructure.Configurations
{
    internal sealed class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasOne(u => u.NormalUser).WithOne(nu => nu.User).HasForeignKey<User>(u => u.NormalUserId);
            builder.HasOne(u => u.Company).WithOne(c => c.User).HasForeignKey<User>(u => u.CompanyId);
        }
    }
}
