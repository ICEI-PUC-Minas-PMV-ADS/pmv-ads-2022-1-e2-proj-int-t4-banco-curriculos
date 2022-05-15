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


        public string Name { get; set; }


        public DateTime Birthdate { get; set; }

        public Gender Gender { get; set; }


        public Race Race { get; set; }

        public Pwd Pwd { get; set; }


        public int Cpf { get; set; }


        public int Rg { get; set; }

        public string Linkedin { get; set; }

        [Display(Name="Candidato")]
        public int CandidateId { get; set; }

        [ForeignKey("UserId")]

        public User User { get; set; }



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
