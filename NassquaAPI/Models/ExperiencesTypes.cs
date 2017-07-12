using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NassquaAPI.Models
{
    public class ExperiencesTypes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ExperiencesTypesId { get; set; }

        [StringLength(500)]
        public string Description { get; set; }


    }
}
