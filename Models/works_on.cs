using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Models
{
    [PrimaryKey(nameof(ESS), nameof(Pno))]
    public class works_on
    {
        [ForeignKey("Employee")]
        public int ESS { get; set; }
        public Employee Employee { get; set; }

        [ForeignKey("Project")]
        public int Pno { get; set; }
        public Project Project { get; set; }

        public int Hrs { get; set; }
    }
}
