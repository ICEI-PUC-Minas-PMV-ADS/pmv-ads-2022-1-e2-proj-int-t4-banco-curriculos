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
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        public DateTime Birthdate { get; set; }

        [Display(Name = "Gênero")]
        [Required(ErrorMessage = "Por favor, preencha o campo")]
        public Gender Gender { get; set; }

        [Display(Name = "Raça")]
        [Required(ErrorMessage = "Por favor, preencha o campo")]
        public Race Race { get; set; }

        [Display(Name = "PCD")]
        [Required(ErrorMessage = "Por favor, preencha o campo")]
        public Pwd Pwd { get; set; }

        [Display(Name = "CPF")]
        [Required(ErrorMessage = "Por favor, preencha o campo")]
        public string Cpf { get; set; }

        public string Linkedin { get; set; }

       // [Display(Name="Candidato")]
        //public int CandidateId { get; set; }

       // [ForeignKey("UserId")]
       // public virtual User User { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        public virtual User User { get; set; }

        public ICollection<ProfessionalExperience> ProfessionalExperiences { get; set; }
        public ICollection<Education> Educations { get; set; }
    }

    public enum Gender
    {
        Feminino,
        Masculino,
        [Display(Name = "Prefiro não dizer")]
        Nao
    }

    public enum Pwd
    {
        Sim,
        [Display(Name = "Não")]
        Nao
    }

    public enum Race
    {
        Branca,
        Preta,
        Parda,
        Amarela,
        [Display(Name = "Indígena")]
        Indigena
    }
}
