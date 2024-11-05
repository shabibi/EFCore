using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum Gender { Male, Female }

namespace Company.Models
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SSN { get; set; }

        [Required]
        [MaxLength(20)]
        public string Fname { get; set; }

        [Required]
        [MaxLength(20)]
        public string Lname { get; set; }
        public DateTime Bdate { get; set; }
        public string EmployeeAddress { get; set; }
        Gender gender { get; set; }

        [Range(500, 3500)]
        public double Salary { get; set; }

        [ForeignKey("Supervisor")]
        public int Super_ssn { get; set; }
        public virtual Employee Supervisor { get; set; }

        [InverseProperty("Supervisor")]
        public virtual ICollection<Employee> Supervisees { get; set; }
        public virtual Department Department { get; set; }

        public virtual ICollection<works_on> Works_Ons { get; set; }

        public virtual ICollection<Dependent> Dependents { get; set; }
    }
}
