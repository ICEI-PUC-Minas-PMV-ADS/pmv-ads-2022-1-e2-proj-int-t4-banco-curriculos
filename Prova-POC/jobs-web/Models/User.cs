using jobs_web.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Jobs.Models
{
    [Table("User")]
    public class User
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Por favor, preencha o campo")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Por favor, preencha o campo")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Por favor, preencha o campo")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
        [Required(ErrorMessage = "Por favor, preencha o campo")]

        [Display(Name = "Endereço")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Por favor, preencha o campo")]

        [Display(Name = "Bairro")]
        public string Neighborhood { get; set; }

        [Display(Name = "Cidade")]
        [Required(ErrorMessage = "Por favor, preencha o campo")]
        public string City { get; set; }

        [Display(Name = "Cep")]
        [Required(ErrorMessage = "Por favor, preencha o campo")]
        public int ZipCode { get; set; }
        [Required(ErrorMessage = "Por favor, preencha o campo")]

        [Display(Name = "Estado")]
        public string State { get; set; }
        [Required(ErrorMessage = "Por favor, preencha o campo")]

        [Display(Name = "Telefone")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Por favor, preencha o campo")]

        [Display(Name = "Celular")]
        public string CellPhone { get; set; }
        [Required(ErrorMessage = "Por favor, preencha o campo")]

        public string Perfil { get; set; }

        [Display(Name = "Data de registro")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MM-yyyy}")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        public DateTime RegistrationDate { get; set; }

        public virtual Candidate Canditate { get; set; }
        public virtual Empresa Empresa { get; set; }
    }
}
