using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using jobs_web.Models;

namespace Jobs.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<ProfessionalExperience> ProfessionalExperiences { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<jobs_web.Models.Empresa> Empresa { get; set; }
        public DbSet<jobs_web.Models.Vagas> Vagas { get; set; }

    }
}
