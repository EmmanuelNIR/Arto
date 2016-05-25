using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEF.Models
{
    public class FigureInSet
    {
        [Key, Column(Order = 0)]
        public long FigureId { get; set; }
        [Key, Column(Order = 1)]
        public long SetId { get; set; }

        public virtual Figure Figure { get; set; }
        public virtual Set Set { get; set; }

        public int Order { get; set; }

    }
}
