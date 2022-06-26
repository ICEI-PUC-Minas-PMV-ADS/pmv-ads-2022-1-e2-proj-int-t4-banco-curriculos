using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace jobs_web.Models
{
    [Table("Vagas")]
    public class Vagas
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Por favor, preencha o campo")]
        public string Cargo { get; set; }

        [Required(ErrorMessage = "Por favor, preencha o campo")]
        public string descricao { get; set; }

        [Required(ErrorMessage = "Por favor, preencha o campo")]
        public int quantidade_vagas { get; set; }

        [Required(ErrorMessage = "Por favor, preencha o campo")]
        public bool status { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MM-yyyy}")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        public DateTime RegistrationDate { get; set; }

        [Required(ErrorMessage = "Por favor, preencha o campo")]
        public DateTime ClosingDate { get; set; }

        [ForeignKey("Empresa")]
        public int EmpresaId { get; set; }
        public Empresa Empresa { get; set; }

    }
}
