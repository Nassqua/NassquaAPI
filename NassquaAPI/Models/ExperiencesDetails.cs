using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NassquaAPI.Models
{
    public class ExperiencesDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ExperiencesDetailsId { get; set; }

        public int ExperiencesId { get; set; }
        public Experiences Experiences { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(500)]
        public string Description { get; set; }
               
        public int OwnersId { get; set; }

        public float Duration { get; set; }

        [Column(TypeName = "Money")]
        public decimal Cost { get; set; }
        
        public bool Required { get; set; }
               
    }
}
