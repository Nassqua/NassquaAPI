using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NassquaAPI.Models
{
    public class NassquaContext : DbContext
    {
        public NassquaContext(DbContextOptions<NassquaContext> options):base(options)    
        {

        }

        public DbSet<Experiences> Experiences { get; set; }
        public DbSet<Hosts> Hosts { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Owners> Owners { get; set; }
        public DbSet<Countries> Countries { get; set; }
        public DbSet<Cities> Cities { get; set; }
        public DbSet<ExperiencesDetails> ExperiencesDetails { get; set; }
        public DbSet<ExperiencesTypes> ExperiencesTypes { get; set; }
        public DbSet<ExperiencesDates> ExperiencesDates { get; set; }



    }
}
