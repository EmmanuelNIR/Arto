using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEF.Models
{
    public class Figure
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }
        public int Coefficient { get; set; }

        public virtual ICollection<FigureInSet> FiguresInSet { get; set; }
    }
}
