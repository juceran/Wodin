using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Wodin.Models.Base;
using Wodin.Models.Enums;

namespace Wodin.Models
{
    public class PessoaUsuario : CamposComuns
    {
        [Required]
        [DefaultValue(false)]
        [Display(Name = "Usuário")]
        public bool User { get; set; }

        [Column(TypeName = "varchar(64)")]
        [Display(Name = "Usuário")]
        public String Usuario { get; set; }

        //referencias de relacionamentos 
        public int PessoaId { get; set; }
        public virtual Pessoa Pessoa { get; set; }

        public PessoaUsuarioSenha PessoaUsuarioSenha { get; set; }

        //enums
        [Display(Name = "Usuário Padrão")]
        public UsuarioTipo UsuarioTipo { get; set; }
    }
}