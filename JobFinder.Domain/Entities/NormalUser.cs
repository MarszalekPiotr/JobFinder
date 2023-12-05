using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobFinder.Domain.Entities
{
     public sealed class NormalUser
     {   
        // Q: is this Id even necessary?
        public Guid Id { get; set; }
        [ForeignKey("UserId")]
        public Guid UserId { get; set; }
        public User User { get; set; }

        public string Description { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string ContactEmail { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;

        // Relation with Skills 
        public IEnumerable<Skill>? Skills { get; set; } 

        IEnumerable<ApplicationForJob>? Applications { get; set;}


     }
}
