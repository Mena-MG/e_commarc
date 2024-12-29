using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp4
{
    public class Employee
    {
        
        public int EmployeeId { get; set; }
        public string Emp_Name { get; set; }
        public int Age { get; set; }
        [Required]
        public int DepartmentID { get; set; } // Navigation property
        [ForeignKey("DepartmentID")]
        public Department department { get; set; }

    }
}
