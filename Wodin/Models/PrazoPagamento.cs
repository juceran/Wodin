using Microsoft.AspNetCore.Mvc;
using Wodin.Models.Base;
using Wodin.Models.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wodin.Models
{
    public class PrazoPagamento : CamposComuns
    {
        [Column(TypeName = "varchar(64)")]
        [MinLength(3, ErrorMessage = "Nome deve ter pelo menos 3 caracteres")]
        [Required(ErrorMessage = "Descrição é um campo obrigatório")]
        [DisplayName("Descrição")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Prazo de pagamento dever ter no mínimo uma parcela")]
        [DefaultValue(1)]
        [Display(Name = "Parcelas")]
        public int Parcelas { get; set; }

        [Required(ErrorMessage = "Dias da primeira parcela")]
        [DefaultValue(0)]
        [Display(Name = "Primeira Parcela")]
        public int PrimeiraParcela { get; set; }


        [Required(ErrorMessage = "Dias entre parcelas")]
        [DefaultValue(0)]
        [Display(Name = "Dias Parcelas")]
        public int DiasParcela { get; set; }

        [Required(ErrorMessage = "Limite mínimo para esse prazo")]
        [Display(Name = "Limite")]
        [DataType(dataType: DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:C}")]
        [DefaultValue(0)]
        //[ModelBinder(binderType: typeof(PtBr))
        public decimal Limite { get; set; }

        [Required]
        [Display(Name = "Prazo Médio")]
        [DataType(dataType: DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:N}")]
        [DefaultValue(1)]
        public decimal PrazoMedio { get; set; }

        [Required]
        [Display(Name = "Baixa Lançamento")]
        [DefaultValue(false)]
        public bool BaixaLancamento { get; set; }

        //enums
        [Display(Name = "Tipo")]
        public PrazoPagamentoTipo PrazoPagamentoTipo { get; set; }

        //referencias de relacionamentos
        public Empresa Empresa { get; set; }
        [Display(Name = "Empresa")]
        public int EmpresaId { get; set; }
    }
}
