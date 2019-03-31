using Wodin.Models.Base;
using Wodin.Models.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wodin.Models
{
    public class PessoaEndereco : CamposComuns
    {
        //https://www.receitaws.com.br/v1/cnpj/70000401000127
        //https://viacep.com.br/ws/57025350/json/
        [Required]
        [DefaultValue(false)]
        [Display(Name = "Endereço")]
        public bool Endereco { get; set; }

        [Column(TypeName = "varchar(8)")]
        public string CEP { get; set; }

        [Column(TypeName = "varchar(64)")]
        [MinLength(2, ErrorMessage = "Logradouro deve ter pelo menos 2 caracteres")]
        public string Logradouro { get; set; }

        [Column(TypeName = "varchar(128)")]
        public string Complemento { get; set; }

        [Column(TypeName = "varchar(64)")]
        [RequiredAttribute(ErrorMessage = "Município é obrigatório")]
        public string Bairro { get; set; }

        [Column(TypeName = "varchar(64)")]
        public string Localidade { get; set; }

        [Required(ErrorMessage = "A sigla do estado é um campo obrigatório!")]
        [StringLength(2, MinimumLength = 2, ErrorMessage = "A sigla do estado deve ter 2 caracteres!")]
        public string Uf { get; set; }

        [Column(TypeName = "varchar(16)")]
        public string Unidade { get; set; }

        [Column(TypeName = "varchar(16)")]
        public string IBGE { get; set; }

        [Column(TypeName = "varchar(64)")]
        public string GIA { get; set; }

        //enums
        public EnderecoTipo EnderecoTipo { get; set; }

        //Relacionamentos
        public int PessoaId { get; set; }
        public Pessoa Pessoa { get; set; }
    }
}
