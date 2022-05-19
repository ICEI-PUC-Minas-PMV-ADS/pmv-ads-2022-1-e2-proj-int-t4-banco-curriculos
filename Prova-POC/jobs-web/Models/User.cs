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
        public string Address { get; set; }
        [Required(ErrorMessage = "Por favor, preencha o campo")]
        public string Neighborhood { get; set; }
        [Required(ErrorMessage = "Por favor, preencha o campo")]
        public string City { get; set; }
        [Required(ErrorMessage = "Por favor, preencha o campo")]
        public int ZipCode { get; set; }
        [Required(ErrorMessage = "Por favor, preencha o campo")]
        public string State { get; set; }
        [Required(ErrorMessage = "Por favor, preencha o campo")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Por favor, preencha o campo")]
        public string CellPhone { get; set; }
        [Required(ErrorMessage = "Por favor, preencha o campo")]
        public string Perfil { get; set; }
        public DateTime RegistrationDate { get; set; }

        public virtual Candidate Canditate { get; set; }
        public virtual jobs_web.Models.Empresa Empresa { get; set; }
    }
}
