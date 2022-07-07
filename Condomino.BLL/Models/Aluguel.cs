using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condominio.BLL.Models
{
    public class Aluguel
    {
        public int AluguelId { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório. Favor preencher!")]
        [Range(0, int.MaxValue, ErrorMessage = "Valor informado inválido!")]
        public decimal Valor { get; set; }
        [Display(Name = "Mês")]
        public int MesId { get; set; }

        public Mes Mes { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório. Favor preencher!")]
        [Range(2020, 2030, ErrorMessage = "Valor informado inválido!")]
        public int Ano { get; set; }

        public virtual ICollection<Pagamento> Pagamentos { get; set; }
    }
}
