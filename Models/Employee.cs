using System;
using System.Dynamic;
using System.ComponentModel.DataAnnotations;

namespace Blazorfrontendsample.Models
{
    public class Employee
    {
        public int employeeId { get; set; }

        [Required(ErrorMessage = "Firts Name is required")]
        [StringLength(100,MinimumLength = 2)]

        public string firstName { get; set; }
        [Required]

        public string lastName { get; set; }
        [Required]

        public string email { get; set; }

        public DateTime dateofBirth { get; set; }

        public Gender gender { get; set; }

        public int departmentId { get; set; }

        public string departmentName { get; set; }

        public string PhotoPath { get; set; }
    }
    public enum Gender{
        Male,Female
    }
}