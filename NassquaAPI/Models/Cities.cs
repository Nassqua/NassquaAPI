using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NassquaAPI.Models
{
    public class Cities
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CitiesId { get; set; } 

        public int CountriesId { get; set; }
        public Countries Countries { get; set; }

        [StringLength(100)]
        public string Name { get; set; }
    } 
}
