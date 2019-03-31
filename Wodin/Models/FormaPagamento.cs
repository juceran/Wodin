using System;
using Wodin.Models.Base;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Wodin.Models.Enums;

namespace Wodin.Models
{
    public class FormaPagamento : CamposComuns
    {
        [Column(TypeName = "varchar(64)")]
        [MinLength(3, ErrorMessage = "Nome deve ter pelo menos 3 caracteres")]
        [Required(ErrorMessage = "Descrição é um campo obrigatório")]
        [DisplayName("Descrição")]
        public string Descricao { get; set; }

        [Required]
        [Display(Name = "Gera Financeiro")]
        [DefaultValue(true)]
        public bool GeraFinanceiro { get; set; }

        [Required]
        [Display(Name = "Baixa Lançamento")]
        [DefaultValue(false)]
        public bool BaixaLancamento { get; set; }

        [Required]
        [Display(Name = "Cartão de Crédito")]
        [DefaultValue(false)]
        public bool CartaoCredito { get; set; }

        [Required]
        [Display(Name = "Vencimento")]
        [Range(0, 31)]
        [DefaultValue(0)]
        public int CartaoCreditoVencimento { get; set; }

        [Required]
        [Display(Name = "Melhor dia")]
        [Range(0, 31)]
        [DefaultValue(0)]
        public int CartaoCreditoMelhorDia { get; set; }

        //referencias de relacionamentos
        public Empresa Empresa { get; set; }
        [Display(Name = "Empresa")]
        public int EmpresaId { get; set; }

        //enums
        [Display(Name = "Tipo")]
        public FormaPagamentoTipo FormaPagamentoTipo { get; set; }

        [Display(Name = "Bandeira")]
        public CartaoDeCredito CartaoDeCredito { get; set; }

    }
}

