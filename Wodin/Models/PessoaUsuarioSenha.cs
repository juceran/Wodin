using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Wodin.Models.Base;

namespace Wodin.Models
{
    public class PessoaUsuarioSenha : CamposComuns
    {
        [Column(TypeName = "varchar(128)")]
        [DataType(DataType.Password)]
        [StringLength(10, MinimumLength = 4)]
        [Display(Name = "Senha")]
        public string Senha { get; set; }

        //Relacionamentos     
        public int PessoaUsuarioId { get; set; }
        public PessoaUsuario PessoaUsuario { get; set; }
    }
}