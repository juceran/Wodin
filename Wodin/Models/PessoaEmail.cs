using Wodin.Models.Base;
using Wodin.Models.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wodin.Models
{
    public class PessoaEmail : CamposComuns
    {
        [Required]
        [DefaultValue(false)]
        [Display(Name = "Email")]
        public bool Emails { get; set; }

        [Column(TypeName = "varchar(64)")]
        [Required(ErrorMessage = "e-mail é um campo obrigatório!")]
        [EmailAddress(ErrorMessage = "O e-mail informado é inválido!")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        //enums
        public EmailTipo Tipo { get; set; }

        //referencias de relacionamentos
        public int PessoaId { get; set; }
        public Pessoa Pessoa { get; set; }
    }
}
