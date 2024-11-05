using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Models
{
    public class Department
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Dnumber { get; set; }

        [Required]
        [MaxLength(20)]
        public string Dname { get; set; }
        public DateTime Mgr_start_date { get; set; }
        [ForeignKey("Mangar")]
        public int Mgr_ssn { get; set; }

        [InverseProperty("Department")]
        public virtual ICollection< Employee> Employees { get; set; }

        public virtual ICollection<Dept_Locations> Dept_Locations { get; set; }

        public virtual ICollection<Project> Projects { get; set; }
    }
}
