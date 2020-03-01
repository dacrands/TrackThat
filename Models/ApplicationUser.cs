using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace track_that.Models
{
    public class ApplicationUser : IdentityUser
    {
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
