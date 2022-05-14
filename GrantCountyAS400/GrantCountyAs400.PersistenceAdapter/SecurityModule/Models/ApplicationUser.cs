using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace GrantCountyAs400.PersistenceAdapter.SecurityModule.Models
{
    public class ApplicationUser : IdentityUser
    {
        [NotMapped]
        public List<string> Roles { get; set; }

        public bool HasAdminRole => Roles.Any(r => r.Equals("admin", StringComparison.InvariantCultureIgnoreCase));
    }
}