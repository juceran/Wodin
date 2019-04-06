using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Wodin.Models.Base;

namespace Wodin.Models
{
    public class UsuarioPermissaoAcesso : CamposComuns
    {
        [Required]
        [DefaultValue(false)]
        public bool Visualizar { get; set; }

        [Required]
        [DefaultValue(false)]
        public bool Incluir { get; set; }

        [Required]
        [DefaultValue(false)]
        public bool Editar { get; set; }

        [Required]
        [DefaultValue(false)]
        public bool Imprimir { get; set; }

        [Required]
        [DefaultValue(false)]
        public bool Baixar { get; set; }

        [Required]
        [DefaultValue(false)]
        public bool Cancelar { get; set; }

        [Required]
        [DefaultValue(false)]
        public bool CancelarBaixa { get; set; }

        //referencias de relacionamentos
        public Empresa Empresa { get; set; }
        [Display(Name = "Empresa")]
        public int EmpresaId { get; set; }

        public Pessoa Pessoa { get; set; }
        [Display(Name = "Usuário")]
        public int PessoaId { get; set; }


        //public ICollection<PessoaUsuario> PessoaUsuario { get; set; } = new List<PessoaUsuario>();
        [Display(Name = "Menu")]
        public Menu Menu { get; set; }
        public int MenuId { get; set; }

        [Display(Name = "SubMenu")]
        public SubMenu SubMenu { get; set; }
        public int SubmenuId { get; set; }
    }
}
