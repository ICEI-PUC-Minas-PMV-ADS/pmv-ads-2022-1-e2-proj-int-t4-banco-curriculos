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

        [Required(ErrorMessage = "Por favor, preencha o campo")]
        public string Occupation { get; set; }

        [Required(ErrorMessage = "Por favor, preencha o campo")]
        public JobType JobType { get; set; }

        [Required(ErrorMessage = "Por favor, preencha o campo")]
        public string CompanyName { get; set; }

        [Required(ErrorMessage = "Por favor, preencha o campo")]
        public string Locality { get; set; }

        [Required(ErrorMessage = "Por favor, preencha o campo")]
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string Description { get; set; }

        [ForeignKey("Candidate")]
        public int CandidateId { get; set; }

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
