using jobs_web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jobs.Models
{
    public class AllViewModel
    {
        public Candidate TheCandidate { get; set; }
        public ProfessionalExperience TheProfessionalExperience { get; set; }
        public Education TheEducation { get; set; }
    }
}
