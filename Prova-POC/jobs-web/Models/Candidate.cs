using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Jobs.Models
{
    [Table("Candidate")]
    public class Candidate
    {
        [Key]
        public int Id { get; set; }


        [Required(ErrorMessage = "Por favor, preencha o campo")]
        [Display(Name = "Data de Nascimento")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MM-yyyy}")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        public DateTime Birthdate { get; set; }

        [Display(Name = "Gênero")]
        [Required(ErrorMessage = "Por favor, preencha o campo")]
        public string Gender { get; set; }

        [Display(Name = "Raça")]
        [Required(ErrorMessage = "Por favor, preencha o campo")]
        public string Race { get; set; }

        [Display(Name = "PCD")]
        [Required(ErrorMessage = "Por favor, preencha o campo")]
        public string Pwd { get; set; }

        [Display(Name = "CPF")]
        [Required(ErrorMessage = "Por favor, preencha o campo")]
        public string Cpf { get; set; }

        public string Linkedin { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        public virtual User User { get; set; }

        public ICollection<ProfessionalExperience> ProfessionalExperiences { get; set; }
        public ICollection<Education> Educations { get; set; }
    }

}