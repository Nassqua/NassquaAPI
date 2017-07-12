using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NassquaAPI.Models
{
    public class ExperiencesDates
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ExperiencesDatesId { get; set; }

        public int ExperiencesId { get; set; }
        public Experiences Experiences { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
            
    }
}
