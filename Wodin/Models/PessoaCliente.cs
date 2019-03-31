using Wodin.Models.Base;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Wodin.Models
{
    public class PessoaCliente : CamposComuns
    {
        [Required]
        [DefaultValue(false)]
        public bool Cliente { get; set; }

        [DataType(dataType: DataType.Currency)]
        [Display(Name = "Limite de Crédito")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal? LimiteCredito { get; set; }

        //Relacionamentos
        public virtual Pessoa Pessoa { get; set; }
        public int PessoaId { get; set; }

        public virtual FormaPagamento FormaRecebimento { get; set; }
        [Display(Name = "Forma de Pagamento")]
        public int FormaRecebimentoId { get; set; }

        public virtual PrazoPagamento PrazoRecebimento { get; set; }
        [Display(Name = "Prazo de Pagamento")]
        public int PrazoRecebimentoId { get; set; }
    }
}
