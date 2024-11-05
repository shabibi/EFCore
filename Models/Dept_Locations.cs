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
    [PrimaryKey(nameof(Dnumber), nameof(Dlocation))]
    public class Dept_Locations
    {
        [ForeignKey("Department")]
        public int Dnumber { get; set; }
        public virtual Department Department { get; set; }

        [MaxLength(100)]
        public string Dlocation { get; set; }

    }
}
