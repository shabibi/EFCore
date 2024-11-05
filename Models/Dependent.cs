using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Models
{
    [PrimaryKey(nameof(Essn), nameof(Dependent_name))]
    public class Dependent 
    {
        [ForeignKey("Employee")]
        public int Essn { get; set; }
        public Employee Employee { get; set; }

        [Required]
        [MaxLength(50)]
        public string Dependent_name { get; set; }

        [MaxLength(10)]
        public string Relationship { get; set; }
        public DateTime Bdate { get; set; }
        public Gender DGender { get; set; }


    }
}
