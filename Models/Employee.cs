using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace track_that.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime HireDate { get; set; }
        public decimal Hours { get; set; }
        
        [Required]
        public string UserID { get; set; }
        public ApplicationUser User { get; set; }
    }
}
