using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Jobs.Models
{

    [Table("ProfessionalExperience")]
    public class ProfessionalExperience
    {
        [Key]
        public int Id { get; set; }

        public string Occupation { get; set; }

        public JobType JobType { get; set; }
        public string CompanyName { get; set; }
        public string Locality { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string Description { get; set; }

        [Display(Name = "Candidato")]
        public int CandidateId { get; set; }

        [ForeignKey("CandidateId")]
        public Candidate Candidate { get; set; }
    }

    public enum JobType
    {
        CLT,
        [Display(Name = "Estágio")]
        Estagio,
        PJ,
        [Display(Name ="Autônomo")]
        Autonomo
    }
}
