using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobFinder.Domain.Entities
{
    public sealed class Company
    {
        [ForeignKey("UserId")]
        public Guid UserId { get; set; }
        public User User { get; set; }

        public string CompanyName { get; set; } = string.Empty;
        public string CompanyDescription { get; set; } = string.Empty;
        public string CompanyContactEmail { get; set; } = string.Empty;
        public string CompanyLogoPath { get; set; } = string.Empty;

        // Job Relation
        public IEnumerable<Job>? Jobs { get; set; } 
        public IEnumerable<Location>?  Locations { get; set; }

    }
}
