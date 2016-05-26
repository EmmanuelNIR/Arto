using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEF.Models
{
    public class Set
    {
        [Key]
        public long Id { get; set; }
        public string Name { get; set; }

        public Parcour Parcour { get; set; }
        public virtual ICollection<FigureInSet> FigureInSets { get; set; }
    }
}
