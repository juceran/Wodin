using Wodin.Models.Base;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Wodin.Models
{
    public class PessoaFornecedor : CamposComuns
    {
        [Required]
        [DefaultValue(false)]
        public bool Fornecedor { get; set; }

        //Relacionamentos
        public int PessoaId { get; set; }
        public virtual Pessoa Pessoa { get; set; }

        public virtual FormaPagamento FormaPagamento { get; set; }
        [Display(Name = "Forma de Pagamento")]
        public int FormaPagamentoId { get; set; }

        public virtual PrazoPagamento PrazoPagamento { get; set; }
        [Display(Name = "Prazo de Pagamento")]
        public int PrazoPagamentoId { get; set; }
    }
}
