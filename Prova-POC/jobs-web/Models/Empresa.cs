using Jobs.Models;
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

        [Required(ErrorMessage = "Por favor, preencha o campo")]
        public string cnpj { get; set; }

        [Required(ErrorMessage = "Por favor, preencha o campo")]
        public string descricao { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        public virtual User User { get; set; }

        public ICollection<Vagas> Vagas{ get; set; }

    }
}
