using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NassquaAPI.Models
{
    public class Experiences
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ExperiencesId { get; set; }

        public int HostsId { get; set; }
        public Hosts Hosts { get; set; }

        public int CitiesId { get; set; }
        public Cities Cities { get; set; }

        public int ExperiencesTypesId { get; set; }
        public ExperiencesTypes ExperiencesTypes { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(9000)]
        public string Description { get; set; }

        [StringLength(9000)]
        public string PlanDescription { get; set; }

        [StringLength(9000)]
        public string Notes { get; set; }

        [StringLength(9000)]
        public string Place { get; set; }

        [StringLength(9000)]
        public string CancelPolicy { get; set; }
                
    }
}
