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
        [Display(Name = "Ocupação")]
        public string Occupation { get; set; }

        [Display(Name = "Tipo de emprego")]
        [Required(ErrorMessage = "Por favor, preencha o campo")]
        public JobType JobType { get; set; }

        [Display(Name = "Nome da empresa")]
        [Required(ErrorMessage = "Por favor, preencha o campo")]
        public string CompanyName { get; set; }

        [Display(Name = "Cidade da empresa")]
        [Required(ErrorMessage = "Por favor, preencha o campo")]
        public string Locality { get; set; }

        [Display(Name = "Data de início")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MM-yyyy}")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        [Required(ErrorMessage = "Por favor, preencha o campo")]
        public DateTime StartDate { get; set; }

        [Display(Name = "Data de conclusão")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MM-yyyy}")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        public DateTime EndDate { get; set; }

        [Display(Name = "Descrição")]
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
