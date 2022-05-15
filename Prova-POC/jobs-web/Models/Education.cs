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

        public string Institution { get; set; }
        public string Course { get; set; }

        public CourseType CourseType { get; set; }
        public DateTime StartDate { get; set; }

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

