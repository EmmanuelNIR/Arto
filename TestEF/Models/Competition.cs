using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEF.Models
{
    public class Competition
    {
        public enum CompetitionType{
            PARCOUR,
            KO,
        }
        [Key]
        public long Id { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public String Adresse { get; set; }

        public CompetitionType Type { get; set; }
    }
}
