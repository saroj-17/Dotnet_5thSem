using System; 
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeManagementSystem.Models
{
    public class Employee
    {
        [Key]
        public string EmpNo { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        [Display(Name = "Phone Number")]
        public string Phone { get; set; }
        public string Company { get; set; }
        public string Department { get; set; }

        [Display(Name = "Joined Date")]
        [DataType(DataType.Date)]
        public DateTime JoiningDate { get; set; }

        public decimal Salary { get; set; }
    }
}

