using System;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementSystem.Models
{
    public class Employee
    {
        [Key]
        public int EmpNo { get; set; }

        public string Name { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        public string Company { get; set; }

        public string Department { get; set; }

        [Display(Name = "Joining Date")]
        [DataType(DataType.Date)]
        public DateTime JoiningDate { get; set; }

        public decimal Salary { get; set; }
    }
}
