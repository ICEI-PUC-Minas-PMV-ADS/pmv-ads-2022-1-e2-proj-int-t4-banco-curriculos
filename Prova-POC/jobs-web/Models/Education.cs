using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Jobs.Models
{
    [Table("Educations")]
    public class Education
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Instituição")]
        [Required(ErrorMessage = "Por favor, preencha o campo")]
        public string Institution { get; set; }

        [Display(Name = "Curso")]
        [Required(ErrorMessage = "Por favor, preencha o campo")]
        public string Course { get; set; }

        [Display(Name = "Tipo do curso")]
        [Required(ErrorMessage = "Por favor, preencha o campo")]
        public CourseType CourseType { get; set; }

        [Display(Name = "Data de início")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MM-yyyy}")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        [Required(ErrorMessage = "Por favor, preencha o campo")]
        public DateTime StartDate { get; set; }

        [Display(Name = "Data de conclusão")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MM-yyyy}")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        public DateTime EndDate { get; set; }

        [ForeignKey("Candidate")]
        public int CandidateId { get; set; }
        public Candidate Candidate { get; set; }
    }

    public enum CourseType{
        Bacharelado,
        [Display(Name ="Ensino Fundamental")]
        Fundamental,
        Licenciatura,
        [Display(Name ="Ensino Médio")]
        Medio,

       [Display(Name ="Técnico")]
        Tecnico,
        [Display(Name ="Tecnólogo")]
        Tecnologo
    }
}

