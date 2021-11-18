using System;
using System.Dynamic;

namespace Blazorfrontendsample.Models
{
    public class Employee
    {
        public int employeeId { get; set; }

        public string firstName { get; set; }

        public string lastName { get; set; }

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