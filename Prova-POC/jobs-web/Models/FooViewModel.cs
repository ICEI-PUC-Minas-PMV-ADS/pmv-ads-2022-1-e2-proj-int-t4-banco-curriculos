using Jobs.Models;
using jobs_web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jobs.Models
{
    public class FooViewModel
    {
        public IEnumerable<User> Users { get; set; }
        public IEnumerable<Candidate> Candidates { get; set; }
        public IEnumerable<ProfessionalExperience> ProfessionalExperiences { get; set; }
        public IEnumerable<Education> Educations { get; set; }
        public IEnumerable<Empresa> Empresas { get; set; }
    }
}
