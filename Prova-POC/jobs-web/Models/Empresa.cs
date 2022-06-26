using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace jobs_web.Models
{
    [Table("Empresa")]
    public class Empresa
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "CNPJ")]
        [Required(ErrorMessage = "Por favor, preencha o campo")]
        public string cnpj { get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "Por favor, preencha o campo")]
        public string descricao { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Por favor, preencha o campo")]
        public string nome { get; set; }

        [Display(Name = "contato")]
        [Required(ErrorMessage = "Por favor, preencha o campo")]
        public string contato { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        public virtual Jobs.Models.User User { get; set; }

        public ICollection<Vagas> Vagas { get; set; }

    }
}
