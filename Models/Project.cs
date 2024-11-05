using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Company.Models
{
    public class Project
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Pnumber { get; set; }

        [Required]
        [MaxLength(50)]
        public string Pname { get; set; }

        [Required]
        [MaxLength(100)]
        public string Plocation { get; set; }

        [ForeignKey("DepartmentNum")]
        public int Dnum { get; set; }
        public Department Department { get; set; }

        public virtual ICollection<works_on> Works_Ons { get; set; }

    }
}
