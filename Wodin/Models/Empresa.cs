using Wodin.Models.Base;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wodin.Models
{
    public class Empresa : CamposComuns
    {
        [Column(TypeName = "varchar(64)")]
        public string Database { get; set; }

        [Column(TypeName = "varchar(16)")]
        public string CNPJ { get; set; }

        [Column(TypeName = "varchar(32)")]
        public string IE { get; set; }

        [Column(TypeName = "varchar(64)")]
        [Display(Name = "Razão social")]
        public string RazaoSocial { get; set; }

        [Column(TypeName = "varchar(64)")]
        public string Fantasia { get; set; }

        [Display(Name = "Data de Abertura")]
        //[DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0: dd/MM/yyyy}")]
        [Column(TypeName = "Date")]
        public DateTime? DataAbertura { get; set; }

        [Column(TypeName = "varchar(64)")]
        [Display(Name = "e-mail")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Column(TypeName = "varchar(64)")]
        public string Website { get; set; }

        [Column(TypeName = "varchar(8)")]
        public string CEP { get; set; }

        [Column(TypeName = "varchar(64)")]
        [MinLength(2, ErrorMessage = "Logradouro deve ter pelo menos 2 caracteres")]
        public string Logradouro { get; set; }

        [Column(TypeName = "varchar(64)")]
        [Display(Name = "Número")]
        public string Numero { get; set; }

        [Column(TypeName = "varchar(128)")]
        public string Complemento { get; set; }

        [Column(TypeName = "varchar(64)")]
        //[RequiredAttribute(ErrorMessage = "Bairro é obrigatório")]
        public string Bairro { get; set; }

        [Column(TypeName = "varchar(64)")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "A sigla do estado é um campo obrigatório!")]
        //[StringLength(2, MinimumLength = 2, ErrorMessage = "A sigla do estado deve ter 2 caracteres!")]
        public string Uf { get; set; }

        [Column(TypeName = "varchar(16)")]
        public string Unidade { get; set; }

        [Column(TypeName = "varchar(16)")]
        public string IBGE { get; set; }

        [Column(TypeName = "varchar(64)")]
        public string GIA { get; set; }
    }
}
