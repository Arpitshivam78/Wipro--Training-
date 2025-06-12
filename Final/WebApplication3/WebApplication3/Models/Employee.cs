using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class Employee
    {
        
            public int Id { get; set; }
           
            public string FullName { get; set; } = default!;
            public string Department { get; set; } = default!;
            public string Designation { get; set; } = default!;
            public decimal Salary { get; set; }
            public DateTime DateOfJoining { get; set; }
        }

    }

